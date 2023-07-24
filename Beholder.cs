namespace Beholder
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

        public Beholder()
        {
            OffsetManager.Init();
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

        public override void OnShutdown()
        {
            CloseForm();

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