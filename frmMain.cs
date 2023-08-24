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
            try
            {
                Pulsator.Pulse(PulseFlags.All);

                chkCommonBehaviorsIsLoading.Checked = CommonBehaviors.IsLoading;

                if (Core.Player == null)
                    return;

                // Player
                txtPlayerId.Text = Core.Player.ObjectId.ToString();
                txtPlayerName.Text = Core.Player.Name;

                chkPlayerIsMounted.Checked = Core.Player.IsMounted;
                txtPlayerMountId.Text = LocalPlayerExtensions.CurrentMount(Core.Player).ToString();

                chkPlayerIsFishing.Checked = Core.Player.IsFishing();
                chkPlayerIsOnFishingBoat.Checked = Core.Player.IsOnFishingBoat();
                txtPlayerFishingState.Text = FishingManager.State.ToString();

                chkPlayerInCombat.Checked = Core.Player.InCombat;
                chkPlayerIsAlive.Checked = Core.Player.IsAlive;
                chkPlayerIsCasting.Checked = Core.Player.IsCasting;

                chkDutyManagerDutyReady.Checked = DutyManager.DutyReady;
                chkDutyManagerInInstance.Checked = DutyManager.InInstance;
                chkFateManagerWithinFate.Checked = FateManager.WithinFate;

                chkMovementManagerIsMoving.Checked = MovementManager.IsMoving;
                chkMovementManagerIsOccupied.Checked = MovementManager.IsOccupied;

                // Target
                txtTargetId.Text = GameObjectManager.Target == null ? "NULL" : GameObjectManager.Target.ObjectId.ToString();
                txtTargetNpcId.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.NpcId.ToString();
                txtTargetName.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.Name;

                txtTargetPosition.Text = GameObjectManager.Target == null ? "" : FormatPosition(GameObjectManager.Target.Location);
                txtTargetDistance2d.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.Location.Distance2D(Core.Player.Location).ToString();
                txtTargetDistance2dSqr.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.Location.Distance2DSqr(Core.Player.Location).ToString();
                txtTargetDistance3d.Text = GameObjectManager.Target == null ? "" : GameObjectManager.Target.Location.Distance3D(Core.Player.Location).ToString();

                btnCopyTargetVector3.Enabled = GameObjectManager.Target != null && GameObjectManager.Target.NpcId != 0;
                btnCopyTargetNpcObject.Enabled = GameObjectManager.Target != null && GameObjectManager.Target.NpcId != 0;
                btnCopyTargetXYZ.Enabled = GameObjectManager.Target != null && GameObjectManager.Target.NpcId != 0;

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

        private void btnCopyTargetVector3_Click(object sender, EventArgs e)
        {
            if (GameObjectManager.Target == null || GameObjectManager.Target.NpcId == 0)
                return;

            Clipboard.SetText(createVector3ObjectFromPosition(GameObjectManager.Target.Location));
            toolTip.Show("C# code copied to clipboard!", btnCopyTargetVector3, 2000);
        }

        private string createXYZStringFromPosition(Vector3 position)
        {
            return $"XYZ=\"{position.X.ToString("0.00")}, {position.Y.ToString("0.00")}, {position.Z.ToString("0.00")}\"";
        }

        private string createVector3ObjectFromPosition(Vector3 position)
        {
            return $"new Vector3({position.X.ToString("0.00")}f, {position.Y.ToString("0.00")}f, {position.Z.ToString("0.00")}f)";
        }

        private string createNpcObjectFromTarget(GameObject target)
        {
            return $"new Npc({target.NpcId}, {WorldManager.ZoneId}, {createVector3ObjectFromPosition(target.Location)})";
        }

        private void btnCopyTargetNpcObject_Click(object sender, EventArgs e)
        {
            if (GameObjectManager.Target == null || GameObjectManager.Target.NpcId == 0)
                return;

            Clipboard.SetText($"{createNpcObjectFromTarget(GameObjectManager.Target)} // {GameObjectManager.Target.Name}, {WorldManager.CurrentZoneName}");
            toolTip.Show("C# code copied to clipboard!", btnCopyTargetNpcObject, 2000);
        }

        private void textboxes_CopyValueToClipboard(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            if (textbox.Text == string.Empty || textbox.Text == "0" || textbox.Text == "NULL")
                return;

            Clipboard.SetText(textbox.Text);
            toolTip.Show("Value copied to clipboard!", textbox, 2000);
        }

        private void btnCopyPlayerVector3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(createVector3ObjectFromPosition(Core.Player.Location));
            toolTip.Show("C# code copied to clipboard!", btnCopyTargetVector3, 2000);
        }

        private void btnCopyTargetXYZ_Click(object sender, EventArgs e)
        {
            if (GameObjectManager.Target == null || GameObjectManager.Target.NpcId == 0)
                return;

            Clipboard.SetText(createXYZStringFromPosition(GameObjectManager.Target.Location));
            toolTip.Show("XML code copied to clipboard!", btnCopyTargetXYZ, 2000);
        }

        private void btnCopyPlayerXYZ_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(createXYZStringFromPosition(Core.Player.Location));
            toolTip.Show("XML code copied to clipboard!", btnCopyPlayerXYZ, 2000);
        }
    }
}