namespace Beholder
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Linq;
    using System.Windows.Forms;
    using Clio.Utilities;
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
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

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

            try
            {
                // Player
                txtPlayerId.Text = Core.Player.ObjectId.ToString();
                txtPlayerName.Text = Core.Player.Name;

                txtPlayerTargetId.Text = GameObjectManager.Target == null ? "NULL" : GameObjectManager.Target.ObjectId.ToString();
                txtPlayerTargetNpcId.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.NpcId.ToString();
                txtPlayerTargetName.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.Name;

                txtPlayerTargetPos.Text = GameObjectManager.Target == null ? "" : FormatPosition(GameObjectManager.Target.Location);

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

                txtMapWeatherId.Text = WorldManager.CurrentWeatherId.ToString();
                txtMapWeather.Text = WorldManager.CurrentWeather;

                txtMapPlayerPosition.Text = FormatPosition(Core.Player.Location);

                chkMapWorldManagerCanFly.Checked = WorldManager.CanFly;
                chkMapWorldManagerCanTeleport.Checked = WorldManager.CanTeleport();

                // UI
                chkConversationIsOpen.Checked = Conversation.IsOpen;
                chkGrandCompanyExchangeIsOpen.Checked = GrandCompanyExchange.Instance.IsOpen;
                chkGrandCompanySupplyListIsOpen.Checked = GrandCompanySupplyList.Instance.IsOpen;
                chkJournalAcceptIsOpen.Checked = JournalAccept.IsOpen;
                chkJournalResultIsOpen.Checked = JournalResult.IsOpen;
                chkSelectIconStringIsOpen.Checked = SelectIconString.IsOpen;
                chkSelectStringIsOpen.Checked = SelectString.IsOpen;
                chkSelectYesnoIsOpen.Checked = SelectYesno.IsOpen;
                chkShopExchangeItemIsOpen.Checked = ShopExchangeItem.Instance.IsOpen;
                chkShopProxyIsOpen.Checked = ShopProxy.Instance.IsOpen;
                chkTalkDialogOpen.Checked = Talk.DialogOpen;

                chkCraftingLogIsOpen.Checked = CraftingLog.IsOpen;
                chkCraftingManagerIsCrafting.Checked = CraftingManager.IsCrafting;
                chkSynthesisIsOpen.Checked = Synthesis.IsOpen;
            }
            catch (NullReferenceException)
            {
                // Probably just the user teleporting as the UI is refreshing, we can ignore it.
            }
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

        private string FormatPosition(Vector3 position)
        {
            return $"{position.X.ToString("0.00")}, {position.Y.ToString("0.00")}, {position.Z.ToString("0.00")}";
        }

        private void chkAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, chkAlwaysOnTop.Checked ? HWND_TOPMOST : HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
    }
}