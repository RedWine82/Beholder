﻿namespace Beholder
{
    using ff14bot;
    using ff14bot.AClasses;
    using ff14bot.Behavior;
    using ff14bot.Helpers;
    using LlamaLibrary.Memory;
    using System;
    using System.Threading;
    using System.Windows.Forms;

    public class Beholder : BotPlugin
    {
        internal Thread _guiThread;
        internal frmMain form;
        private static volatile int _pulseDelay = 500;
        private static volatile PulseFlags _pulseFlags = PulseFlags.Party | PulseFlags.GameEvents | PulseFlags.Navigator | PulseFlags.ObjectManager;
        private static Thread _pulseThread;
        private static volatile bool _pulseThreadRunning;

        public Beholder()
        {
            OffsetManager.Init();

            _pulseThread = new Thread(PulseThread) { IsBackground = true, Name = "Beholder Pulse Thread" };
            _pulseThreadRunning = true;
            _pulseThread.Start();
        }

        public override string Author => "RedWine";

        public override string ButtonText
        {
            get { return "Toggle"; }
        }

        public override string Name => "Beholder";
        public override Version Version => new Version(1, 0, 0);

        public override bool WantButton
        {
            get { return true; }
        }

        public override void Dispose()
        {
            CloseForm();
        }

        public override void OnButtonPress()
        {
            ToggleGUI();
        }

        public override void OnDisabled()
        {
            CloseForm();
        }

        public override void OnEnabled()
        {
            ToggleGUI();
        }

        public override void OnShutdown()
        {
            CloseForm();

            _pulseThreadRunning = false;
            _pulseThread.Join();
            base.OnShutdown();
        }

        public void ToggleGUI()
        {
            if (_guiThread == null || !_guiThread.IsAlive)
            {
                _guiThread = new Thread(() =>
                {
                    form = new frmMain();
                    form.ShowDialog();
                })
                {
                    IsBackground = true
                };

                _guiThread.SetApartmentState(ApartmentState.STA);
                _guiThread.Start();
            }
            else
            {
                CloseForm();
            }
        }

        private static void PulseThread()
        {
            while (_pulseThreadRunning)
            {
                try
                {
                    if (!TreeRoot.IsRunning)
                    {
                        Pulsator.Pulse(_pulseFlags);
                    }
                }
                catch (Exception e)
                {
                    Logging.WriteException(e);
                }

                Thread.Sleep(_pulseDelay);
            }
        }

        private void CloseForm()
        {
            if (form != null && form.Visible)
            {
                // close the form on the forms thread
                form.Invoke((MethodInvoker)delegate
                { form.Close(); });
            }
        }
    }
}