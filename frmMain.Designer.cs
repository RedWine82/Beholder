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
            this.chkMovementManagerIsOccupied = new System.Windows.Forms.CheckBox();
            this.chkMovementManagerIsMoving = new System.Windows.Forms.CheckBox();
            this.chkPlayerIsCasting = new System.Windows.Forms.CheckBox();
            this.txtPlayerTargetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerMountId = new System.Windows.Forms.Label();
            this.txtPlayerMountId = new System.Windows.Forms.TextBox();
            this.chkPlayerIsMounted = new System.Windows.Forms.CheckBox();
            this.chkDutyManagerInInstance = new System.Windows.Forms.CheckBox();
            this.chkDutyManagerDutyReady = new System.Windows.Forms.CheckBox();
            this.lblPlayerPositionZ = new System.Windows.Forms.Label();
            this.lblPlayerPositionY = new System.Windows.Forms.Label();
            this.lblPlayerPositionX = new System.Windows.Forms.Label();
            this.chkFateManagerWithinFate = new System.Windows.Forms.CheckBox();
            this.chkPlayerIsAlive = new System.Windows.Forms.CheckBox();
            this.chkPlayerInCombat = new System.Windows.Forms.CheckBox();
            this.txtPlayerPositionZ = new System.Windows.Forms.TextBox();
            this.txtPlayerPositionY = new System.Windows.Forms.TextBox();
            this.txtPlayerPositionX = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPlayerTargetId = new System.Windows.Forms.TextBox();
            this.lblPlayerTargetId = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtPlayerId = new System.Windows.Forms.TextBox();
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.chkTalkDialogOpen = new System.Windows.Forms.CheckBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.grpMap = new System.Windows.Forms.GroupBox();
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
            this.chkSelectIconStringIsOpen = new System.Windows.Forms.CheckBox();
            this.chkSynthesisIsOpen = new System.Windows.Forms.CheckBox();
            this.chkCraftingManagerIsCrafting = new System.Windows.Forms.CheckBox();
            this.chkCraftingLogIsOpen = new System.Windows.Forms.CheckBox();
            this.chkSelectYesnoIsOpen = new System.Windows.Forms.CheckBox();
            this.chkConversationIsOpen = new System.Windows.Forms.CheckBox();
            this.chkGrandCompanySupplyListIsOpen = new System.Windows.Forms.CheckBox();
            this.chkGrandCompanyExchangeIsOpen = new System.Windows.Forms.CheckBox();
            this.chkShopExchangeItemIsOpen = new System.Windows.Forms.CheckBox();
            this.chkSelectStringIsOpen = new System.Windows.Forms.CheckBox();
            this.chkJournalAcceptIsOpen = new System.Windows.Forms.CheckBox();
            this.chkJournalResultIsOpen = new System.Windows.Forms.CheckBox();
            this.grpPlayer.SuspendLayout();
            this.grpMap.SuspendLayout();
            this.grpGameObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGameObjects)).BeginInit();
            this.grpUi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.chkMovementManagerIsOccupied);
            this.grpPlayer.Controls.Add(this.chkMovementManagerIsMoving);
            this.grpPlayer.Controls.Add(this.chkPlayerIsCasting);
            this.grpPlayer.Controls.Add(this.txtPlayerTargetName);
            this.grpPlayer.Controls.Add(this.label3);
            this.grpPlayer.Controls.Add(this.lblPlayerMountId);
            this.grpPlayer.Controls.Add(this.txtPlayerMountId);
            this.grpPlayer.Controls.Add(this.chkPlayerIsMounted);
            this.grpPlayer.Controls.Add(this.chkDutyManagerInInstance);
            this.grpPlayer.Controls.Add(this.chkDutyManagerDutyReady);
            this.grpPlayer.Controls.Add(this.lblPlayerPositionZ);
            this.grpPlayer.Controls.Add(this.lblPlayerPositionY);
            this.grpPlayer.Controls.Add(this.lblPlayerPositionX);
            this.grpPlayer.Controls.Add(this.chkFateManagerWithinFate);
            this.grpPlayer.Controls.Add(this.chkPlayerIsAlive);
            this.grpPlayer.Controls.Add(this.chkPlayerInCombat);
            this.grpPlayer.Controls.Add(this.txtPlayerPositionZ);
            this.grpPlayer.Controls.Add(this.txtPlayerPositionY);
            this.grpPlayer.Controls.Add(this.txtPlayerPositionX);
            this.grpPlayer.Controls.Add(this.lblPosition);
            this.grpPlayer.Controls.Add(this.txtPlayerTargetId);
            this.grpPlayer.Controls.Add(this.lblPlayerTargetId);
            this.grpPlayer.Controls.Add(this.txtPlayerName);
            this.grpPlayer.Controls.Add(this.lblPlayerName);
            this.grpPlayer.Controls.Add(this.txtPlayerId);
            this.grpPlayer.Controls.Add(this.lblPlayerId);
            this.grpPlayer.ForeColor = System.Drawing.Color.White;
            this.grpPlayer.Location = new System.Drawing.Point(8, 32);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(328, 264);
            this.grpPlayer.TabIndex = 0;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Player";
            // 
            // chkMovementManagerIsOccupied
            // 
            this.chkMovementManagerIsOccupied.AutoSize = true;
            this.chkMovementManagerIsOccupied.Location = new System.Drawing.Point(8, 225);
            this.chkMovementManagerIsOccupied.Name = "chkMovementManagerIsOccupied";
            this.chkMovementManagerIsOccupied.Size = new System.Drawing.Size(208, 19);
            this.chkMovementManagerIsOccupied.TabIndex = 26;
            this.chkMovementManagerIsOccupied.Text = "MovementManager.IsOccupied";
            this.chkMovementManagerIsOccupied.UseVisualStyleBackColor = true;
            // 
            // chkMovementManagerIsMoving
            // 
            this.chkMovementManagerIsMoving.AutoSize = true;
            this.chkMovementManagerIsMoving.Location = new System.Drawing.Point(8, 209);
            this.chkMovementManagerIsMoving.Name = "chkMovementManagerIsMoving";
            this.chkMovementManagerIsMoving.Size = new System.Drawing.Size(196, 19);
            this.chkMovementManagerIsMoving.TabIndex = 25;
            this.chkMovementManagerIsMoving.Text = "MovementManager.IsMoving";
            this.chkMovementManagerIsMoving.UseVisualStyleBackColor = true;
            // 
            // chkPlayerIsCasting
            // 
            this.chkPlayerIsCasting.AutoSize = true;
            this.chkPlayerIsCasting.Location = new System.Drawing.Point(8, 192);
            this.chkPlayerIsCasting.Name = "chkPlayerIsCasting";
            this.chkPlayerIsCasting.Size = new System.Drawing.Size(116, 19);
            this.chkPlayerIsCasting.TabIndex = 24;
            this.chkPlayerIsCasting.Text = "Player.IsCasting";
            this.chkPlayerIsCasting.UseVisualStyleBackColor = true;
            // 
            // txtPlayerTargetName
            // 
            this.txtPlayerTargetName.Location = new System.Drawing.Point(96, 88);
            this.txtPlayerTargetName.Name = "txtPlayerTargetName";
            this.txtPlayerTargetName.Size = new System.Drawing.Size(224, 22);
            this.txtPlayerTargetName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Target Name";
            // 
            // lblPlayerMountId
            // 
            this.lblPlayerMountId.Location = new System.Drawing.Point(184, 139);
            this.lblPlayerMountId.Name = "lblPlayerMountId";
            this.lblPlayerMountId.Size = new System.Drawing.Size(72, 16);
            this.lblPlayerMountId.TabIndex = 21;
            this.lblPlayerMountId.Text = "Mount ID";
            // 
            // txtPlayerMountId
            // 
            this.txtPlayerMountId.Location = new System.Drawing.Point(260, 136);
            this.txtPlayerMountId.Name = "txtPlayerMountId";
            this.txtPlayerMountId.Size = new System.Drawing.Size(60, 22);
            this.txtPlayerMountId.TabIndex = 20;
            // 
            // chkPlayerIsMounted
            // 
            this.chkPlayerIsMounted.AutoSize = true;
            this.chkPlayerIsMounted.Location = new System.Drawing.Point(8, 136);
            this.chkPlayerIsMounted.Name = "chkPlayerIsMounted";
            this.chkPlayerIsMounted.Size = new System.Drawing.Size(125, 19);
            this.chkPlayerIsMounted.TabIndex = 19;
            this.chkPlayerIsMounted.Text = "Player.IsMounted";
            this.chkPlayerIsMounted.UseVisualStyleBackColor = true;
            // 
            // chkDutyManagerInInstance
            // 
            this.chkDutyManagerInInstance.AutoSize = true;
            this.chkDutyManagerInInstance.Location = new System.Drawing.Point(144, 176);
            this.chkDutyManagerInInstance.Name = "chkDutyManagerInInstance";
            this.chkDutyManagerInInstance.Size = new System.Drawing.Size(167, 19);
            this.chkDutyManagerInInstance.TabIndex = 18;
            this.chkDutyManagerInInstance.Text = "DutyManager.InInstance";
            this.chkDutyManagerInInstance.UseVisualStyleBackColor = true;
            // 
            // chkDutyManagerDutyReady
            // 
            this.chkDutyManagerDutyReady.AutoSize = true;
            this.chkDutyManagerDutyReady.Location = new System.Drawing.Point(144, 192);
            this.chkDutyManagerDutyReady.Name = "chkDutyManagerDutyReady";
            this.chkDutyManagerDutyReady.Size = new System.Drawing.Size(173, 19);
            this.chkDutyManagerDutyReady.TabIndex = 17;
            this.chkDutyManagerDutyReady.Text = "DutyManager.DutyReady";
            this.chkDutyManagerDutyReady.UseVisualStyleBackColor = true;
            // 
            // lblPlayerPositionZ
            // 
            this.lblPlayerPositionZ.AutoSize = true;
            this.lblPlayerPositionZ.Location = new System.Drawing.Point(245, 116);
            this.lblPlayerPositionZ.Name = "lblPlayerPositionZ";
            this.lblPlayerPositionZ.Size = new System.Drawing.Size(14, 15);
            this.lblPlayerPositionZ.TabIndex = 16;
            this.lblPlayerPositionZ.Text = "Z";
            // 
            // lblPlayerPositionY
            // 
            this.lblPlayerPositionY.AutoSize = true;
            this.lblPlayerPositionY.Location = new System.Drawing.Point(169, 116);
            this.lblPlayerPositionY.Name = "lblPlayerPositionY";
            this.lblPlayerPositionY.Size = new System.Drawing.Size(14, 15);
            this.lblPlayerPositionY.TabIndex = 15;
            this.lblPlayerPositionY.Text = "Y";
            // 
            // lblPlayerPositionX
            // 
            this.lblPlayerPositionX.AutoSize = true;
            this.lblPlayerPositionX.Location = new System.Drawing.Point(92, 116);
            this.lblPlayerPositionX.Name = "lblPlayerPositionX";
            this.lblPlayerPositionX.Size = new System.Drawing.Size(15, 15);
            this.lblPlayerPositionX.TabIndex = 14;
            this.lblPlayerPositionX.Text = "X";
            // 
            // chkFateManagerWithinFate
            // 
            this.chkFateManagerWithinFate.AutoSize = true;
            this.chkFateManagerWithinFate.Location = new System.Drawing.Point(144, 160);
            this.chkFateManagerWithinFate.Name = "chkFateManagerWithinFate";
            this.chkFateManagerWithinFate.Size = new System.Drawing.Size(168, 19);
            this.chkFateManagerWithinFate.TabIndex = 13;
            this.chkFateManagerWithinFate.Text = "FateManager.WithinFate";
            this.chkFateManagerWithinFate.UseVisualStyleBackColor = true;
            // 
            // chkPlayerIsAlive
            // 
            this.chkPlayerIsAlive.AutoSize = true;
            this.chkPlayerIsAlive.Location = new System.Drawing.Point(8, 176);
            this.chkPlayerIsAlive.Name = "chkPlayerIsAlive";
            this.chkPlayerIsAlive.Size = new System.Drawing.Size(101, 19);
            this.chkPlayerIsAlive.TabIndex = 11;
            this.chkPlayerIsAlive.Text = "Player.IsAlive";
            this.chkPlayerIsAlive.UseVisualStyleBackColor = true;
            // 
            // chkPlayerInCombat
            // 
            this.chkPlayerInCombat.AutoSize = true;
            this.chkPlayerInCombat.Location = new System.Drawing.Point(8, 160);
            this.chkPlayerInCombat.Name = "chkPlayerInCombat";
            this.chkPlayerInCombat.Size = new System.Drawing.Size(120, 19);
            this.chkPlayerInCombat.TabIndex = 10;
            this.chkPlayerInCombat.Text = "Player.InCombat";
            this.chkPlayerInCombat.UseVisualStyleBackColor = true;
            // 
            // txtPlayerPositionZ
            // 
            this.txtPlayerPositionZ.Location = new System.Drawing.Point(260, 112);
            this.txtPlayerPositionZ.Name = "txtPlayerPositionZ";
            this.txtPlayerPositionZ.Size = new System.Drawing.Size(60, 22);
            this.txtPlayerPositionZ.TabIndex = 9;
            // 
            // txtPlayerPositionY
            // 
            this.txtPlayerPositionY.Location = new System.Drawing.Point(184, 112);
            this.txtPlayerPositionY.Name = "txtPlayerPositionY";
            this.txtPlayerPositionY.Size = new System.Drawing.Size(60, 22);
            this.txtPlayerPositionY.TabIndex = 8;
            // 
            // txtPlayerPositionX
            // 
            this.txtPlayerPositionX.Location = new System.Drawing.Point(108, 112);
            this.txtPlayerPositionX.Name = "txtPlayerPositionX";
            this.txtPlayerPositionX.Size = new System.Drawing.Size(60, 22);
            this.txtPlayerPositionX.TabIndex = 7;
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(8, 115);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(88, 16);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Position";
            // 
            // txtPlayerTargetId
            // 
            this.txtPlayerTargetId.Location = new System.Drawing.Point(96, 64);
            this.txtPlayerTargetId.Name = "txtPlayerTargetId";
            this.txtPlayerTargetId.Size = new System.Drawing.Size(224, 22);
            this.txtPlayerTargetId.TabIndex = 5;
            // 
            // lblPlayerTargetId
            // 
            this.lblPlayerTargetId.Location = new System.Drawing.Point(8, 67);
            this.lblPlayerTargetId.Name = "lblPlayerTargetId";
            this.lblPlayerTargetId.Size = new System.Drawing.Size(88, 16);
            this.lblPlayerTargetId.TabIndex = 4;
            this.lblPlayerTargetId.Text = "Target ID";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(96, 40);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(224, 22);
            this.txtPlayerName.TabIndex = 3;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Location = new System.Drawing.Point(8, 43);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(88, 16);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "Name";
            // 
            // txtPlayerId
            // 
            this.txtPlayerId.Location = new System.Drawing.Point(96, 16);
            this.txtPlayerId.Name = "txtPlayerId";
            this.txtPlayerId.Size = new System.Drawing.Size(224, 22);
            this.txtPlayerId.TabIndex = 1;
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.Location = new System.Drawing.Point(8, 19);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(88, 16);
            this.lblPlayerId.TabIndex = 0;
            this.lblPlayerId.Text = "ID";
            // 
            // chkTalkDialogOpen
            // 
            this.chkTalkDialogOpen.AutoSize = true;
            this.chkTalkDialogOpen.Location = new System.Drawing.Point(8, 160);
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
            this.grpMap.ForeColor = System.Drawing.Color.White;
            this.grpMap.Location = new System.Drawing.Point(344, 32);
            this.grpMap.Name = "grpMap";
            this.grpMap.Size = new System.Drawing.Size(328, 264);
            this.grpMap.TabIndex = 22;
            this.grpMap.TabStop = false;
            this.grpMap.Text = "Map";
            // 
            // chkCommonBehaviorsIsLoading
            // 
            this.chkCommonBehaviorsIsLoading.AutoSize = true;
            this.chkCommonBehaviorsIsLoading.Location = new System.Drawing.Point(8, 240);
            this.chkCommonBehaviorsIsLoading.Name = "chkCommonBehaviorsIsLoading";
            this.chkCommonBehaviorsIsLoading.Size = new System.Drawing.Size(194, 19);
            this.chkCommonBehaviorsIsLoading.TabIndex = 28;
            this.chkCommonBehaviorsIsLoading.Text = "CommonBehaviors.IsLoading";
            this.chkCommonBehaviorsIsLoading.UseVisualStyleBackColor = true;
            // 
            // txtMapWeather
            // 
            this.txtMapWeather.Location = new System.Drawing.Point(96, 88);
            this.txtMapWeather.Name = "txtMapWeather";
            this.txtMapWeather.Size = new System.Drawing.Size(224, 22);
            this.txtMapWeather.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Weather";
            // 
            // txtMapWeatherId
            // 
            this.txtMapWeatherId.Location = new System.Drawing.Point(96, 64);
            this.txtMapWeatherId.Name = "txtMapWeatherId";
            this.txtMapWeatherId.Size = new System.Drawing.Size(224, 22);
            this.txtMapWeatherId.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Weather ID";
            // 
            // chkMapWorldManagerCanTeleport
            // 
            this.chkMapWorldManagerCanTeleport.AutoSize = true;
            this.chkMapWorldManagerCanTeleport.Location = new System.Drawing.Point(8, 136);
            this.chkMapWorldManagerCanTeleport.Name = "chkMapWorldManagerCanTeleport";
            this.chkMapWorldManagerCanTeleport.Size = new System.Drawing.Size(185, 19);
            this.chkMapWorldManagerCanTeleport.TabIndex = 23;
            this.chkMapWorldManagerCanTeleport.Text = "WorldManager.CanTeleport";
            this.chkMapWorldManagerCanTeleport.UseVisualStyleBackColor = true;
            // 
            // chkMapWorldManagerCanFly
            // 
            this.chkMapWorldManagerCanFly.AutoSize = true;
            this.chkMapWorldManagerCanFly.Location = new System.Drawing.Point(8, 120);
            this.chkMapWorldManagerCanFly.Name = "chkMapWorldManagerCanFly";
            this.chkMapWorldManagerCanFly.Size = new System.Drawing.Size(153, 19);
            this.chkMapWorldManagerCanFly.TabIndex = 22;
            this.chkMapWorldManagerCanFly.Text = "WorldManager.CanFly";
            this.chkMapWorldManagerCanFly.UseVisualStyleBackColor = true;
            // 
            // txtMapName
            // 
            this.txtMapName.Location = new System.Drawing.Point(96, 40);
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(224, 22);
            this.txtMapName.TabIndex = 3;
            // 
            // lblMapName
            // 
            this.lblMapName.Location = new System.Drawing.Point(8, 43);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(72, 16);
            this.lblMapName.TabIndex = 2;
            this.lblMapName.Text = "Name";
            // 
            // txtMapId
            // 
            this.txtMapId.Location = new System.Drawing.Point(96, 16);
            this.txtMapId.Name = "txtMapId";
            this.txtMapId.Size = new System.Drawing.Size(224, 22);
            this.txtMapId.TabIndex = 1;
            // 
            // lblMapId
            // 
            this.lblMapId.Location = new System.Drawing.Point(8, 19);
            this.lblMapId.Name = "lblMapId";
            this.lblMapId.Size = new System.Drawing.Size(72, 16);
            this.lblMapId.TabIndex = 0;
            this.lblMapId.Text = "ID";
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisclaimer.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.ForeColor = System.Drawing.Color.Salmon;
            this.lblDisclaimer.Location = new System.Drawing.Point(16, 8);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(1000, 16);
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
            this.grpGameObjects.Location = new System.Drawing.Point(8, 304);
            this.grpGameObjects.Name = "grpGameObjects";
            this.grpGameObjects.Size = new System.Drawing.Size(1008, 359);
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
            this.dgvGameObjects.Size = new System.Drawing.Size(992, 327);
            this.dgvGameObjects.TabIndex = 25;
            this.dgvGameObjects.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvGameObjects_DataError);
            // 
            // grpUi
            // 
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
            this.grpUi.Location = new System.Drawing.Point(680, 32);
            this.grpUi.Name = "grpUi";
            this.grpUi.Size = new System.Drawing.Size(328, 264);
            this.grpUi.TabIndex = 28;
            this.grpUi.TabStop = false;
            this.grpUi.Text = "UI";
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
            this.chkSynthesisIsOpen.Location = new System.Drawing.Point(8, 224);
            this.chkSynthesisIsOpen.Name = "chkSynthesisIsOpen";
            this.chkSynthesisIsOpen.Size = new System.Drawing.Size(124, 19);
            this.chkSynthesisIsOpen.TabIndex = 20;
            this.chkSynthesisIsOpen.Text = "Synthesis.IsOpen";
            this.chkSynthesisIsOpen.UseVisualStyleBackColor = true;
            // 
            // chkCraftingManagerIsCrafting
            // 
            this.chkCraftingManagerIsCrafting.AutoSize = true;
            this.chkCraftingManagerIsCrafting.Location = new System.Drawing.Point(8, 208);
            this.chkCraftingManagerIsCrafting.Name = "chkCraftingManagerIsCrafting";
            this.chkCraftingManagerIsCrafting.Size = new System.Drawing.Size(181, 19);
            this.chkCraftingManagerIsCrafting.TabIndex = 19;
            this.chkCraftingManagerIsCrafting.Text = "CraftingManager.IsCrafting";
            this.chkCraftingManagerIsCrafting.UseVisualStyleBackColor = true;
            // 
            // chkCraftingLogIsOpen
            // 
            this.chkCraftingLogIsOpen.AutoSize = true;
            this.chkCraftingLogIsOpen.Location = new System.Drawing.Point(8, 192);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1023, 671);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtPlayerId;
        private System.Windows.Forms.Label lblPlayerId;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TextBox txtPlayerTargetId;
        private System.Windows.Forms.Label lblPlayerTargetId;
        private System.Windows.Forms.TextBox txtPlayerPositionY;
        private System.Windows.Forms.TextBox txtPlayerPositionX;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtPlayerPositionZ;
        private System.Windows.Forms.CheckBox chkPlayerIsAlive;
        private System.Windows.Forms.CheckBox chkPlayerInCombat;
        private System.Windows.Forms.Label lblPlayerPositionY;
        private System.Windows.Forms.Label lblPlayerPositionX;
        private System.Windows.Forms.CheckBox chkFateManagerWithinFate;
        private System.Windows.Forms.CheckBox chkTalkDialogOpen;
        private System.Windows.Forms.Label lblPlayerPositionZ;
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
        private System.Windows.Forms.TextBox txtPlayerTargetName;
        private System.Windows.Forms.Label label3;
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
    }
}