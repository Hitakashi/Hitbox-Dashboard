namespace HitboxDashboard
{
    partial class HitboxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HitboxForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.editorDropDown = new System.Windows.Forms.ComboBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.editorCheck = new System.Windows.Forms.CheckBox();
            this.hitboxLogo = new System.Windows.Forms.PictureBox();
            this.hitboxSubmitLogin = new System.Windows.Forms.Button();
            this.dashboardTab = new System.Windows.Forms.TabPage();
            this.restartLabel = new System.Windows.Forms.Label();
            this.adMinusButton = new System.Windows.Forms.Button();
            this.adPlusButton = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chatTextBox = new System.Windows.Forms.RichTextBox();
            this.adButton = new System.Windows.Forms.Button();
            this.userListControl = new System.Windows.Forms.TabControl();
            this.allUsers = new System.Windows.Forms.TabPage();
            this.allUsersList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modUsers = new System.Windows.Forms.TabPage();
            this.modUsersList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewerUsers = new System.Windows.Forms.TabPage();
            this.viewerUsersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bannedUser = new System.Windows.Forms.TabPage();
            this.banUserList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.visibleBox = new System.Windows.Forms.GroupBox();
            this.hiddenButton = new System.Windows.Forms.RadioButton();
            this.visibleButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.streamTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gameComboBox = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userListTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.titleTimer = new System.Windows.Forms.Timer(this.components);
            this.hiddenTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.allContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bannedContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl.SuspendLayout();
            this.loginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitboxLogo)).BeginInit();
            this.dashboardTab.SuspendLayout();
            this.userListControl.SuspendLayout();
            this.allUsers.SuspendLayout();
            this.modUsers.SuspendLayout();
            this.viewerUsers.SuspendLayout();
            this.bannedUser.SuspendLayout();
            this.visibleBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.loginTab);
            this.tabControl.Controls.Add(this.dashboardTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(634, 561);
            this.tabControl.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.editorDropDown);
            this.loginTab.Controls.Add(this.aboutLabel);
            this.loginTab.Controls.Add(this.usernameTextBox);
            this.loginTab.Controls.Add(this.usernameLabel);
            this.loginTab.Controls.Add(this.passwordLabel);
            this.loginTab.Controls.Add(this.passwordTextBox);
            this.loginTab.Controls.Add(this.editorCheck);
            this.loginTab.Controls.Add(this.hitboxLogo);
            this.loginTab.Controls.Add(this.hitboxSubmitLogin);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(626, 535);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login";
            this.loginTab.ToolTipText = "Editor";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // editorDropDown
            // 
            this.editorDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editorDropDown.FormattingEnabled = true;
            this.editorDropDown.Location = new System.Drawing.Point(235, 391);
            this.editorDropDown.Name = "editorDropDown";
            this.editorDropDown.Size = new System.Drawing.Size(121, 21);
            this.editorDropDown.TabIndex = 9;
            this.editorDropDown.Visible = false;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Location = new System.Drawing.Point(567, 3);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(38, 13);
            this.aboutLabel.TabIndex = 8;
            this.aboutLabel.Text = " About";
            this.aboutLabel.Click += new System.EventHandler(this.aboutLabel_click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(227, 227);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(136, 20);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(271, 211);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(268, 311);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(227, 327);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(136, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // editorCheck
            // 
            this.editorCheck.AutoSize = true;
            this.editorCheck.Location = new System.Drawing.Point(268, 418);
            this.editorCheck.Name = "editorCheck";
            this.editorCheck.Size = new System.Drawing.Size(53, 17);
            this.editorCheck.TabIndex = 2;
            this.editorCheck.Text = "Editor";
            this.toolTip1.SetToolTip(this.editorCheck, "This tool tip is enabled once a password is typed in.\r\n");
            this.editorCheck.UseVisualStyleBackColor = true;
            // 
            // hitboxLogo
            // 
            this.hitboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("hitboxLogo.Image")));
            this.hitboxLogo.Location = new System.Drawing.Point(202, 0);
            this.hitboxLogo.Name = "hitboxLogo";
            this.hitboxLogo.Size = new System.Drawing.Size(187, 172);
            this.hitboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hitboxLogo.TabIndex = 1;
            this.hitboxLogo.TabStop = false;
            // 
            // hitboxSubmitLogin
            // 
            this.hitboxSubmitLogin.Location = new System.Drawing.Point(213, 441);
            this.hitboxSubmitLogin.Name = "hitboxSubmitLogin";
            this.hitboxSubmitLogin.Size = new System.Drawing.Size(166, 45);
            this.hitboxSubmitLogin.TabIndex = 3;
            this.hitboxSubmitLogin.Text = "Login";
            this.hitboxSubmitLogin.UseVisualStyleBackColor = true;
            this.hitboxSubmitLogin.Click += new System.EventHandler(this.hitboxSubmitLogin_Click);
            // 
            // dashboardTab
            // 
            this.dashboardTab.Controls.Add(this.restartLabel);
            this.dashboardTab.Controls.Add(this.adMinusButton);
            this.dashboardTab.Controls.Add(this.adPlusButton);
            this.dashboardTab.Controls.Add(this.chatBox);
            this.dashboardTab.Controls.Add(this.chatTextBox);
            this.dashboardTab.Controls.Add(this.adButton);
            this.dashboardTab.Controls.Add(this.userListControl);
            this.dashboardTab.Controls.Add(this.visibleBox);
            this.dashboardTab.Controls.Add(this.groupBox2);
            this.dashboardTab.Controls.Add(this.groupBox1);
            this.dashboardTab.Location = new System.Drawing.Point(4, 22);
            this.dashboardTab.Name = "dashboardTab";
            this.dashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTab.Size = new System.Drawing.Size(626, 535);
            this.dashboardTab.TabIndex = 1;
            this.dashboardTab.Text = "Dashboard";
            this.dashboardTab.UseVisualStyleBackColor = true;
            // 
            // restartLabel
            // 
            this.restartLabel.AutoSize = true;
            this.restartLabel.Location = new System.Drawing.Point(252, 238);
            this.restartLabel.Name = "restartLabel";
            this.restartLabel.Size = new System.Drawing.Size(41, 13);
            this.restartLabel.TabIndex = 15;
            this.restartLabel.Text = "Restart";
            this.restartLabel.Click += new System.EventHandler(this.restartLabel_Click);
            // 
            // adMinusButton
            // 
            this.adMinusButton.Location = new System.Drawing.Point(85, 205);
            this.adMinusButton.Name = "adMinusButton";
            this.adMinusButton.Size = new System.Drawing.Size(20, 23);
            this.adMinusButton.TabIndex = 14;
            this.adMinusButton.Text = "-";
            this.adMinusButton.UseVisualStyleBackColor = true;
            this.adMinusButton.Click += new System.EventHandler(this.adMinusButton_Click);
            // 
            // adPlusButton
            // 
            this.adPlusButton.Location = new System.Drawing.Point(192, 205);
            this.adPlusButton.Name = "adPlusButton";
            this.adPlusButton.Size = new System.Drawing.Size(20, 23);
            this.adPlusButton.TabIndex = 13;
            this.adPlusButton.Text = "+";
            this.adPlusButton.UseVisualStyleBackColor = true;
            this.adPlusButton.Click += new System.EventHandler(this.adPlusButton_Click);
            // 
            // chatBox
            // 
            this.chatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatBox.Location = new System.Drawing.Point(302, 480);
            this.chatBox.MaxLength = 300;
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(316, 52);
            this.chatBox.TabIndex = 12;
            this.chatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatBox_KeyDown);
            // 
            // chatTextBox
            // 
            this.chatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatTextBox.BackColor = System.Drawing.Color.White;
            this.chatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatTextBox.HideSelection = false;
            this.chatTextBox.Location = new System.Drawing.Point(302, 6);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.ReadOnly = true;
            this.chatTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chatTextBox.Size = new System.Drawing.Size(316, 463);
            this.chatTextBox.TabIndex = 11;
            this.chatTextBox.Text = "";
            // 
            // adButton
            // 
            this.adButton.Location = new System.Drawing.Point(111, 205);
            this.adButton.Name = "adButton";
            this.adButton.Size = new System.Drawing.Size(75, 23);
            this.adButton.TabIndex = 10;
            this.adButton.Text = "Run 0 Ads";
            this.adButton.UseVisualStyleBackColor = true;
            this.adButton.Click += new System.EventHandler(this.adButton_Click);
            // 
            // userListControl
            // 
            this.userListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userListControl.Controls.Add(this.allUsers);
            this.userListControl.Controls.Add(this.modUsers);
            this.userListControl.Controls.Add(this.viewerUsers);
            this.userListControl.Controls.Add(this.bannedUser);
            this.userListControl.Location = new System.Drawing.Point(13, 234);
            this.userListControl.Name = "userListControl";
            this.userListControl.SelectedIndex = 0;
            this.userListControl.Size = new System.Drawing.Size(284, 293);
            this.userListControl.TabIndex = 8;
            // 
            // allUsers
            // 
            this.allUsers.Controls.Add(this.allUsersList);
            this.allUsers.Location = new System.Drawing.Point(4, 22);
            this.allUsers.Name = "allUsers";
            this.allUsers.Padding = new System.Windows.Forms.Padding(3);
            this.allUsers.Size = new System.Drawing.Size(276, 267);
            this.allUsers.TabIndex = 0;
            this.allUsers.Text = "All";
            this.allUsers.UseVisualStyleBackColor = true;
            // 
            // allUsersList
            // 
            this.allUsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.allUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allUsersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.allUsersList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allUsersList.Location = new System.Drawing.Point(3, 3);
            this.allUsersList.MultiSelect = false;
            this.allUsersList.Name = "allUsersList";
            this.allUsersList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.allUsersList.Size = new System.Drawing.Size(270, 261);
            this.allUsersList.TabIndex = 0;
            this.allUsersList.UseCompatibleStateImageBehavior = false;
            this.allUsersList.View = System.Windows.Forms.View.Details;
            this.allUsersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.allUsersList_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 240;
            // 
            // modUsers
            // 
            this.modUsers.Controls.Add(this.modUsersList);
            this.modUsers.Location = new System.Drawing.Point(4, 22);
            this.modUsers.Name = "modUsers";
            this.modUsers.Padding = new System.Windows.Forms.Padding(3);
            this.modUsers.Size = new System.Drawing.Size(276, 267);
            this.modUsers.TabIndex = 1;
            this.modUsers.Text = "Moderators";
            this.modUsers.UseVisualStyleBackColor = true;
            // 
            // modUsersList
            // 
            this.modUsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.modUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modUsersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.modUsersList.Location = new System.Drawing.Point(3, 3);
            this.modUsersList.Name = "modUsersList";
            this.modUsersList.Size = new System.Drawing.Size(270, 261);
            this.modUsersList.TabIndex = 0;
            this.modUsersList.UseCompatibleStateImageBehavior = false;
            this.modUsersList.View = System.Windows.Forms.View.Details;
            this.modUsersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modUsersList_MouseClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 240;
            // 
            // viewerUsers
            // 
            this.viewerUsers.Controls.Add(this.viewerUsersList);
            this.viewerUsers.Location = new System.Drawing.Point(4, 22);
            this.viewerUsers.Name = "viewerUsers";
            this.viewerUsers.Padding = new System.Windows.Forms.Padding(3);
            this.viewerUsers.Size = new System.Drawing.Size(276, 267);
            this.viewerUsers.TabIndex = 2;
            this.viewerUsers.Text = "Viewers";
            this.viewerUsers.UseVisualStyleBackColor = true;
            // 
            // viewerUsersList
            // 
            this.viewerUsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.viewerUsersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerUsersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.viewerUsersList.Location = new System.Drawing.Point(3, 3);
            this.viewerUsersList.Name = "viewerUsersList";
            this.viewerUsersList.Size = new System.Drawing.Size(270, 261);
            this.viewerUsersList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.viewerUsersList.TabIndex = 0;
            this.viewerUsersList.UseCompatibleStateImageBehavior = false;
            this.viewerUsersList.View = System.Windows.Forms.View.Details;
            this.viewerUsersList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewerUsersList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 240;
            // 
            // bannedUser
            // 
            this.bannedUser.Controls.Add(this.banUserList);
            this.bannedUser.Location = new System.Drawing.Point(4, 22);
            this.bannedUser.Name = "bannedUser";
            this.bannedUser.Padding = new System.Windows.Forms.Padding(3);
            this.bannedUser.Size = new System.Drawing.Size(276, 267);
            this.bannedUser.TabIndex = 3;
            this.bannedUser.Text = "Banned";
            this.bannedUser.UseVisualStyleBackColor = true;
            // 
            // banUserList
            // 
            this.banUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.banUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banUserList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.banUserList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.banUserList.Location = new System.Drawing.Point(3, 3);
            this.banUserList.MultiSelect = false;
            this.banUserList.Name = "banUserList";
            this.banUserList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.banUserList.Size = new System.Drawing.Size(270, 261);
            this.banUserList.TabIndex = 1;
            this.banUserList.UseCompatibleStateImageBehavior = false;
            this.banUserList.View = System.Windows.Forms.View.Details;
            this.banUserList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.banUserList_MouseClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 240;
            // 
            // visibleBox
            // 
            this.visibleBox.Controls.Add(this.hiddenButton);
            this.visibleBox.Controls.Add(this.visibleButton);
            this.visibleBox.Location = new System.Drawing.Point(13, 138);
            this.visibleBox.Name = "visibleBox";
            this.visibleBox.Size = new System.Drawing.Size(284, 60);
            this.visibleBox.TabIndex = 7;
            this.visibleBox.TabStop = false;
            this.visibleBox.Text = "Channel Visibility";
            // 
            // hiddenButton
            // 
            this.hiddenButton.AutoSize = true;
            this.hiddenButton.Location = new System.Drawing.Point(180, 24);
            this.hiddenButton.Name = "hiddenButton";
            this.hiddenButton.Size = new System.Drawing.Size(59, 17);
            this.hiddenButton.TabIndex = 1;
            this.hiddenButton.TabStop = true;
            this.hiddenButton.Text = "Hidden";
            this.hiddenButton.UseVisualStyleBackColor = true;
            this.hiddenButton.Click += new System.EventHandler(this.hiddenButton_Click);
            // 
            // visibleButton
            // 
            this.visibleButton.AutoSize = true;
            this.visibleButton.Location = new System.Drawing.Point(31, 24);
            this.visibleButton.Name = "visibleButton";
            this.visibleButton.Size = new System.Drawing.Size(55, 17);
            this.visibleButton.TabIndex = 0;
            this.visibleButton.TabStop = true;
            this.visibleButton.Text = "Visible";
            this.visibleButton.UseVisualStyleBackColor = true;
            this.visibleButton.Click += new System.EventHandler(this.visibleButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.streamTitle);
            this.groupBox2.Location = new System.Drawing.Point(13, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 60);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stream Title";
            // 
            // streamTitle
            // 
            this.streamTitle.Location = new System.Drawing.Point(7, 19);
            this.streamTitle.Multiline = true;
            this.streamTitle.Name = "streamTitle";
            this.streamTitle.Size = new System.Drawing.Size(268, 35);
            this.streamTitle.TabIndex = 0;
            this.streamTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.streamTitle_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gameComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // gameComboBox
            // 
            this.gameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gameComboBox.FormattingEnabled = true;
            this.gameComboBox.Location = new System.Drawing.Point(7, 19);
            this.gameComboBox.Name = "gameComboBox";
            this.gameComboBox.Size = new System.Drawing.Size(268, 21);
            this.gameComboBox.TabIndex = 0;
            this.gameComboBox.SelectionChangeCommitted += new System.EventHandler(this.gameComboBox_SelectionChangeCommitted);
            this.gameComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameComboBox_KeyUp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Staff");
            this.imageList1.Images.SetKeyName(1, "Community");
            this.imageList1.Images.SetKeyName(2, "Community2");
            this.imageList1.Images.SetKeyName(3, "Staff2");
            this.imageList1.Images.SetKeyName(4, "Broadcaster");
            this.imageList1.Images.SetKeyName(5, "Editor");
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // userListTimer
            // 
            this.userListTimer.Interval = 10000;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // titleTimer
            // 
            this.titleTimer.Enabled = true;
            this.titleTimer.Interval = 10000;
            this.titleTimer.Tick += new System.EventHandler(this.titleTimer_Tick);
            // 
            // hiddenTimer
            // 
            this.hiddenTimer.Enabled = true;
            this.hiddenTimer.Interval = 10000;
            this.hiddenTimer.Tick += new System.EventHandler(this.hiddenTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // allContextMenu
            // 
            this.allContextMenu.Name = "contentMenu";
            this.allContextMenu.Size = new System.Drawing.Size(61, 4);
            this.allContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.allContextMenu_ItemClicked);
            // 
            // modContextMenu
            // 
            this.modContextMenu.Name = "modContextMenu";
            this.modContextMenu.Size = new System.Drawing.Size(61, 4);
            this.modContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.modContextMenu_ItemClicked);
            // 
            // viewerContextMenu
            // 
            this.viewerContextMenu.Name = "viewerContextMenu";
            this.viewerContextMenu.Size = new System.Drawing.Size(61, 4);
            this.viewerContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.viewerContextMenu_ItemClicked);
            // 
            // bannedContextMenu
            // 
            this.bannedContextMenu.Name = "bannedContextMenu";
            this.bannedContextMenu.Size = new System.Drawing.Size(61, 4);
            this.bannedContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bannedContextMenu_ItemClicked);
            // 
            // HitboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HitboxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HitboxForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hitboxLogo)).EndInit();
            this.dashboardTab.ResumeLayout(false);
            this.dashboardTab.PerformLayout();
            this.userListControl.ResumeLayout(false);
            this.allUsers.ResumeLayout(false);
            this.modUsers.ResumeLayout(false);
            this.viewerUsers.ResumeLayout(false);
            this.bannedUser.ResumeLayout(false);
            this.visibleBox.ResumeLayout(false);
            this.visibleBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TabPage dashboardTab;
        private System.Windows.Forms.Button hitboxSubmitLogin;
        private System.Windows.Forms.PictureBox hitboxLogo;
        private System.Windows.Forms.CheckBox editorCheck;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox gameComboBox;
        private System.Windows.Forms.GroupBox visibleBox;
        private System.Windows.Forms.RadioButton hiddenButton;
        private System.Windows.Forms.RadioButton visibleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage allUsers;
        private System.Windows.Forms.TabPage modUsers;
        private System.Windows.Forms.TabPage viewerUsers;
        private System.Windows.Forms.TabPage bannedUser;
        private System.Windows.Forms.Button adButton;
        public System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.RichTextBox chatTextBox;
        public System.Windows.Forms.Timer userListTimer;
        internal System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox streamTitle;
        private System.Windows.Forms.ListView viewerUsersList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView modUsersList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView allUsersList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer titleTimer;
        private System.Windows.Forms.Timer hiddenTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button adMinusButton;
        private System.Windows.Forms.Button adPlusButton;
        private System.Windows.Forms.ContextMenuStrip allContextMenu;
        internal System.Windows.Forms.TabControl userListControl;
        private System.Windows.Forms.ComboBox editorDropDown;
        private System.Windows.Forms.ListView banUserList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip modContextMenu;
        private System.Windows.Forms.ContextMenuStrip viewerContextMenu;
        private System.Windows.Forms.ContextMenuStrip bannedContextMenu;
        private System.Windows.Forms.Label restartLabel;
    }
}

