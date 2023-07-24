namespace Beholder
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
    using LlamaLibrary.RemoteWindows;

    public partial class frmMain : Form
    {
        private List<GameObject> gameObjects;

        public frmMain()
        {
            InitializeComponent();
        }

        private void UpdateData()
        {
            chkCommonBehaviorsIsLoading.Checked = CommonBehaviors.IsLoading;

            Pulsator.Pulse(PulseFlags.All);

            if (Core.Player == null)
                return;

            // Player
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
            chkPlayerIsCasting.Checked = Core.Player.IsCasting;

            chkDutyManagerDutyReady.Checked = DutyManager.DutyReady;
            chkDutyManagerInInstance.Checked = DutyManager.InInstance;
            chkFateManagerWithinFate.Checked = FateManager.WithinFate;

            txtPlayerMountId.Text = LocalPlayerExtensions.CurrentMount(Core.Player).ToString();

            chkMovementManagerIsMoving.Checked = MovementManager.IsMoving;
            chkMovementManagerIsOccupied.Checked = MovementManager.IsOccupied;

            // Map
            txtMapId.Text = WorldManager.ZoneId.ToString();
            txtMapName.Text = WorldManager.CurrentZoneName;
            chkMapWorldManagerCanFly.Checked = WorldManager.CanFly;
            chkMapWorldManagerCanTeleport.Checked = WorldManager.CanTeleport();

            txtMapWeatherId.Text = WorldManager.CurrentWeatherId.ToString();
            txtMapWeather.Text = WorldManager.CurrentWeather;

            // UI
            chkConversationIsOpen.Checked = Conversation.IsOpen;
            chkGrandCompanyExchangeIsOpen.Checked = GrandCompanyExchange.Instance.IsOpen;
            chkGrandCompanySupplyListIsOpen.Checked = GrandCompanySupplyList.Instance.IsOpen;
            chkSelectYesnoIsOpen.Checked = SelectYesno.IsOpen;
            chkSelectIconStringIsOpen.Checked = SelectIconString.IsOpen;
            chkShopExchangeItemIsOpen.Checked = ShopExchangeItem.Instance.IsOpen;
            chkTalkDialogOpen.Checked = Talk.DialogOpen;

            chkCraftingLogIsOpen.Checked = CraftingLog.IsOpen;
            chkCraftingManagerIsCrafting.Checked = CraftingManager.IsCrafting;
            chkSynthesisIsOpen.Checked = Synthesis.IsOpen;
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