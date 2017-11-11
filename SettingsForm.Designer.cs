namespace uTorrentNotifier
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWebUI_URL = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbShowBalloonTips = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.cbRunOnStartup = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.tpTwitter = new System.Windows.Forms.TabPage();
            this.btnSendTestTweet = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tbTwitterPrefixTweet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTwitterEnable = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTwitterAuthorize = new System.Windows.Forms.Button();
            this.btnStartAuthorization = new System.Windows.Forms.Button();
            this.tbTwitterPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTwitterPIN = new System.Windows.Forms.Label();
            this.tpBoxcar = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnBoxcarGetAPIKey = new System.Windows.Forms.Button();
            this.tbBoxcarAPIKey = new System.Windows.Forms.TextBox();
            this.lblBoxcarAPIKey = new System.Windows.Forms.Label();
            this.tbBoxcarEmail = new System.Windows.Forms.TextBox();
            this.lblBoxcarEmail = new System.Windows.Forms.Label();
            this.cbBoxcarEnable = new System.Windows.Forms.CheckBox();
            this.tpNotifications = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbProwlNotification_TorentAdded = new System.Windows.Forms.CheckBox();
            this.cbTorrentNotification_DownloadComplete = new System.Windows.Forms.CheckBox();
            this.tbAbout = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpTwitter.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tpBoxcar.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tpNotifications.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tbAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Location = new System.Drawing.Point(6, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(67, 52);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(171, 21);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(67, 20);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(171, 21);
            this.tbUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 23);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbWebUI_URL);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 55);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WebUI URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "e.g. http://localhost:8080/gui/";
            // 
            // tbWebUI_URL
            // 
            this.tbWebUI_URL.Location = new System.Drawing.Point(6, 18);
            this.tbWebUI_URL.Name = "tbWebUI_URL";
            this.tbWebUI_URL.Size = new System.Drawing.Size(276, 21);
            this.tbWebUI_URL.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(245, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbShowBalloonTips
            // 
            this.cbShowBalloonTips.AutoSize = true;
            this.cbShowBalloonTips.Location = new System.Drawing.Point(111, 18);
            this.cbShowBalloonTips.Name = "cbShowBalloonTips";
            this.cbShowBalloonTips.Size = new System.Drawing.Size(126, 16);
            this.cbShowBalloonTips.TabIndex = 3;
            this.cbShowBalloonTips.Text = "Show Balloon Tips";
            this.cbShowBalloonTips.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCheckForUpdates);
            this.groupBox4.Controls.Add(this.cbShowBalloonTips);
            this.groupBox4.Controls.Add(this.cbRunOnStartup);
            this.groupBox4.Location = new System.Drawing.Point(6, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 66);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Windows";
            // 
            // cbCheckForUpdates
            // 
            this.cbCheckForUpdates.AutoSize = true;
            this.cbCheckForUpdates.Location = new System.Drawing.Point(9, 42);
            this.cbCheckForUpdates.Name = "cbCheckForUpdates";
            this.cbCheckForUpdates.Size = new System.Drawing.Size(126, 16);
            this.cbCheckForUpdates.TabIndex = 4;
            this.cbCheckForUpdates.Text = "Check for updates";
            this.cbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // cbRunOnStartup
            // 
            this.cbRunOnStartup.AutoSize = true;
            this.cbRunOnStartup.Location = new System.Drawing.Point(9, 18);
            this.cbRunOnStartup.Name = "cbRunOnStartup";
            this.cbRunOnStartup.Size = new System.Drawing.Size(108, 16);
            this.cbRunOnStartup.TabIndex = 0;
            this.cbRunOnStartup.Text = "Run on startup";
            this.cbRunOnStartup.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpGeneral);
            this.tabControl1.Controls.Add(this.tpTwitter);
            this.tabControl1.Controls.Add(this.tpBoxcar);
            this.tabControl1.Controls.Add(this.tpNotifications);
            this.tabControl1.Controls.Add(this.tbAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(308, 247);
            this.tabControl1.TabIndex = 7;
            // 
            // tpGeneral
            // 
            this.tpGeneral.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpGeneral.Controls.Add(this.groupBox2);
            this.tpGeneral.Controls.Add(this.groupBox1);
            this.tpGeneral.Controls.Add(this.groupBox4);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(300, 221);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // tpTwitter
            // 
            this.tpTwitter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpTwitter.Controls.Add(this.btnSendTestTweet);
            this.tpTwitter.Controls.Add(this.groupBox9);
            this.tpTwitter.Controls.Add(this.groupBox8);
            this.tpTwitter.Location = new System.Drawing.Point(4, 22);
            this.tpTwitter.Name = "tpTwitter";
            this.tpTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tpTwitter.Size = new System.Drawing.Size(300, 221);
            this.tpTwitter.TabIndex = 5;
            this.tpTwitter.Text = "Twitter";
            this.tpTwitter.UseVisualStyleBackColor = true;
            // 
            // btnSendTestTweet
            // 
            this.btnSendTestTweet.Location = new System.Drawing.Point(168, 190);
            this.btnSendTestTweet.Name = "btnSendTestTweet";
            this.btnSendTestTweet.Size = new System.Drawing.Size(125, 21);
            this.btnSendTestTweet.TabIndex = 8;
            this.btnSendTestTweet.Text = "Send test Tweet";
            this.btnSendTestTweet.UseVisualStyleBackColor = true;
            this.btnSendTestTweet.Click += new System.EventHandler(this.btnSendTestTweet_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbTwitterPrefixTweet);
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.cbTwitterEnable);
            this.groupBox9.Location = new System.Drawing.Point(6, 138);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(288, 46);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Settings";
            // 
            // tbTwitterPrefixTweet
            // 
            this.tbTwitterPrefixTweet.Location = new System.Drawing.Point(181, 16);
            this.tbTwitterPrefixTweet.MaxLength = 75;
            this.tbTwitterPrefixTweet.Name = "tbTwitterPrefixTweet";
            this.tbTwitterPrefixTweet.Size = new System.Drawing.Size(100, 21);
            this.tbTwitterPrefixTweet.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(93, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prefix tweet with:";
            // 
            // cbTwitterEnable
            // 
            this.cbTwitterEnable.AutoSize = true;
            this.cbTwitterEnable.Location = new System.Drawing.Point(9, 18);
            this.cbTwitterEnable.Name = "cbTwitterEnable";
            this.cbTwitterEnable.Size = new System.Drawing.Size(60, 16);
            this.cbTwitterEnable.TabIndex = 1;
            this.cbTwitterEnable.Text = "Enable";
            this.cbTwitterEnable.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.btnTwitterAuthorize);
            this.groupBox8.Controls.Add(this.btnStartAuthorization);
            this.groupBox8.Controls.Add(this.tbTwitterPIN);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.lblTwitterPIN);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(288, 128);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Authorization";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Like any Twitter client, uTorrent Notifier must be authorized to send tweets if y" +
    "ou wish to use this feature.";
            // 
            // btnTwitterAuthorize
            // 
            this.btnTwitterAuthorize.Enabled = false;
            this.btnTwitterAuthorize.Location = new System.Drawing.Point(127, 93);
            this.btnTwitterAuthorize.Name = "btnTwitterAuthorize";
            this.btnTwitterAuthorize.Size = new System.Drawing.Size(75, 21);
            this.btnTwitterAuthorize.TabIndex = 6;
            this.btnTwitterAuthorize.Text = "Authorize";
            this.btnTwitterAuthorize.UseVisualStyleBackColor = true;
            this.btnTwitterAuthorize.Click += new System.EventHandler(this.btnTwitterAuthorize_Click);
            // 
            // btnStartAuthorization
            // 
            this.btnStartAuthorization.Location = new System.Drawing.Point(6, 54);
            this.btnStartAuthorization.Name = "btnStartAuthorization";
            this.btnStartAuthorization.Size = new System.Drawing.Size(128, 21);
            this.btnStartAuthorization.TabIndex = 5;
            this.btnStartAuthorization.Text = "Start authorization";
            this.btnStartAuthorization.UseVisualStyleBackColor = true;
            this.btnStartAuthorization.Click += new System.EventHandler(this.btnStartAuthorization_Click);
            // 
            // tbTwitterPIN
            // 
            this.tbTwitterPIN.Enabled = false;
            this.tbTwitterPIN.Location = new System.Drawing.Point(34, 95);
            this.tbTwitterPIN.Name = "tbTwitterPIN";
            this.tbTwitterPIN.Size = new System.Drawing.Size(87, 21);
            this.tbTwitterPIN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 1;
            // 
            // lblTwitterPIN
            // 
            this.lblTwitterPIN.AutoSize = true;
            this.lblTwitterPIN.Location = new System.Drawing.Point(6, 98);
            this.lblTwitterPIN.Name = "lblTwitterPIN";
            this.lblTwitterPIN.Size = new System.Drawing.Size(23, 12);
            this.lblTwitterPIN.TabIndex = 0;
            this.lblTwitterPIN.Text = "PIN";
            // 
            // tpBoxcar
            // 
            this.tpBoxcar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpBoxcar.Controls.Add(this.groupBox10);
            this.tpBoxcar.Location = new System.Drawing.Point(4, 22);
            this.tpBoxcar.Name = "tpBoxcar";
            this.tpBoxcar.Size = new System.Drawing.Size(300, 221);
            this.tpBoxcar.TabIndex = 5;
            this.tpBoxcar.Text = "Boxcar";
            this.tpBoxcar.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnBoxcarGetAPIKey);
            this.groupBox10.Controls.Add(this.tbBoxcarAPIKey);
            this.groupBox10.Controls.Add(this.lblBoxcarAPIKey);
            this.groupBox10.Controls.Add(this.tbBoxcarEmail);
            this.groupBox10.Controls.Add(this.lblBoxcarEmail);
            this.groupBox10.Controls.Add(this.cbBoxcarEnable);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(288, 122);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Settings";
            // 
            // btnBoxcarGetAPIKey
            // 
            this.btnBoxcarGetAPIKey.Location = new System.Drawing.Point(162, 95);
            this.btnBoxcarGetAPIKey.Name = "btnBoxcarGetAPIKey";
            this.btnBoxcarGetAPIKey.Size = new System.Drawing.Size(75, 21);
            this.btnBoxcarGetAPIKey.TabIndex = 5;
            this.btnBoxcarGetAPIKey.Text = "Get API Key";
            this.btnBoxcarGetAPIKey.UseVisualStyleBackColor = true;
            this.btnBoxcarGetAPIKey.Click += new System.EventHandler(this.btnBoxcarGetAPIKey_Click);
            // 
            // tbBoxcarAPIKey
            // 
            this.tbBoxcarAPIKey.Location = new System.Drawing.Point(58, 71);
            this.tbBoxcarAPIKey.Name = "tbBoxcarAPIKey";
            this.tbBoxcarAPIKey.Size = new System.Drawing.Size(179, 21);
            this.tbBoxcarAPIKey.TabIndex = 4;
            // 
            // lblBoxcarAPIKey
            // 
            this.lblBoxcarAPIKey.AutoSize = true;
            this.lblBoxcarAPIKey.Location = new System.Drawing.Point(7, 74);
            this.lblBoxcarAPIKey.Name = "lblBoxcarAPIKey";
            this.lblBoxcarAPIKey.Size = new System.Drawing.Size(47, 12);
            this.lblBoxcarAPIKey.TabIndex = 3;
            this.lblBoxcarAPIKey.Text = "API Key";
            // 
            // tbBoxcarEmail
            // 
            this.tbBoxcarEmail.Location = new System.Drawing.Point(58, 41);
            this.tbBoxcarEmail.Name = "tbBoxcarEmail";
            this.tbBoxcarEmail.Size = new System.Drawing.Size(179, 21);
            this.tbBoxcarEmail.TabIndex = 2;
            // 
            // lblBoxcarEmail
            // 
            this.lblBoxcarEmail.AutoSize = true;
            this.lblBoxcarEmail.Location = new System.Drawing.Point(7, 43);
            this.lblBoxcarEmail.Name = "lblBoxcarEmail";
            this.lblBoxcarEmail.Size = new System.Drawing.Size(35, 12);
            this.lblBoxcarEmail.TabIndex = 1;
            this.lblBoxcarEmail.Text = "Email";
            // 
            // cbBoxcarEnable
            // 
            this.cbBoxcarEnable.AutoSize = true;
            this.cbBoxcarEnable.Location = new System.Drawing.Point(9, 18);
            this.cbBoxcarEnable.Name = "cbBoxcarEnable";
            this.cbBoxcarEnable.Size = new System.Drawing.Size(60, 16);
            this.cbBoxcarEnable.TabIndex = 0;
            this.cbBoxcarEnable.Text = "Enable";
            this.cbBoxcarEnable.UseVisualStyleBackColor = true;
            // 
            // tpNotifications
            // 
            this.tpNotifications.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tpNotifications.Controls.Add(this.groupBox5);
            this.tpNotifications.Location = new System.Drawing.Point(4, 22);
            this.tpNotifications.Name = "tpNotifications";
            this.tpNotifications.Size = new System.Drawing.Size(300, 221);
            this.tpNotifications.TabIndex = 2;
            this.tpNotifications.Text = "Notifications";
            this.tpNotifications.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbProwlNotification_TorentAdded);
            this.groupBox5.Controls.Add(this.cbTorrentNotification_DownloadComplete);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 66);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Settings";
            // 
            // cbProwlNotification_TorentAdded
            // 
            this.cbProwlNotification_TorentAdded.AutoSize = true;
            this.cbProwlNotification_TorentAdded.Location = new System.Drawing.Point(9, 18);
            this.cbProwlNotification_TorentAdded.Name = "cbProwlNotification_TorentAdded";
            this.cbProwlNotification_TorentAdded.Size = new System.Drawing.Size(102, 16);
            this.cbProwlNotification_TorentAdded.TabIndex = 4;
            this.cbProwlNotification_TorentAdded.Text = "Torrent Added";
            this.cbProwlNotification_TorentAdded.UseVisualStyleBackColor = true;
            // 
            // cbTorrentNotification_DownloadComplete
            // 
            this.cbTorrentNotification_DownloadComplete.AutoSize = true;
            this.cbTorrentNotification_DownloadComplete.Location = new System.Drawing.Point(9, 40);
            this.cbTorrentNotification_DownloadComplete.Name = "cbTorrentNotification_DownloadComplete";
            this.cbTorrentNotification_DownloadComplete.Size = new System.Drawing.Size(126, 16);
            this.cbTorrentNotification_DownloadComplete.TabIndex = 5;
            this.cbTorrentNotification_DownloadComplete.Text = "Download Complete";
            this.cbTorrentNotification_DownloadComplete.UseVisualStyleBackColor = true;
            // 
            // tbAbout
            // 
            this.tbAbout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAbout.Controls.Add(this.richTextBox1);
            this.tbAbout.Controls.Add(this.linkLabel1);
            this.tbAbout.Controls.Add(this.lblVersion);
            this.tbAbout.Controls.Add(this.label2);
            this.tbAbout.Location = new System.Drawing.Point(4, 22);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.Size = new System.Drawing.Size(300, 221);
            this.tbAbout.TabIndex = 3;
            this.tbAbout.Text = "About";
            this.tbAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(17, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(267, 130);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Special Thanks:\nGrowl notifications by Ryan Farley\nhttp://ryanfarley.com/\n\nTwitte" +
    "r notifications by Dave Nicoll\nhttp://davenicoll.com/";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(14, 197);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Eric Holmes";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(14, 32);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(41, 12);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "vx.x.x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "uTorrent Notifier";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 295);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::uTorrentNotifier.Properties.Resources.un_icon;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "uTorrent Notifier";
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpTwitter.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tpBoxcar.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.tpNotifications.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tbAbout.ResumeLayout(false);
            this.tbAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbWebUI_URL;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbShowBalloonTips;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbRunOnStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbTorrentNotification_DownloadComplete;
        private System.Windows.Forms.CheckBox cbProwlNotification_TorentAdded;
        private System.Windows.Forms.TabPage tpNotifications;
        private System.Windows.Forms.TabPage tbAbout;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCheckForUpdates;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tpTwitter;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbTwitterPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTwitterPIN;
        private System.Windows.Forms.Button btnStartAuthorization;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox cbTwitterEnable;
        private System.Windows.Forms.Button btnTwitterAuthorize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendTestTweet;
        private System.Windows.Forms.TabPage tpBoxcar;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox tbBoxcarEmail;
        private System.Windows.Forms.Label lblBoxcarEmail;
        private System.Windows.Forms.CheckBox cbBoxcarEnable;
        private System.Windows.Forms.Button btnBoxcarGetAPIKey;
        private System.Windows.Forms.TextBox tbBoxcarAPIKey;
        private System.Windows.Forms.Label lblBoxcarAPIKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTwitterPrefixTweet;

    }
}