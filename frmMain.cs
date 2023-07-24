﻿namespace Beholder
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Forms;
    using ff14bot;
    using ff14bot.Behavior;
    using ff14bot.Managers;
    using ff14bot.Objects;
    using ff14bot.RemoteWindows;
    using LlamaLibrary.Extensions;

    public partial class frmMain : Form
    {
        private List<GameObject> gameObjects;

        public frmMain()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            if (Core.Player == null)
                return;

            Pulsator.Pulse(PulseFlags.All);

            txtPlayerId.Text = Core.Player.ObjectId.ToString();
            txtPlayerName.Text = Core.Player.Name;
            txtPlayerTargetId.Text = GameObjectManager.Target == null ? "NULL" : GameObjectManager.Target.ObjectId.ToString(); //Core.Player.CurrentTargetId.ToString();
            txtPlayerTargetName.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.Name; //Core.Player.CurrentTargetId.ToString();

            txtPlayerPositionX.Text = Core.Player.Location.X.ToString("0.00");
            txtPlayerPositionY.Text = Core.Player.Location.Y.ToString("0.00");
            txtPlayerPositionZ.Text = Core.Player.Location.Z.ToString("0.00");

            chkPlayerIsMounted.Checked = Core.Player.IsMounted;

            chkPlayerInCombat.Checked = Core.Player.InCombat;
            chkPlayerIsAlive.Checked = Core.Player.IsAlive;

            chkDutyManagerDutyReady.Checked = DutyManager.DutyReady;
            chkDutyManagerInInstance.Checked = DutyManager.InInstance;
            chkFateManagerWithinFate.Checked = FateManager.WithinFate;
            chkTalkDialogOpen.Checked = Talk.DialogOpen;

            txtPlayerMountId.Text = LocalPlayerExtensions.CurrentMount(Core.Player).ToString();

            txtMapId.Text = WorldManager.ZoneId.ToString();
            txtMapName.Text = WorldManager.CurrentZoneName;
            chkMapWorldManagerCanFly.Checked = WorldManager.CanFly;
            chkMapWorldManagerCanTeleport.Checked = WorldManager.CanTeleport();

            txtMapWeatherId.Text = WorldManager.CurrentWeatherId.ToString();
            txtMapWeather.Text = WorldManager.CurrentWeather;
        }

        private void UpdateGameObjects()
        {
            gameObjects = GameObjectManager.GameObjects.ToList();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateData();
            UpdateGameObjects();

            dgvGameObjects.DataSource = gameObjects;
            tmrUpdate.Enabled = true;
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrUpdate.Enabled = false;
        }

        private void dgvGameObjects_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
    }
}