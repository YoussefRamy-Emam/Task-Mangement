namespace Task_Mangement
{
    partial class MainBarForm
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
            this.newProjectTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newPersonalTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblNumNotif = new System.Windows.Forms.Label();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnWorkFlowBoard = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.lblTaskify = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.plnMainBar = new System.Windows.Forms.Panel();
            this.plnMainPanel = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.plnMainBar.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
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
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AutoSize = true;
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(11, 283);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(2);
            this.btnProfile.Size = new System.Drawing.Size(231, 35);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "●  Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
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
            this.btnWorkFlowBoard.Click += new System.EventHandler(this.btnWorkFlowBoard_Click);
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
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
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
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnNavDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnNavDashboard.FlatAppearance.BorderSize = 3;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
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
            // plnMainBar
            // 
            this.plnMainBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.plnMainBar.Controls.Add(this.btnReport);
            this.plnMainBar.Controls.Add(this.lblEmail);
            this.plnMainBar.Controls.Add(this.lblUserName);
            this.plnMainBar.Controls.Add(this.btnSignOut);
            this.plnMainBar.Controls.Add(this.lblNumNotif);
            this.plnMainBar.Controls.Add(this.btnNotifications);
            this.plnMainBar.Controls.Add(this.btnProfile);
            this.plnMainBar.Controls.Add(this.btnWorkFlowBoard);
            this.plnMainBar.Controls.Add(this.btnProjects);
            this.plnMainBar.Controls.Add(this.lblTaskify);
            this.plnMainBar.Controls.Add(this.btnNavDashboard);
            this.plnMainBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.plnMainBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.plnMainBar.Location = new System.Drawing.Point(0, 0);
            this.plnMainBar.Margin = new System.Windows.Forms.Padding(0);
            this.plnMainBar.Name = "plnMainBar";
            this.plnMainBar.Size = new System.Drawing.Size(256, 753);
            this.plnMainBar.TabIndex = 2;
            // 
            // plnMainPanel
            // 
            this.plnMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plnMainPanel.Location = new System.Drawing.Point(261, -4);
            this.plnMainPanel.Name = "plnMainPanel";
            this.plnMainPanel.Size = new System.Drawing.Size(1122, 760);
            this.plnMainPanel.TabIndex = 3;
            this.plnMainPanel.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(12, 201);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(2);
            this.btnReport.Size = new System.Drawing.Size(231, 35);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "●  Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // MainBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.plnMainBar);
            this.Controls.Add(this.plnMainPanel);
            this.Name = "MainBarForm";
            this.Text = "MainBarForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.plnMainBar.ResumeLayout(false);
            this.plnMainBar.PerformLayout();
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
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnWorkFlowBoard;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Label lblTaskify;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Panel plnMainBar;
        private System.Windows.Forms.Panel plnMainPanel;
        private System.Windows.Forms.Button btnReport;
    }
}