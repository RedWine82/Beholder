namespace Beholder
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.chkPlayerIsOnFishingBoat = new System.Windows.Forms.CheckBox();
            this.chkPlayerIsFishing = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPlayerFishingState = new System.Windows.Forms.Label();
            this.txtPlayerFishingState = new System.Windows.Forms.TextBox();
            this.chkMovementManagerIsOccupied = new System.Windows.Forms.CheckBox();
            this.chkMovementManagerIsMoving = new System.Windows.Forms.CheckBox();
            this.chkPlayerIsCasting = new System.Windows.Forms.CheckBox();
            this.lblPlayerMountId = new System.Windows.Forms.Label();
            this.txtPlayerMountId = new System.Windows.Forms.TextBox();
            this.chkPlayerIsMounted = new System.Windows.Forms.CheckBox();
            this.chkDutyManagerInInstance = new System.Windows.Forms.CheckBox();
            this.chkDutyManagerDutyReady = new System.Windows.Forms.CheckBox();
            this.chkFateManagerWithinFate = new System.Windows.Forms.CheckBox();
            this.chkPlayerIsAlive = new System.Windows.Forms.CheckBox();
            this.chkPlayerInCombat = new System.Windows.Forms.CheckBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.txtMapPlayerPosition = new System.Windows.Forms.TextBox();
            this.lblMapPlayerPosition = new System.Windows.Forms.Label();
            this.chkTalkDialogOpen = new System.Windows.Forms.CheckBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.grpMap = new System.Windows.Forms.GroupBox();
            this.txtMapSubZoneId = new System.Windows.Forms.TextBox();
            this.lblMapSubZoneId = new System.Windows.Forms.Label();
            this.btnCopyPlayerXYZ = new System.Windows.Forms.Button();
            this.btnCopyPlayerVector3 = new System.Windows.Forms.Button();
            this.chkCommonBehaviorsIsLoading = new System.Windows.Forms.CheckBox();
            this.txtMapWeather = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMapWeatherId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMapWorldManagerCanTeleport = new System.Windows.Forms.CheckBox();
            this.chkMapWorldManagerCanFly = new System.Windows.Forms.CheckBox();
            this.txtMapName = new System.Windows.Forms.TextBox();
            this.lblMapName = new System.Windows.Forms.Label();
            this.txtMapId = new System.Windows.Forms.TextBox();
            this.lblMapId = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.grpGameObjects = new System.Windows.Forms.GroupBox();
            this.dgvGameObjects = new System.Windows.Forms.DataGridView();
            this.grpUi = new System.Windows.Forms.GroupBox();
            this.chkQuestLogManagerInCutscene = new System.Windows.Forms.CheckBox();
            this.chkShopProxyIsOpen = new System.Windows.Forms.CheckBox();
            this.chkJournalResultIsOpen = new System.Windows.Forms.CheckBox();
            this.chkJournalAcceptIsOpen = new System.Windows.Forms.CheckBox();
            this.chkSelectStringIsOpen = new System.Windows.Forms.CheckBox();
            this.chkSelectIconStringIsOpen = new System.Windows.Forms.CheckBox();
            this.chkSynthesisIsOpen = new System.Windows.Forms.CheckBox();
            this.chkCraftingManagerIsCrafting = new System.Windows.Forms.CheckBox();
            this.chkCraftingLogIsOpen = new System.Windows.Forms.CheckBox();
            this.chkSelectYesnoIsOpen = new System.Windows.Forms.CheckBox();
            this.chkConversationIsOpen = new System.Windows.Forms.CheckBox();
            this.chkGrandCompanySupplyListIsOpen = new System.Windows.Forms.CheckBox();
            this.chkGrandCompanyExchangeIsOpen = new System.Windows.Forms.CheckBox();
            this.chkShopExchangeItemIsOpen = new System.Windows.Forms.CheckBox();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTargetDistance3d = new System.Windows.Forms.TextBox();
            this.lblTargetDistance3d = new System.Windows.Forms.Label();
            this.txtTargetDistance2dSqr = new System.Windows.Forms.TextBox();
            this.lblTargetDistance2dSqr = new System.Windows.Forms.Label();
            this.txtTargetDistance2d = new System.Windows.Forms.TextBox();
            this.lblTargetDistance2d = new System.Windows.Forms.Label();
            this.btnCopyTargetXYZ = new System.Windows.Forms.Button();
            this.btnCopyTargetNpcObject = new System.Windows.Forms.Button();
            this.btnCopyTargetVector3 = new System.Windows.Forms.Button();
            this.txtTargetPosition = new System.Windows.Forms.TextBox();
            this.lblTargetPosition = new System.Windows.Forms.Label();
            this.txtTargetName = new System.Windows.Forms.TextBox();
            this.lblTargetName = new System.Windows.Forms.Label();
            this.txtTargetNpcId = new System.Windows.Forms.TextBox();
            this.lblTargetNpcId = new System.Windows.Forms.Label();
            this.txtTargetId = new System.Windows.Forms.TextBox();
            this.lblTargetId = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtMapSubZoneName = new System.Windows.Forms.TextBox();
            this.lblMapSubZoneName = new System.Windows.Forms.Label();
            this.grpPlayer.SuspendLayout();
            this.grpMap.SuspendLayout();
            this.grpGameObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameObjects)).BeginInit();
            this.grpUi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.chkPlayerIsOnFishingBoat);
            this.grpPlayer.Controls.Add(this.chkPlayerIsFishing);
            this.grpPlayer.Controls.Add(this.checkBox1);
            this.grpPlayer.Controls.Add(this.lblPlayerFishingState);
            this.grpPlayer.Controls.Add(this.txtPlayerFishingState);
            this.grpPlayer.Controls.Add(this.chkMovementManagerIsOccupied);
            this.grpPlayer.Controls.Add(this.chkMovementManagerIsMoving);
            this.grpPlayer.Controls.Add(this.chkPlayerIsCasting);
            this.grpPlayer.Controls.Add(this.lblPlayerMountId);
            this.grpPlayer.Controls.Add(this.txtPlayerMountId);
            this.grpPlayer.Controls.Add(this.chkPlayerIsMounted);
            this.grpPlayer.Controls.Add(this.chkDutyManagerInInstance);
            this.grpPlayer.Controls.Add(this.chkDutyManagerDutyReady);
            this.grpPlayer.Controls.Add(this.chkFateManagerWithinFate);
            this.grpPlayer.Controls.Add(this.chkPlayerIsAlive);
            this.grpPlayer.Controls.Add(this.chkPlayerInCombat);
            this.grpPlayer.Controls.Add(this.txtPlayerName);
            this.grpPlayer.Controls.Add(this.lblPlayerName);
            this.grpPlayer.Controls.Add(this.txtPlayerId);
            this.grpPlayer.Controls.Add(this.lblPlayerId);
            this.grpPlayer.ForeColor = System.Drawing.Color.White;
            this.grpPlayer.Location = new System.Drawing.Point(8, 32);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(328, 296);
            this.grpPlayer.TabIndex = 0;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Player";
            // 
            // chkPlayerIsOnFishingBoat
            // 
            this.chkPlayerIsOnFishingBoat.AutoSize = true;
            this.chkPlayerIsOnFishingBoat.Location = new System.Drawing.Point(8, 112);
            this.chkPlayerIsOnFishingBoat.Name = "chkPlayerIsOnFishingBoat";
            this.chkPlayerIsOnFishingBoat.Size = new System.Drawing.Size(156, 19);
            this.chkPlayerIsOnFishingBoat.TabIndex = 37;
            this.chkPlayerIsOnFishingBoat.Text = "Player.IsOnFishingBoat";
            this.chkPlayerIsOnFishingBoat.UseVisualStyleBackColor = true;
            // 
            // chkPlayerIsFishing
            // 
            this.chkPlayerIsFishing.AutoSize = true;
            this.chkPlayerIsFishing.Location = new System.Drawing.Point(8, 96);
            this.chkPlayerIsFishing.Name = "chkPlayerIsFishing";
            this.chkPlayerIsFishing.Size = new System.Drawing.Size(113, 19);
            this.chkPlayerIsFishing.TabIndex = 30;
            this.chkPlayerIsFishing.Text = "Player.IsFishing";
            this.chkPlayerIsFishing.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 19);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Player.IsCasting";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblPlayerFishingState
            // 
            this.lblPlayerFishingState.Location = new System.Drawing.Point(144, 97);
            this.lblPlayerFishingState.Name = "lblPlayerFishingState";
            this.lblPlayerFishingState.Size = new System.Drawing.Size(88, 16);
            this.lblPlayerFishingState.TabIndex = 28;
            this.lblPlayerFishingState.Text = "Fishing State";
            // 
            // txtPlayerFishingState
            // 
            this.txtPlayerFishingState.Location = new System.Drawing.Point(232, 94);
            this.txtPlayerFishingState.Name = "txtPlayerFishingState";
            this.txtPlayerFishingState.Size = new System.Drawing.Size(88, 22);
            this.txtPlayerFishingState.TabIndex = 27;
            // 
            // chkMovementManagerIsOccupied
            // 
            this.chkMovementManagerIsOccupied.AutoSize = true;
            this.chkMovementManagerIsOccupied.Location = new System.Drawing.Point(8, 216);
            this.chkMovementManagerIsOccupied.Name = "chkMovementManagerIsOccupied";
            this.chkMovementManagerIsOccupied.Size = new System.Drawing.Size(208, 19);
            this.chkMovementManagerIsOccupied.TabIndex = 26;
            this.chkMovementManagerIsOccupied.Text = "MovementManager.IsOccupied";
            this.chkMovementManagerIsOccupied.UseVisualStyleBackColor = true;
            // 
            // chkMovementManagerIsMoving
            // 
            this.chkMovementManagerIsMoving.AutoSize = true;
            this.chkMovementManagerIsMoving.Location = new System.Drawing.Point(8, 200);
            this.chkMovementManagerIsMoving.Name = "chkMovementManagerIsMoving";
            this.chkMovementManagerIsMoving.Size = new System.Drawing.Size(196, 19);
            this.chkMovementManagerIsMoving.TabIndex = 25;
            this.chkMovementManagerIsMoving.Text = "MovementManager.IsMoving";
            this.chkMovementManagerIsMoving.UseVisualStyleBackColor = true;
            // 
            // chkPlayerIsCasting
            // 
            this.chkPlayerIsCasting.AutoSize = true;
            this.chkPlayerIsCasting.Location = new System.Drawing.Point(8, 167);
            this.chkPlayerIsCasting.Name = "chkPlayerIsCasting";
            this.chkPlayerIsCasting.Size = new System.Drawing.Size(116, 19);
            this.chkPlayerIsCasting.TabIndex = 24;
            this.chkPlayerIsCasting.Text = "Player.IsCasting";
            this.chkPlayerIsCasting.UseVisualStyleBackColor = true;
            // 
            // lblPlayerMountId
            // 
            this.lblPlayerMountId.Location = new System.Drawing.Point(144, 75);
            this.lblPlayerMountId.Name = "lblPlayerMountId";
            this.lblPlayerMountId.Size = new System.Drawing.Size(72, 16);
            this.lblPlayerMountId.TabIndex = 21;
            this.lblPlayerMountId.Text = "Mount ID";
            // 
            // txtPlayerMountId
            // 
            this.txtPlayerMountId.Location = new System.Drawing.Point(232, 72);
            this.txtPlayerMountId.Name = "txtPlayerMountId";
            this.txtPlayerMountId.Size = new System.Drawing.Size(88, 22);
            this.txtPlayerMountId.TabIndex = 20;
            this.txtPlayerMountId.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // chkPlayerIsMounted
            // 
            this.chkPlayerIsMounted.AutoSize = true;
            this.chkPlayerIsMounted.Location = new System.Drawing.Point(8, 74);
            this.chkPlayerIsMounted.Name = "chkPlayerIsMounted";
            this.chkPlayerIsMounted.Size = new System.Drawing.Size(125, 19);
            this.chkPlayerIsMounted.TabIndex = 19;
            this.chkPlayerIsMounted.Text = "Player.IsMounted";
            this.chkPlayerIsMounted.UseVisualStyleBackColor = true;
            // 
            // chkDutyManagerInInstance
            // 
            this.chkDutyManagerInInstance.AutoSize = true;
            this.chkDutyManagerInInstance.Location = new System.Drawing.Point(144, 151);
            this.chkDutyManagerInInstance.Name = "chkDutyManagerInInstance";
            this.chkDutyManagerInInstance.Size = new System.Drawing.Size(167, 19);
            this.chkDutyManagerInInstance.TabIndex = 18;
            this.chkDutyManagerInInstance.Text = "DutyManager.InInstance";
            this.chkDutyManagerInInstance.UseVisualStyleBackColor = true;
            // 
            // chkDutyManagerDutyReady
            // 
            this.chkDutyManagerDutyReady.AutoSize = true;
            this.chkDutyManagerDutyReady.Location = new System.Drawing.Point(144, 167);
            this.chkDutyManagerDutyReady.Name = "chkDutyManagerDutyReady";
            this.chkDutyManagerDutyReady.Size = new System.Drawing.Size(173, 19);
            this.chkDutyManagerDutyReady.TabIndex = 17;
            this.chkDutyManagerDutyReady.Text = "DutyManager.DutyReady";
            this.chkDutyManagerDutyReady.UseVisualStyleBackColor = true;
            // 
            // chkFateManagerWithinFate
            // 
            this.chkFateManagerWithinFate.AutoSize = true;
            this.chkFateManagerWithinFate.Location = new System.Drawing.Point(144, 135);
            this.chkFateManagerWithinFate.Name = "chkFateManagerWithinFate";
            this.chkFateManagerWithinFate.Size = new System.Drawing.Size(168, 19);
            this.chkFateManagerWithinFate.TabIndex = 13;
            this.chkFateManagerWithinFate.Text = "FateManager.WithinFate";
            this.chkFateManagerWithinFate.UseVisualStyleBackColor = true;
            // 
            // chkPlayerIsAlive
            // 
            this.chkPlayerIsAlive.AutoSize = true;
            this.chkPlayerIsAlive.Location = new System.Drawing.Point(8, 151);
            this.chkPlayerIsAlive.Name = "chkPlayerIsAlive";
            this.chkPlayerIsAlive.Size = new System.Drawing.Size(101, 19);
            this.chkPlayerIsAlive.TabIndex = 11;
            this.chkPlayerIsAlive.Text = "Player.IsAlive";
            this.chkPlayerIsAlive.UseVisualStyleBackColor = true;
            // 
            // chkPlayerInCombat
            // 
            this.chkPlayerInCombat.AutoSize = true;
            this.chkPlayerInCombat.Location = new System.Drawing.Point(8, 135);
            this.chkPlayerInCombat.Name = "chkPlayerInCombat";
            this.chkPlayerInCombat.Size = new System.Drawing.Size(120, 19);
            this.chkPlayerInCombat.TabIndex = 10;
            this.chkPlayerInCombat.Text = "Player.InCombat";
            this.chkPlayerInCombat.UseVisualStyleBackColor = true;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(104, 40);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(216, 22);
            this.txtPlayerName.TabIndex = 3;
            this.txtPlayerName.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Location = new System.Drawing.Point(8, 43);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(96, 16);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Name";
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(104, 16);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.Size = new System.Drawing.Size(216, 22);
            this.txtPlayerId.TabIndex = 1;
            this.txtPlayerId.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.Location = new System.Drawing.Point(8, 19);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(96, 16);
            this.lblPlayerId.TabIndex = 0;
            this.lblPlayerId.Text = "ID";
            // 
            // txtMapPlayerPosition
            // 
            this.txtMapPlayerPosition.Location = new System.Drawing.Point(104, 160);
            this.txtMapPlayerPosition.Name = "txtMapPlayerPosition";
            this.txtMapPlayerPosition.Size = new System.Drawing.Size(216, 22);
            this.txtMapPlayerPosition.TabIndex = 9;
            this.txtMapPlayerPosition.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblMapPlayerPosition
            // 
            this.lblMapPlayerPosition.Location = new System.Drawing.Point(8, 163);
            this.lblMapPlayerPosition.Name = "lblMapPlayerPosition";
            this.lblMapPlayerPosition.Size = new System.Drawing.Size(96, 16);
            this.lblMapPlayerPosition.TabIndex = 6;
            this.lblMapPlayerPosition.Text = "Position";
            // 
            // chkTalkDialogOpen
            // 
            this.chkTalkDialogOpen.AutoSize = true;
            this.chkTalkDialogOpen.Location = new System.Drawing.Point(8, 176);
            this.chkTalkDialogOpen.Name = "chkTalkDialogOpen";
            this.chkTalkDialogOpen.Size = new System.Drawing.Size(122, 19);
            this.chkTalkDialogOpen.TabIndex = 12;
            this.chkTalkDialogOpen.Text = "Talk.DialogOpen";
            this.chkTalkDialogOpen.UseVisualStyleBackColor = true;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 500;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // grpMap
            // 
            this.grpMap.Controls.Add(this.txtMapSubZoneName);
            this.grpMap.Controls.Add(this.lblMapSubZoneName);
            this.grpMap.Controls.Add(this.txtMapSubZoneId);
            this.grpMap.Controls.Add(this.lblMapSubZoneId);
            this.grpMap.Controls.Add(this.btnCopyPlayerXYZ);
            this.grpMap.Controls.Add(this.btnCopyPlayerVector3);
            this.grpMap.Controls.Add(this.chkCommonBehaviorsIsLoading);
            this.grpMap.Controls.Add(this.txtMapWeather);
            this.grpMap.Controls.Add(this.label1);
            this.grpMap.Controls.Add(this.txtMapWeatherId);
            this.grpMap.Controls.Add(this.label2);
            this.grpMap.Controls.Add(this.chkMapWorldManagerCanTeleport);
            this.grpMap.Controls.Add(this.chkMapWorldManagerCanFly);
            this.grpMap.Controls.Add(this.txtMapName);
            this.grpMap.Controls.Add(this.lblMapName);
            this.grpMap.Controls.Add(this.txtMapId);
            this.grpMap.Controls.Add(this.lblMapId);
            this.grpMap.Controls.Add(this.txtMapPlayerPosition);
            this.grpMap.Controls.Add(this.lblMapPlayerPosition);
            this.grpMap.ForeColor = System.Drawing.Color.White;
            this.grpMap.Location = new System.Drawing.Point(680, 32);
            this.grpMap.Name = "grpMap";
            this.grpMap.Size = new System.Drawing.Size(328, 296);
            this.grpMap.TabIndex = 22;
            this.grpMap.TabStop = false;
            this.grpMap.Text = "Map";
            // 
            // txtMapSubZoneId
            // 
            this.txtMapSubZoneId.Location = new System.Drawing.Point(104, 64);
            this.txtMapSubZoneId.Name = "txtMapSubZoneId";
            this.txtMapSubZoneId.Size = new System.Drawing.Size(216, 22);
            this.txtMapSubZoneId.TabIndex = 38;
            // 
            // lblMapSubZoneId
            // 
            this.lblMapSubZoneId.Location = new System.Drawing.Point(8, 67);
            this.lblMapSubZoneId.Name = "lblMapSubZoneId";
            this.lblMapSubZoneId.Size = new System.Drawing.Size(96, 16);
            this.lblMapSubZoneId.TabIndex = 37;
            this.lblMapSubZoneId.Text = "SubZone ID";
            // 
            // btnCopyPlayerXYZ
            // 
            this.btnCopyPlayerXYZ.ForeColor = System.Drawing.Color.Black;
            this.btnCopyPlayerXYZ.Image = global::Beholder.Properties.Resources.clipboard;
            this.btnCopyPlayerXYZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyPlayerXYZ.Location = new System.Drawing.Point(8, 184);
            this.btnCopyPlayerXYZ.Name = "btnCopyPlayerXYZ";
            this.btnCopyPlayerXYZ.Size = new System.Drawing.Size(312, 23);
            this.btnCopyPlayerXYZ.TabIndex = 36;
            this.btnCopyPlayerXYZ.Text = "Copy Position XYZ (XML)";
            this.btnCopyPlayerXYZ.UseVisualStyleBackColor = true;
            this.btnCopyPlayerXYZ.Click += new System.EventHandler(this.btnCopyPlayerXYZ_Click);
            // 
            // btnCopyPlayerVector3
            // 
            this.btnCopyPlayerVector3.ForeColor = System.Drawing.Color.Black;
            this.btnCopyPlayerVector3.Image = global::Beholder.Properties.Resources.clipboard;
            this.btnCopyPlayerVector3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyPlayerVector3.Location = new System.Drawing.Point(8, 208);
            this.btnCopyPlayerVector3.Name = "btnCopyPlayerVector3";
            this.btnCopyPlayerVector3.Size = new System.Drawing.Size(312, 23);
            this.btnCopyPlayerVector3.TabIndex = 35;
            this.btnCopyPlayerVector3.Text = "Copy Position Vector3 (C#)";
            this.btnCopyPlayerVector3.UseVisualStyleBackColor = true;
            this.btnCopyPlayerVector3.Click += new System.EventHandler(this.btnCopyPlayerVector3_Click);
            // 
            // chkCommonBehaviorsIsLoading
            // 
            this.chkCommonBehaviorsIsLoading.AutoSize = true;
            this.chkCommonBehaviorsIsLoading.Location = new System.Drawing.Point(8, 272);
            this.chkCommonBehaviorsIsLoading.Name = "chkCommonBehaviorsIsLoading";
            this.chkCommonBehaviorsIsLoading.Size = new System.Drawing.Size(194, 19);
            this.chkCommonBehaviorsIsLoading.TabIndex = 28;
            this.chkCommonBehaviorsIsLoading.Text = "CommonBehaviors.IsLoading";
            this.chkCommonBehaviorsIsLoading.UseVisualStyleBackColor = true;
            // 
            // txtMapWeather
            // 
            this.txtMapWeather.Location = new System.Drawing.Point(104, 136);
            this.txtMapWeather.Name = "txtMapWeather";
            this.txtMapWeather.Size = new System.Drawing.Size(216, 22);
            this.txtMapWeather.TabIndex = 27;
            this.txtMapWeather.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Weather";
            // 
            // txtMapWeatherId
            // 
            this.txtMapWeatherId.Location = new System.Drawing.Point(104, 112);
            this.txtMapWeatherId.Name = "txtMapWeatherId";
            this.txtMapWeatherId.Size = new System.Drawing.Size(216, 22);
            this.txtMapWeatherId.TabIndex = 25;
            this.txtMapWeatherId.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Weather ID";
            // 
            // chkMapWorldManagerCanTeleport
            // 
            this.chkMapWorldManagerCanTeleport.AutoSize = true;
            this.chkMapWorldManagerCanTeleport.Location = new System.Drawing.Point(8, 240);
            this.chkMapWorldManagerCanTeleport.Name = "chkMapWorldManagerCanTeleport";
            this.chkMapWorldManagerCanTeleport.Size = new System.Drawing.Size(185, 19);
            this.chkMapWorldManagerCanTeleport.TabIndex = 23;
            this.chkMapWorldManagerCanTeleport.Text = "WorldManager.CanTeleport";
            this.chkMapWorldManagerCanTeleport.UseVisualStyleBackColor = true;
            // 
            // chkMapWorldManagerCanFly
            // 
            this.chkMapWorldManagerCanFly.AutoSize = true;
            this.chkMapWorldManagerCanFly.Location = new System.Drawing.Point(8, 256);
            this.chkMapWorldManagerCanFly.Name = "chkMapWorldManagerCanFly";
            this.chkMapWorldManagerCanFly.Size = new System.Drawing.Size(153, 19);
            this.chkMapWorldManagerCanFly.TabIndex = 22;
            this.chkMapWorldManagerCanFly.Text = "WorldManager.CanFly";
            this.chkMapWorldManagerCanFly.UseVisualStyleBackColor = true;
            // 
            // txtMapName
            // 
            this.txtMapName.Location = new System.Drawing.Point(104, 40);
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(216, 22);
            this.txtMapName.TabIndex = 3;
            this.txtMapName.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblMapName
            // 
            this.lblMapName.Location = new System.Drawing.Point(8, 43);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(96, 16);
            this.lblMapName.TabIndex = 2;
            this.lblMapName.Text = "Name";
            // 
            // txtMapId
            // 
            this.txtMapId.Location = new System.Drawing.Point(104, 16);
            this.txtMapId.Name = "txtMapId";
            this.txtMapId.Size = new System.Drawing.Size(216, 22);
            this.txtMapId.TabIndex = 1;
            this.txtMapId.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblMapId
            // 
            this.lblMapId.Location = new System.Drawing.Point(8, 19);
            this.lblMapId.Name = "lblMapId";
            this.lblMapId.Size = new System.Drawing.Size(96, 16);
            this.lblMapId.TabIndex = 0;
            this.lblMapId.Text = "ID";
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisclaimer.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.Salmon;
            this.lblDisclaimer.Location = new System.Drawing.Point(224, 8);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(880, 16);
            this.lblDisclaimer.TabIndex = 23;
            this.lblDisclaimer.Text = "This plugin is for developers only and is provided AS-IS with no support.";
            this.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpGameObjects
            // 
            this.grpGameObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGameObjects.Controls.Add(this.dgvGameObjects);
            this.grpGameObjects.ForeColor = System.Drawing.Color.White;
            this.grpGameObjects.Location = new System.Drawing.Point(8, 336);
            this.grpGameObjects.Name = "grpGameObjects";
            this.grpGameObjects.Size = new System.Drawing.Size(1256, 485);
            this.grpGameObjects.TabIndex = 24;
            this.grpGameObjects.TabStop = false;
            this.grpGameObjects.Text = "Game Objects (Does not update automatically, close window and reopen to update)";
            // 
            // dgvGameObjects
            // 
            this.dgvGameObjects.AllowUserToAddRows = false;
            this.dgvGameObjects.AllowUserToDeleteRows = false;
            this.dgvGameObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGameObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGameObjects.Location = new System.Drawing.Point(8, 24);
            this.dgvGameObjects.Name = "dgvGameObjects";
            this.dgvGameObjects.ReadOnly = true;
            this.dgvGameObjects.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvGameObjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGameObjects.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dgvGameObjects.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGameObjects.Size = new System.Drawing.Size(1240, 453);
            this.dgvGameObjects.TabIndex = 25;
            this.dgvGameObjects.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvGameObjects_DataError);
            // 
            // grpUi
            // 
            this.grpUi.Controls.Add(this.chkQuestLogManagerInCutscene);
            this.grpUi.Controls.Add(this.chkShopProxyIsOpen);
            this.grpUi.Controls.Add(this.chkJournalResultIsOpen);
            this.grpUi.Controls.Add(this.chkJournalAcceptIsOpen);
            this.grpUi.Controls.Add(this.chkSelectStringIsOpen);
            this.grpUi.Controls.Add(this.chkSelectIconStringIsOpen);
            this.grpUi.Controls.Add(this.chkSynthesisIsOpen);
            this.grpUi.Controls.Add(this.chkCraftingManagerIsCrafting);
            this.grpUi.Controls.Add(this.chkCraftingLogIsOpen);
            this.grpUi.Controls.Add(this.chkSelectYesnoIsOpen);
            this.grpUi.Controls.Add(this.chkConversationIsOpen);
            this.grpUi.Controls.Add(this.chkGrandCompanySupplyListIsOpen);
            this.grpUi.Controls.Add(this.chkGrandCompanyExchangeIsOpen);
            this.grpUi.Controls.Add(this.chkShopExchangeItemIsOpen);
            this.grpUi.Controls.Add(this.chkTalkDialogOpen);
            this.grpUi.ForeColor = System.Drawing.Color.White;
            this.grpUi.Location = new System.Drawing.Point(1016, 32);
            this.grpUi.Name = "grpUi";
            this.grpUi.Size = new System.Drawing.Size(248, 296);
            this.grpUi.TabIndex = 28;
            this.grpUi.TabStop = false;
            this.grpUi.Text = "UI";
            // 
            // chkQuestLogManagerInCutscene
            // 
            this.chkQuestLogManagerInCutscene.AutoSize = true;
            this.chkQuestLogManagerInCutscene.Location = new System.Drawing.Point(8, 192);
            this.chkQuestLogManagerInCutscene.Name = "chkQuestLogManagerInCutscene";
            this.chkQuestLogManagerInCutscene.Size = new System.Drawing.Size(200, 19);
            this.chkQuestLogManagerInCutscene.TabIndex = 26;
            this.chkQuestLogManagerInCutscene.Text = "QuestLogManager.InCutscene";
            this.chkQuestLogManagerInCutscene.UseVisualStyleBackColor = true;
            // 
            // chkShopProxyIsOpen
            // 
            this.chkShopProxyIsOpen.AutoSize = true;
            this.chkShopProxyIsOpen.Location = new System.Drawing.Point(8, 160);
            this.chkShopProxyIsOpen.Name = "chkShopProxyIsOpen";
            this.chkShopProxyIsOpen.Size = new System.Drawing.Size(131, 19);
            this.chkShopProxyIsOpen.TabIndex = 25;
            this.chkShopProxyIsOpen.Text = "ShopProxy.IsOpen";
            this.chkShopProxyIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkJournalResultIsOpen
            // 
            this.chkJournalResultIsOpen.AutoSize = true;
            this.chkJournalResultIsOpen.Location = new System.Drawing.Point(8, 80);
            this.chkJournalResultIsOpen.Name = "chkJournalResultIsOpen";
            this.chkJournalResultIsOpen.Size = new System.Drawing.Size(144, 19);
            this.chkJournalResultIsOpen.TabIndex = 24;
            this.chkJournalResultIsOpen.Text = "JournalResult.IsOpen";
            this.chkJournalResultIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkJournalAcceptIsOpen
            // 
            this.chkJournalAcceptIsOpen.AutoSize = true;
            this.chkJournalAcceptIsOpen.Location = new System.Drawing.Point(8, 64);
            this.chkJournalAcceptIsOpen.Name = "chkJournalAcceptIsOpen";
            this.chkJournalAcceptIsOpen.Size = new System.Drawing.Size(151, 19);
            this.chkJournalAcceptIsOpen.TabIndex = 23;
            this.chkJournalAcceptIsOpen.Text = "JournalAccept.IsOpen";
            this.chkJournalAcceptIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkSelectStringIsOpen
            // 
            this.chkSelectStringIsOpen.AutoSize = true;
            this.chkSelectStringIsOpen.Location = new System.Drawing.Point(8, 112);
            this.chkSelectStringIsOpen.Name = "chkSelectStringIsOpen";
            this.chkSelectStringIsOpen.Size = new System.Drawing.Size(139, 19);
            this.chkSelectStringIsOpen.TabIndex = 22;
            this.chkSelectStringIsOpen.Text = "SelectString.IsOpen";
            this.chkSelectStringIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkSelectIconStringIsOpen
            // 
            this.chkSelectIconStringIsOpen.AutoSize = true;
            this.chkSelectIconStringIsOpen.Location = new System.Drawing.Point(8, 96);
            this.chkSelectIconStringIsOpen.Name = "chkSelectIconStringIsOpen";
            this.chkSelectIconStringIsOpen.Size = new System.Drawing.Size(164, 19);
            this.chkSelectIconStringIsOpen.TabIndex = 21;
            this.chkSelectIconStringIsOpen.Text = "SelectIconString.IsOpen";
            this.chkSelectIconStringIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkSynthesisIsOpen
            // 
            this.chkSynthesisIsOpen.AutoSize = true;
            this.chkSynthesisIsOpen.Location = new System.Drawing.Point(8, 240);
            this.chkSynthesisIsOpen.Name = "chkSynthesisIsOpen";
            this.chkSynthesisIsOpen.Size = new System.Drawing.Size(124, 19);
            this.chkSynthesisIsOpen.TabIndex = 20;
            this.chkSynthesisIsOpen.Text = "Synthesis.IsOpen";
            this.chkSynthesisIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkCraftingManagerIsCrafting
            // 
            this.chkCraftingManagerIsCrafting.AutoSize = true;
            this.chkCraftingManagerIsCrafting.Location = new System.Drawing.Point(8, 224);
            this.chkCraftingManagerIsCrafting.Name = "chkCraftingManagerIsCrafting";
            this.chkCraftingManagerIsCrafting.Size = new System.Drawing.Size(181, 19);
            this.chkCraftingManagerIsCrafting.TabIndex = 19;
            this.chkCraftingManagerIsCrafting.Text = "CraftingManager.IsCrafting";
            this.chkCraftingManagerIsCrafting.UseVisualStyleBackColor = true;
            // 
            // chkCraftingLogIsOpen
            // 
            this.chkCraftingLogIsOpen.AutoSize = true;
            this.chkCraftingLogIsOpen.Location = new System.Drawing.Point(8, 208);
            this.chkCraftingLogIsOpen.Name = "chkCraftingLogIsOpen";
            this.chkCraftingLogIsOpen.Size = new System.Drawing.Size(137, 19);
            this.chkCraftingLogIsOpen.TabIndex = 18;
            this.chkCraftingLogIsOpen.Text = "CraftingLog.IsOpen";
            this.chkCraftingLogIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkSelectYesnoIsOpen
            // 
            this.chkSelectYesnoIsOpen.AutoSize = true;
            this.chkSelectYesnoIsOpen.Location = new System.Drawing.Point(8, 128);
            this.chkSelectYesnoIsOpen.Name = "chkSelectYesnoIsOpen";
            this.chkSelectYesnoIsOpen.Size = new System.Drawing.Size(140, 19);
            this.chkSelectYesnoIsOpen.TabIndex = 17;
            this.chkSelectYesnoIsOpen.Text = "SelectYesno.IsOpen";
            this.chkSelectYesnoIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkConversationIsOpen
            // 
            this.chkConversationIsOpen.AutoSize = true;
            this.chkConversationIsOpen.Location = new System.Drawing.Point(8, 16);
            this.chkConversationIsOpen.Name = "chkConversationIsOpen";
            this.chkConversationIsOpen.Size = new System.Drawing.Size(146, 19);
            this.chkConversationIsOpen.TabIndex = 16;
            this.chkConversationIsOpen.Text = "Conversation.IsOpen";
            this.chkConversationIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkGrandCompanySupplyListIsOpen
            // 
            this.chkGrandCompanySupplyListIsOpen.AutoSize = true;
            this.chkGrandCompanySupplyListIsOpen.Location = new System.Drawing.Point(8, 48);
            this.chkGrandCompanySupplyListIsOpen.Name = "chkGrandCompanySupplyListIsOpen";
            this.chkGrandCompanySupplyListIsOpen.Size = new System.Drawing.Size(220, 19);
            this.chkGrandCompanySupplyListIsOpen.TabIndex = 15;
            this.chkGrandCompanySupplyListIsOpen.Text = "GrandCompanySupplyList.IsOpen";
            this.chkGrandCompanySupplyListIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkGrandCompanyExchangeIsOpen
            // 
            this.chkGrandCompanyExchangeIsOpen.AutoSize = true;
            this.chkGrandCompanyExchangeIsOpen.Location = new System.Drawing.Point(8, 32);
            this.chkGrandCompanyExchangeIsOpen.Name = "chkGrandCompanyExchangeIsOpen";
            this.chkGrandCompanyExchangeIsOpen.Size = new System.Drawing.Size(216, 19);
            this.chkGrandCompanyExchangeIsOpen.TabIndex = 14;
            this.chkGrandCompanyExchangeIsOpen.Text = "GrandCompanyExchange.IsOpen";
            this.chkGrandCompanyExchangeIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkShopExchangeItemIsOpen
            // 
            this.chkShopExchangeItemIsOpen.AutoSize = true;
            this.chkShopExchangeItemIsOpen.Location = new System.Drawing.Point(8, 144);
            this.chkShopExchangeItemIsOpen.Name = "chkShopExchangeItemIsOpen";
            this.chkShopExchangeItemIsOpen.Size = new System.Drawing.Size(181, 19);
            this.chkShopExchangeItemIsOpen.TabIndex = 13;
            this.chkShopExchangeItemIsOpen.Text = "ShopExchangeItem.IsOpen";
            this.chkShopExchangeItemIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.ForeColor = System.Drawing.Color.White;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(1144, 8);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(113, 19);
            this.chkAlwaysOnTop.TabIndex = 29;
            this.chkAlwaysOnTop.Text = "Always on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chkAlwaysOnTop_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTargetDistance3d);
            this.groupBox1.Controls.Add(this.lblTargetDistance3d);
            this.groupBox1.Controls.Add(this.txtTargetDistance2dSqr);
            this.groupBox1.Controls.Add(this.lblTargetDistance2dSqr);
            this.groupBox1.Controls.Add(this.txtTargetDistance2d);
            this.groupBox1.Controls.Add(this.lblTargetDistance2d);
            this.groupBox1.Controls.Add(this.btnCopyTargetXYZ);
            this.groupBox1.Controls.Add(this.btnCopyTargetNpcObject);
            this.groupBox1.Controls.Add(this.btnCopyTargetVector3);
            this.groupBox1.Controls.Add(this.txtTargetPosition);
            this.groupBox1.Controls.Add(this.lblTargetPosition);
            this.groupBox1.Controls.Add(this.txtTargetName);
            this.groupBox1.Controls.Add(this.lblTargetName);
            this.groupBox1.Controls.Add(this.txtTargetNpcId);
            this.groupBox1.Controls.Add(this.lblTargetNpcId);
            this.groupBox1.Controls.Add(this.txtTargetId);
            this.groupBox1.Controls.Add(this.lblTargetId);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(344, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 296);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // txtTargetDistance3d
            // 
            this.txtTargetDistance3d.Location = new System.Drawing.Point(104, 232);
            this.txtTargetDistance3d.Name = "txtTargetDistance3d";
            this.txtTargetDistance3d.Size = new System.Drawing.Size(216, 22);
            this.txtTargetDistance3d.TabIndex = 41;
            // 
            // lblTargetDistance3d
            // 
            this.lblTargetDistance3d.Location = new System.Drawing.Point(8, 235);
            this.lblTargetDistance3d.Name = "lblTargetDistance3d";
            this.lblTargetDistance3d.Size = new System.Drawing.Size(96, 16);
            this.lblTargetDistance3d.TabIndex = 40;
            this.lblTargetDistance3d.Text = "Distance 3D";
            // 
            // txtTargetDistance2dSqr
            // 
            this.txtTargetDistance2dSqr.Location = new System.Drawing.Point(104, 208);
            this.txtTargetDistance2dSqr.Name = "txtTargetDistance2dSqr";
            this.txtTargetDistance2dSqr.Size = new System.Drawing.Size(216, 22);
            this.txtTargetDistance2dSqr.TabIndex = 39;
            // 
            // lblTargetDistance2dSqr
            // 
            this.lblTargetDistance2dSqr.Location = new System.Drawing.Point(8, 211);
            this.lblTargetDistance2dSqr.Name = "lblTargetDistance2dSqr";
            this.lblTargetDistance2dSqr.Size = new System.Drawing.Size(96, 16);
            this.lblTargetDistance2dSqr.TabIndex = 38;
            this.lblTargetDistance2dSqr.Text = "Dist. 2D Sqr";
            // 
            // txtTargetDistance2d
            // 
            this.txtTargetDistance2d.Location = new System.Drawing.Point(104, 184);
            this.txtTargetDistance2d.Name = "txtTargetDistance2d";
            this.txtTargetDistance2d.Size = new System.Drawing.Size(216, 22);
            this.txtTargetDistance2d.TabIndex = 37;
            // 
            // lblTargetDistance2d
            // 
            this.lblTargetDistance2d.Location = new System.Drawing.Point(8, 187);
            this.lblTargetDistance2d.Name = "lblTargetDistance2d";
            this.lblTargetDistance2d.Size = new System.Drawing.Size(96, 16);
            this.lblTargetDistance2d.TabIndex = 36;
            this.lblTargetDistance2d.Text = "Distance 2D";
            // 
            // btnCopyTargetXYZ
            // 
            this.btnCopyTargetXYZ.ForeColor = System.Drawing.Color.Black;
            this.btnCopyTargetXYZ.Image = global::Beholder.Properties.Resources.clipboard;
            this.btnCopyTargetXYZ.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyTargetXYZ.Location = new System.Drawing.Point(8, 112);
            this.btnCopyTargetXYZ.Name = "btnCopyTargetXYZ";
            this.btnCopyTargetXYZ.Size = new System.Drawing.Size(312, 23);
            this.btnCopyTargetXYZ.TabIndex = 35;
            this.btnCopyTargetXYZ.Text = "Copy Position XYZ (XML)";
            this.btnCopyTargetXYZ.UseVisualStyleBackColor = true;
            this.btnCopyTargetXYZ.Click += new System.EventHandler(this.btnCopyTargetXYZ_Click);
            // 
            // btnCopyTargetNpcObject
            // 
            this.btnCopyTargetNpcObject.ForeColor = System.Drawing.Color.Black;
            this.btnCopyTargetNpcObject.Image = global::Beholder.Properties.Resources.clipboard;
            this.btnCopyTargetNpcObject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyTargetNpcObject.Location = new System.Drawing.Point(8, 160);
            this.btnCopyTargetNpcObject.Name = "btnCopyTargetNpcObject";
            this.btnCopyTargetNpcObject.Size = new System.Drawing.Size(312, 23);
            this.btnCopyTargetNpcObject.TabIndex = 34;
            this.btnCopyTargetNpcObject.Text = "Copy Target NPC Object (C#)";
            this.btnCopyTargetNpcObject.UseVisualStyleBackColor = true;
            this.btnCopyTargetNpcObject.Click += new System.EventHandler(this.btnCopyTargetNpcObject_Click);
            // 
            // btnCopyTargetVector3
            // 
            this.btnCopyTargetVector3.ForeColor = System.Drawing.Color.Black;
            this.btnCopyTargetVector3.Image = global::Beholder.Properties.Resources.clipboard;
            this.btnCopyTargetVector3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopyTargetVector3.Location = new System.Drawing.Point(8, 136);
            this.btnCopyTargetVector3.Name = "btnCopyTargetVector3";
            this.btnCopyTargetVector3.Size = new System.Drawing.Size(312, 23);
            this.btnCopyTargetVector3.TabIndex = 33;
            this.btnCopyTargetVector3.Text = "Copy Position Vector3 (C#)";
            this.btnCopyTargetVector3.UseVisualStyleBackColor = true;
            this.btnCopyTargetVector3.Click += new System.EventHandler(this.btnCopyTargetVector3_Click);
            // 
            // txtTargetPosition
            // 
            this.txtTargetPosition.Location = new System.Drawing.Point(104, 88);
            this.txtTargetPosition.Name = "txtTargetPosition";
            this.txtTargetPosition.Size = new System.Drawing.Size(216, 22);
            this.txtTargetPosition.TabIndex = 32;
            this.txtTargetPosition.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblTargetPosition
            // 
            this.lblTargetPosition.Location = new System.Drawing.Point(8, 91);
            this.lblTargetPosition.Name = "lblTargetPosition";
            this.lblTargetPosition.Size = new System.Drawing.Size(96, 16);
            this.lblTargetPosition.TabIndex = 29;
            this.lblTargetPosition.Text = "Position";
            // 
            // txtTargetName
            // 
            this.txtTargetName.Location = new System.Drawing.Point(104, 64);
            this.txtTargetName.Name = "txtTargetName";
            this.txtTargetName.Size = new System.Drawing.Size(216, 22);
            this.txtTargetName.TabIndex = 28;
            this.txtTargetName.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblTargetName
            // 
            this.lblTargetName.Location = new System.Drawing.Point(8, 67);
            this.lblTargetName.Name = "lblTargetName";
            this.lblTargetName.Size = new System.Drawing.Size(96, 16);
            this.lblTargetName.TabIndex = 27;
            this.lblTargetName.Text = "Name";
            // 
            // txtTargetNpcId
            // 
            this.txtTargetNpcId.Location = new System.Drawing.Point(104, 40);
            this.txtTargetNpcId.Name = "txtTargetNpcId";
            this.txtTargetNpcId.Size = new System.Drawing.Size(216, 22);
            this.txtTargetNpcId.TabIndex = 23;
            this.txtTargetNpcId.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblTargetNpcId
            // 
            this.lblTargetNpcId.Location = new System.Drawing.Point(8, 43);
            this.lblTargetNpcId.Name = "lblTargetNpcId";
            this.lblTargetNpcId.Size = new System.Drawing.Size(96, 16);
            this.lblTargetNpcId.TabIndex = 22;
            this.lblTargetNpcId.Text = "NPC ID";
            // 
            // txtTargetId
            // 
            this.txtTargetId.Location = new System.Drawing.Point(104, 16);
            this.txtTargetId.Name = "txtTargetId";
            this.txtTargetId.Size = new System.Drawing.Size(216, 22);
            this.txtTargetId.TabIndex = 5;
            this.txtTargetId.Click += new System.EventHandler(this.textboxes_CopyValueToClipboard);
            // 
            // lblTargetId
            // 
            this.lblTargetId.Location = new System.Drawing.Point(8, 19);
            this.lblTargetId.Name = "lblTargetId";
            this.lblTargetId.Size = new System.Drawing.Size(96, 16);
            this.lblTargetId.TabIndex = 4;
            this.lblTargetId.Text = "ID";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Copied to clipboard!";
            // 
            // txtMapSubZoneName
            // 
            this.txtMapSubZoneName.Location = new System.Drawing.Point(104, 88);
            this.txtMapSubZoneName.Name = "txtMapSubZoneName";
            this.txtMapSubZoneName.Size = new System.Drawing.Size(216, 22);
            this.txtMapSubZoneName.TabIndex = 40;
            // 
            // lblMapSubZoneName
            // 
            this.lblMapSubZoneName.Location = new System.Drawing.Point(8, 91);
            this.lblMapSubZoneName.Name = "lblMapSubZoneName";
            this.lblMapSubZoneName.Size = new System.Drawing.Size(96, 16);
            this.lblMapSubZoneName.TabIndex = 39;
            this.lblMapSubZoneName.Text = "SubZone Name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1271, 829);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.grpUi);
            this.Controls.Add(this.grpGameObjects);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.grpMap);
            this.Controls.Add(this.grpPlayer);
            this.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Beholder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            this.grpMap.ResumeLayout(false);
            this.grpMap.PerformLayout();
            this.grpGameObjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameObjects)).EndInit();
            this.grpUi.ResumeLayout(false);
            this.grpUi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.Label lblPlayerId;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblMapPlayerPosition;
        private System.Windows.Forms.TextBox txtMapPlayerPosition;
        private System.Windows.Forms.CheckBox chkPlayerIsAlive;
        private System.Windows.Forms.CheckBox chkPlayerInCombat;
        private System.Windows.Forms.CheckBox chkFateManagerWithinFate;
        private System.Windows.Forms.CheckBox chkTalkDialogOpen;
        private System.Windows.Forms.CheckBox chkPlayerIsMounted;
        private System.Windows.Forms.CheckBox chkDutyManagerInInstance;
        private System.Windows.Forms.CheckBox chkDutyManagerDutyReady;
        private System.Windows.Forms.Label lblPlayerMountId;
        private System.Windows.Forms.TextBox txtPlayerMountId;
        private System.Windows.Forms.GroupBox grpMap;
        private System.Windows.Forms.TextBox txtMapName;
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.TextBox txtMapId;
        private System.Windows.Forms.Label lblMapId;
        private System.Windows.Forms.CheckBox chkMapWorldManagerCanFly;
        private System.Windows.Forms.CheckBox chkMapWorldManagerCanTeleport;
        private System.Windows.Forms.TextBox txtMapWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMapWeatherId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.GroupBox grpGameObjects;
        private System.Windows.Forms.DataGridView dgvGameObjects;
        private System.Windows.Forms.CheckBox chkPlayerIsCasting;
        private System.Windows.Forms.GroupBox grpUi;
        private System.Windows.Forms.CheckBox chkMovementManagerIsOccupied;
        private System.Windows.Forms.CheckBox chkMovementManagerIsMoving;
        private System.Windows.Forms.CheckBox chkSelectYesnoIsOpen;
        private System.Windows.Forms.CheckBox chkConversationIsOpen;
        private System.Windows.Forms.CheckBox chkGrandCompanySupplyListIsOpen;
        private System.Windows.Forms.CheckBox chkGrandCompanyExchangeIsOpen;
        private System.Windows.Forms.CheckBox chkShopExchangeItemIsOpen;
        private System.Windows.Forms.CheckBox chkSynthesisIsOpen;
        private System.Windows.Forms.CheckBox chkCraftingManagerIsCrafting;
        private System.Windows.Forms.CheckBox chkCraftingLogIsOpen;
        private System.Windows.Forms.CheckBox chkSelectIconStringIsOpen;
        private System.Windows.Forms.CheckBox chkCommonBehaviorsIsLoading;
        private System.Windows.Forms.CheckBox chkSelectStringIsOpen;
        private System.Windows.Forms.CheckBox chkJournalAcceptIsOpen;
        private System.Windows.Forms.CheckBox chkJournalResultIsOpen;
        private System.Windows.Forms.CheckBox chkShopProxyIsOpen;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTargetPosition;
        private System.Windows.Forms.Label lblTargetPosition;
        private System.Windows.Forms.TextBox txtTargetName;
        private System.Windows.Forms.Label lblTargetName;
        private System.Windows.Forms.TextBox txtTargetNpcId;
        private System.Windows.Forms.Label lblTargetNpcId;
        private System.Windows.Forms.TextBox txtTargetId;
        private System.Windows.Forms.Label lblTargetId;
        private System.Windows.Forms.Button btnCopyTargetNpcObject;
        private System.Windows.Forms.Button btnCopyTargetVector3;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnCopyPlayerVector3;
        private System.Windows.Forms.Button btnCopyTargetXYZ;
        private System.Windows.Forms.Button btnCopyPlayerXYZ;
        private System.Windows.Forms.Label lblPlayerFishingState;
        private System.Windows.Forms.TextBox txtPlayerFishingState;
        private System.Windows.Forms.CheckBox chkPlayerIsFishing;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkPlayerIsOnFishingBoat;
        private System.Windows.Forms.TextBox txtTargetDistance2d;
        private System.Windows.Forms.Label lblTargetDistance2d;
        private System.Windows.Forms.TextBox txtTargetDistance3d;
        private System.Windows.Forms.Label lblTargetDistance3d;
        private System.Windows.Forms.TextBox txtTargetDistance2dSqr;
        private System.Windows.Forms.Label lblTargetDistance2dSqr;
        private System.Windows.Forms.CheckBox chkQuestLogManagerInCutscene;
        private System.Windows.Forms.TextBox txtMapSubZoneId;
        private System.Windows.Forms.Label lblMapSubZoneId;
        private System.Windows.Forms.TextBox txtMapSubZoneName;
        private System.Windows.Forms.Label lblMapSubZoneName;
    }
}