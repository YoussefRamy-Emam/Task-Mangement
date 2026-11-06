namespace Task_Mangement
{
    partial class ProfileForm
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
            System.Windows.Forms.Panel ProfileBar;
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblNumNotif = new System.Windows.Forms.Label();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnWorkFlowBoard = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.lblTaskify = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.newProjectTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newPersonalTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plnProfile = new System.Windows.Forms.Panel();
            this.passwordCard = new System.Windows.Forms.Panel();
            this.passwordTitleLabel = new System.Windows.Forms.Label();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordMismatchIconLabel = new System.Windows.Forms.Label();
            this.passwordMismatchLabel = new System.Windows.Forms.Label();
            this.passwordHelpLabel = new System.Windows.Forms.Label();
            this.updatePasswordButton = new System.Windows.Forms.Button();
            this.accountCard = new System.Windows.Forms.Panel();
            this.accountTitleLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.pageTitleLabel = new System.Windows.Forms.Label();
            this.pageSubtitleLabel = new System.Windows.Forms.Label();
            this.summaryCard = new System.Windows.Forms.Panel();
            this.avatarLabel = new System.Windows.Forms.Label();
            this.profileNameLabel = new System.Windows.Forms.Label();
            this.profileEmailLabel = new System.Windows.Forms.Label();
            this.ownerBadgeLabel = new System.Windows.Forms.Label();
            this.summarySeparator = new System.Windows.Forms.Panel();
            this.projectsStatLabel = new System.Windows.Forms.Label();
            this.projectsStatValueLabel = new System.Windows.Forms.Label();
            this.openTasksStatLabel = new System.Windows.Forms.Label();
            this.openTasksStatValueLabel = new System.Windows.Forms.Label();
            this.completedStatLabel = new System.Windows.Forms.Label();
            this.completedStatValueLabel = new System.Windows.Forms.Label();
            ProfileBar = new System.Windows.Forms.Panel();
            ProfileBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.plnProfile.SuspendLayout();
            this.passwordCard.SuspendLayout();
            this.accountCard.SuspendLayout();
            this.summaryCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfileBar
            // 
            ProfileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            ProfileBar.Controls.Add(this.btnProfile);
            ProfileBar.Controls.Add(this.lblEmail);
            ProfileBar.Controls.Add(this.lblUserName);
            ProfileBar.Controls.Add(this.btnSignOut);
            ProfileBar.Controls.Add(this.lblNumNotif);
            ProfileBar.Controls.Add(this.btnNotifications);
            ProfileBar.Controls.Add(this.btnWorkFlowBoard);
            ProfileBar.Controls.Add(this.btnProjects);
            ProfileBar.Controls.Add(this.lblTaskify);
            ProfileBar.Controls.Add(this.btnNavDashboard);
            ProfileBar.Dock = System.Windows.Forms.DockStyle.Left;
            ProfileBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            ProfileBar.Location = new System.Drawing.Point(0, 0);
            ProfileBar.Margin = new System.Windows.Forms.Padding(0);
            ProfileBar.Name = "ProfileBar";
            ProfileBar.Size = new System.Drawing.Size(256, 753);
            ProfileBar.TabIndex = 2;
            ProfileBar.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfileBar_Paint);
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSize = true;
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(15, 201);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(2);
            this.btnProfile.Size = new System.Drawing.Size(231, 35);
            this.btnProfile.TabIndex = 13;
            this.btnProfile.Text = "●  Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(11, 658);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(163, 23);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Yousef@Gmail.com";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(11, 628);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "El3amed";
            // 
            // btnSignOut
            // 
            this.btnSignOut.AutoSize = true;
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(11, 694);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(2);
            this.btnSignOut.Size = new System.Drawing.Size(231, 35);
            this.btnSignOut.TabIndex = 11;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // lblNumNotif
            // 
            this.lblNumNotif.BackColor = System.Drawing.Color.Red;
            this.lblNumNotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNumNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumNotif.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumNotif.ForeColor = System.Drawing.Color.White;
            this.lblNumNotif.Location = new System.Drawing.Point(211, 246);
            this.lblNumNotif.Name = "lblNumNotif";
            this.lblNumNotif.Size = new System.Drawing.Size(24, 24);
            this.lblNumNotif.TabIndex = 2;
            this.lblNumNotif.Text = "3";
            this.lblNumNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNotifications
            // 
            this.btnNotifications.AutoSize = true;
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(12, 242);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Padding = new System.Windows.Forms.Padding(2);
            this.btnNotifications.Size = new System.Drawing.Size(231, 35);
            this.btnNotifications.TabIndex = 10;
            this.btnNotifications.Text = "●  Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.UseVisualStyleBackColor = false;
            // 
            // btnWorkFlowBoard
            // 
            this.btnWorkFlowBoard.AutoSize = true;
            this.btnWorkFlowBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnWorkFlowBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWorkFlowBoard.FlatAppearance.BorderSize = 0;
            this.btnWorkFlowBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkFlowBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkFlowBoard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnWorkFlowBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkFlowBoard.Location = new System.Drawing.Point(12, 160);
            this.btnWorkFlowBoard.Name = "btnWorkFlowBoard";
            this.btnWorkFlowBoard.Padding = new System.Windows.Forms.Padding(2);
            this.btnWorkFlowBoard.Size = new System.Drawing.Size(231, 35);
            this.btnWorkFlowBoard.TabIndex = 8;
            this.btnWorkFlowBoard.Text = "●  WorkFlow Board";
            this.btnWorkFlowBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkFlowBoard.UseVisualStyleBackColor = false;
            // 
            // btnProjects
            // 
            this.btnProjects.AutoSize = true;
            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.Location = new System.Drawing.Point(12, 119);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Padding = new System.Windows.Forms.Padding(2);
            this.btnProjects.Size = new System.Drawing.Size(231, 35);
            this.btnProjects.TabIndex = 7;
            this.btnProjects.Text = "●  Projects";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.UseVisualStyleBackColor = false;
            // 
            // lblTaskify
            // 
            this.lblTaskify.AutoSize = true;
            this.lblTaskify.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskify.ForeColor = System.Drawing.Color.White;
            this.lblTaskify.Location = new System.Drawing.Point(35, 9);
            this.lblTaskify.Name = "lblTaskify";
            this.lblTaskify.Size = new System.Drawing.Size(154, 54);
            this.lblTaskify.TabIndex = 0;
            this.lblTaskify.Text = "Taskify";
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.AutoSize = true;
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnNavDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnNavDashboard.FlatAppearance.BorderSize = 3;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.Location = new System.Drawing.Point(12, 78);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(2);
            this.btnNavDashboard.Size = new System.Drawing.Size(231, 37);
            this.btnNavDashboard.TabIndex = 6;
            this.btnNavDashboard.Text = "●  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // newProjectTaskToolStripMenuItem
            // 
            this.newProjectTaskToolStripMenuItem.Name = "newProjectTaskToolStripMenuItem";
            this.newProjectTaskToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.newProjectTaskToolStripMenuItem.Text = "New Project Task";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPersonalTaskToolStripMenuItem,
            this.newProjectTaskToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 52);
            // 
            // newPersonalTaskToolStripMenuItem
            // 
            this.newPersonalTaskToolStripMenuItem.Name = "newPersonalTaskToolStripMenuItem";
            this.newPersonalTaskToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.newPersonalTaskToolStripMenuItem.Text = "New Personal Task";
            // 
            // plnProfile
            // 
            this.plnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plnProfile.Controls.Add(this.passwordCard);
            this.plnProfile.Controls.Add(this.accountCard);
            this.plnProfile.Controls.Add(this.pageTitleLabel);
            this.plnProfile.Controls.Add(this.pageSubtitleLabel);
            this.plnProfile.Controls.Add(this.summaryCard);
            this.plnProfile.Location = new System.Drawing.Point(261, -4);
            this.plnProfile.Name = "plnProfile";
            this.plnProfile.Size = new System.Drawing.Size(1122, 760);
            this.plnProfile.TabIndex = 3;
            // 
            // passwordCard
            // 
            this.passwordCard.BackColor = System.Drawing.Color.White;
            this.passwordCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordCard.Controls.Add(this.passwordTitleLabel);
            this.passwordCard.Controls.Add(this.currentPasswordLabel);
            this.passwordCard.Controls.Add(this.currentPasswordTextBox);
            this.passwordCard.Controls.Add(this.newPasswordLabel);
            this.passwordCard.Controls.Add(this.newPasswordTextBox);
            this.passwordCard.Controls.Add(this.confirmPasswordLabel);
            this.passwordCard.Controls.Add(this.confirmPasswordTextBox);
            this.passwordCard.Controls.Add(this.passwordMismatchIconLabel);
            this.passwordCard.Controls.Add(this.passwordMismatchLabel);
            this.passwordCard.Controls.Add(this.passwordHelpLabel);
            this.passwordCard.Controls.Add(this.updatePasswordButton);
            this.passwordCard.Location = new System.Drawing.Point(392, 461);
            this.passwordCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordCard.Name = "passwordCard";
            this.passwordCard.Size = new System.Drawing.Size(702, 412);
            this.passwordCard.TabIndex = 7;
            // 
            // passwordTitleLabel
            // 
            this.passwordTitleLabel.AutoSize = true;
            this.passwordTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.passwordTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.passwordTitleLabel.Location = new System.Drawing.Point(25, 23);
            this.passwordTitleLabel.Name = "passwordTitleLabel";
            this.passwordTitleLabel.Size = new System.Drawing.Size(177, 28);
            this.passwordTitleLabel.TabIndex = 0;
            this.passwordTitleLabel.Text = "Change password";
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.currentPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.currentPasswordLabel.Location = new System.Drawing.Point(25, 68);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(124, 20);
            this.currentPasswordLabel.TabIndex = 1;
            this.currentPasswordLabel.Text = "Current password";
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.currentPasswordTextBox.Location = new System.Drawing.Point(25, 92);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.PasswordChar = '●';
            this.currentPasswordTextBox.Size = new System.Drawing.Size(644, 30);
            this.currentPasswordTextBox.TabIndex = 2;
            this.currentPasswordTextBox.Text = "Current123";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(25, 167);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(106, 20);
            this.newPasswordLabel.TabIndex = 3;
            this.newPasswordLabel.Text = "New password";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.newPasswordTextBox.Location = new System.Drawing.Point(25, 191);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '●';
            this.newPasswordTextBox.Size = new System.Drawing.Size(317, 30);
            this.newPasswordTextBox.TabIndex = 4;
            this.newPasswordTextBox.Text = "Newpass123";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(391, 167);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(160, 20);
            this.confirmPasswordLabel.TabIndex = 5;
            this.confirmPasswordLabel.Text = "Confirm new password";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(391, 191);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '●';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(278, 30);
            this.confirmPasswordTextBox.TabIndex = 6;
            this.confirmPasswordTextBox.Text = "Different123";
            // 
            // passwordMismatchIconLabel
            // 
            this.passwordMismatchIconLabel.AutoSize = true;
            this.passwordMismatchIconLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.passwordMismatchIconLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.passwordMismatchIconLabel.Location = new System.Drawing.Point(391, 241);
            this.passwordMismatchIconLabel.Name = "passwordMismatchIconLabel";
            this.passwordMismatchIconLabel.Size = new System.Drawing.Size(18, 20);
            this.passwordMismatchIconLabel.TabIndex = 7;
            this.passwordMismatchIconLabel.Text = "●";
            // 
            // passwordMismatchLabel
            // 
            this.passwordMismatchLabel.AutoSize = true;
            this.passwordMismatchLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.passwordMismatchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.passwordMismatchLabel.Location = new System.Drawing.Point(410, 243);
            this.passwordMismatchLabel.Name = "passwordMismatchLabel";
            this.passwordMismatchLabel.Size = new System.Drawing.Size(181, 20);
            this.passwordMismatchLabel.TabIndex = 8;
            this.passwordMismatchLabel.Text = "Passwords do not match";
            // 
            // passwordHelpLabel
            // 
            this.passwordHelpLabel.AutoSize = true;
            this.passwordHelpLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordHelpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.passwordHelpLabel.Location = new System.Drawing.Point(25, 296);
            this.passwordHelpLabel.Name = "passwordHelpLabel";
            this.passwordHelpLabel.Size = new System.Drawing.Size(353, 20);
            this.passwordHelpLabel.TabIndex = 9;
            this.passwordHelpLabel.Text = "Use at least 8 characters, with a letter and a number.";
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.updatePasswordButton.FlatAppearance.BorderSize = 0;
            this.updatePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePasswordButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.updatePasswordButton.ForeColor = System.Drawing.Color.White;
            this.updatePasswordButton.Location = new System.Drawing.Point(486, 334);
            this.updatePasswordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(183, 53);
            this.updatePasswordButton.TabIndex = 10;
            this.updatePasswordButton.Text = "Update password";
            this.updatePasswordButton.UseVisualStyleBackColor = false;
            // 
            // accountCard
            // 
            this.accountCard.BackColor = System.Drawing.Color.White;
            this.accountCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountCard.Controls.Add(this.accountTitleLabel);
            this.accountCard.Controls.Add(this.fullNameLabel);
            this.accountCard.Controls.Add(this.fullNameTextBox);
            this.accountCard.Controls.Add(this.usernameLabel);
            this.accountCard.Controls.Add(this.usernameTextBox);
            this.accountCard.Controls.Add(this.emailLabel);
            this.accountCard.Controls.Add(this.emailTextBox);
            this.accountCard.Controls.Add(this.saveChangesButton);
            this.accountCard.Location = new System.Drawing.Point(392, 123);
            this.accountCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accountCard.Name = "accountCard";
            this.accountCard.Size = new System.Drawing.Size(703, 321);
            this.accountCard.TabIndex = 6;
            // 
            // accountTitleLabel
            // 
            this.accountTitleLabel.AutoSize = true;
            this.accountTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.accountTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.accountTitleLabel.Location = new System.Drawing.Point(25, 23);
            this.accountTitleLabel.Name = "accountTitleLabel";
            this.accountTitleLabel.Size = new System.Drawing.Size(159, 28);
            this.accountTitleLabel.TabIndex = 0;
            this.accountTitleLabel.Text = "Account details";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.fullNameLabel.Location = new System.Drawing.Point(25, 68);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(73, 20);
            this.fullNameLabel.TabIndex = 1;
            this.fullNameLabel.Text = "Full name";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fullNameTextBox.Location = new System.Drawing.Point(25, 92);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(657, 30);
            this.fullNameTextBox.TabIndex = 2;
            this.fullNameTextBox.Text = "Yousef Ramy";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.usernameLabel.Location = new System.Drawing.Point(25, 168);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 20);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usernameTextBox.Location = new System.Drawing.Point(25, 192);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(316, 30);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.Text = "yousef";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.emailLabel.Location = new System.Drawing.Point(391, 168);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 20);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailTextBox.Location = new System.Drawing.Point(391, 192);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(291, 30);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.Text = "yousef@example.com";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.saveChangesButton.FlatAppearance.BorderSize = 0;
            this.saveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.saveChangesButton.ForeColor = System.Drawing.Color.White;
            this.saveChangesButton.Location = new System.Drawing.Point(522, 238);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(160, 53);
            this.saveChangesButton.TabIndex = 7;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            // 
            // pageTitleLabel
            // 
            this.pageTitleLabel.AutoSize = true;
            this.pageTitleLabel.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.pageTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pageTitleLabel.Location = new System.Drawing.Point(17, 20);
            this.pageTitleLabel.Name = "pageTitleLabel";
            this.pageTitleLabel.Size = new System.Drawing.Size(128, 47);
            this.pageTitleLabel.TabIndex = 4;
            this.pageTitleLabel.Text = "Profile";
            // 
            // pageSubtitleLabel
            // 
            this.pageSubtitleLabel.AutoSize = true;
            this.pageSubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pageSubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.pageSubtitleLabel.Location = new System.Drawing.Point(18, 72);
            this.pageSubtitleLabel.Name = "pageSubtitleLabel";
            this.pageSubtitleLabel.Size = new System.Drawing.Size(341, 23);
            this.pageSubtitleLabel.TabIndex = 5;
            this.pageSubtitleLabel.Text = "Manage your account details and password";
            // 
            // summaryCard
            // 
            this.summaryCard.BackColor = System.Drawing.Color.White;
            this.summaryCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summaryCard.Controls.Add(this.avatarLabel);
            this.summaryCard.Controls.Add(this.profileNameLabel);
            this.summaryCard.Controls.Add(this.profileEmailLabel);
            this.summaryCard.Controls.Add(this.ownerBadgeLabel);
            this.summaryCard.Controls.Add(this.summarySeparator);
            this.summaryCard.Controls.Add(this.projectsStatLabel);
            this.summaryCard.Controls.Add(this.projectsStatValueLabel);
            this.summaryCard.Controls.Add(this.openTasksStatLabel);
            this.summaryCard.Controls.Add(this.openTasksStatValueLabel);
            this.summaryCard.Controls.Add(this.completedStatLabel);
            this.summaryCard.Controls.Add(this.completedStatValueLabel);
            this.summaryCard.Location = new System.Drawing.Point(22, 123);
            this.summaryCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.summaryCard.Name = "summaryCard";
            this.summaryCard.Size = new System.Drawing.Size(343, 455);
            this.summaryCard.TabIndex = 3;
            // 
            // avatarLabel
            // 
            this.avatarLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.avatarLabel.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
            this.avatarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(83)))), ((int)(((byte)(183)))));
            this.avatarLabel.Location = new System.Drawing.Point(120, 40);
            this.avatarLabel.Name = "avatarLabel";
            this.avatarLabel.Size = new System.Drawing.Size(101, 109);
            this.avatarLabel.TabIndex = 0;
            this.avatarLabel.Text = "Y";
            this.avatarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileNameLabel
            // 
            this.profileNameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.profileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.profileNameLabel.Location = new System.Drawing.Point(23, 173);
            this.profileNameLabel.Name = "profileNameLabel";
            this.profileNameLabel.Size = new System.Drawing.Size(295, 33);
            this.profileNameLabel.TabIndex = 1;
            this.profileNameLabel.Text = "Yousef Ramy";
            this.profileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileEmailLabel
            // 
            this.profileEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.profileEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.profileEmailLabel.Location = new System.Drawing.Point(23, 209);
            this.profileEmailLabel.Name = "profileEmailLabel";
            this.profileEmailLabel.Size = new System.Drawing.Size(295, 29);
            this.profileEmailLabel.TabIndex = 2;
            this.profileEmailLabel.Text = "yousef@example.com";
            this.profileEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ownerBadgeLabel
            // 
            this.ownerBadgeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.ownerBadgeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ownerBadgeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.ownerBadgeLabel.Location = new System.Drawing.Point(127, 243);
            this.ownerBadgeLabel.Name = "ownerBadgeLabel";
            this.ownerBadgeLabel.Size = new System.Drawing.Size(87, 29);
            this.ownerBadgeLabel.TabIndex = 3;
            this.ownerBadgeLabel.Text = "Owner";
            this.ownerBadgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // summarySeparator
            // 
            this.summarySeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.summarySeparator.Location = new System.Drawing.Point(23, 293);
            this.summarySeparator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.summarySeparator.Name = "summarySeparator";
            this.summarySeparator.Size = new System.Drawing.Size(295, 1);
            this.summarySeparator.TabIndex = 4;
            // 
            // projectsStatLabel
            // 
            this.projectsStatLabel.AutoSize = true;
            this.projectsStatLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.projectsStatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.projectsStatLabel.Location = new System.Drawing.Point(23, 324);
            this.projectsStatLabel.Name = "projectsStatLabel";
            this.projectsStatLabel.Size = new System.Drawing.Size(70, 23);
            this.projectsStatLabel.TabIndex = 5;
            this.projectsStatLabel.Text = "Projects";
            // 
            // projectsStatValueLabel
            // 
            this.projectsStatValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.projectsStatValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.projectsStatValueLabel.Location = new System.Drawing.Point(269, 324);
            this.projectsStatValueLabel.Name = "projectsStatValueLabel";
            this.projectsStatValueLabel.Size = new System.Drawing.Size(48, 25);
            this.projectsStatValueLabel.TabIndex = 6;
            this.projectsStatValueLabel.Text = "3";
            this.projectsStatValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openTasksStatLabel
            // 
            this.openTasksStatLabel.AutoSize = true;
            this.openTasksStatLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.openTasksStatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.openTasksStatLabel.Location = new System.Drawing.Point(23, 364);
            this.openTasksStatLabel.Name = "openTasksStatLabel";
            this.openTasksStatLabel.Size = new System.Drawing.Size(94, 23);
            this.openTasksStatLabel.TabIndex = 7;
            this.openTasksStatLabel.Text = "Open tasks";
            // 
            // openTasksStatValueLabel
            // 
            this.openTasksStatValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.openTasksStatValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.openTasksStatValueLabel.Location = new System.Drawing.Point(269, 364);
            this.openTasksStatValueLabel.Name = "openTasksStatValueLabel";
            this.openTasksStatValueLabel.Size = new System.Drawing.Size(48, 25);
            this.openTasksStatValueLabel.TabIndex = 8;
            this.openTasksStatValueLabel.Text = "6";
            this.openTasksStatValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // completedStatLabel
            // 
            this.completedStatLabel.AutoSize = true;
            this.completedStatLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.completedStatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this.completedStatLabel.Location = new System.Drawing.Point(23, 404);
            this.completedStatLabel.Name = "completedStatLabel";
            this.completedStatLabel.Size = new System.Drawing.Size(94, 23);
            this.completedStatLabel.TabIndex = 9;
            this.completedStatLabel.Text = "Completed";
            // 
            // completedStatValueLabel
            // 
            this.completedStatValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.completedStatValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.completedStatValueLabel.Location = new System.Drawing.Point(269, 404);
            this.completedStatValueLabel.Name = "completedStatValueLabel";
            this.completedStatValueLabel.Size = new System.Drawing.Size(48, 25);
            this.completedStatValueLabel.TabIndex = 10;
            this.completedStatValueLabel.Text = "2";
            this.completedStatValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(ProfileBar);
            this.Controls.Add(this.plnProfile);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ProfileBar.ResumeLayout(false);
            ProfileBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.plnProfile.ResumeLayout(false);
            this.plnProfile.PerformLayout();
            this.passwordCard.ResumeLayout(false);
            this.passwordCard.PerformLayout();
            this.accountCard.ResumeLayout(false);
            this.accountCard.PerformLayout();
            this.summaryCard.ResumeLayout(false);
            this.summaryCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem newProjectTaskToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPersonalTaskToolStripMenuItem;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblNumNotif;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnWorkFlowBoard;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Label lblTaskify;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel plnProfile;
        private System.Windows.Forms.Panel summaryCard;
        private System.Windows.Forms.Label avatarLabel;
        private System.Windows.Forms.Label profileNameLabel;
        private System.Windows.Forms.Label profileEmailLabel;
        private System.Windows.Forms.Label ownerBadgeLabel;
        private System.Windows.Forms.Panel summarySeparator;
        private System.Windows.Forms.Label projectsStatLabel;
        private System.Windows.Forms.Label projectsStatValueLabel;
        private System.Windows.Forms.Label openTasksStatLabel;
        private System.Windows.Forms.Label openTasksStatValueLabel;
        private System.Windows.Forms.Label completedStatLabel;
        private System.Windows.Forms.Label completedStatValueLabel;
        private System.Windows.Forms.Label pageTitleLabel;
        private System.Windows.Forms.Label pageSubtitleLabel;
        private System.Windows.Forms.Panel accountCard;
        private System.Windows.Forms.Label accountTitleLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Panel passwordCard;
        private System.Windows.Forms.Label passwordTitleLabel;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label passwordMismatchIconLabel;
        private System.Windows.Forms.Label passwordMismatchLabel;
        private System.Windows.Forms.Label passwordHelpLabel;
        private System.Windows.Forms.Button updatePasswordButton;
    }
}