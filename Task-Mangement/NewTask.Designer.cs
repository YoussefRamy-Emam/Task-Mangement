namespace Task_Mangement
{
    partial class NewTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPersonalBadge = new System.Windows.Forms.Button();
            this.lblnewtask = new System.Windows.Forms.Label();
            this.pnlNotice = new System.Windows.Forms.Panel();
            this.lblnotice = new System.Windows.Forms.Label();
            this.lbltittle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbldescripition = new System.Windows.Forms.Label();
            this.txtdescripition = new System.Windows.Forms.TextBox();
            this.lblpriority = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lbldeadline = new System.Windows.Forms.Label();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.chkRemind = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnlow = new System.Windows.Forms.Button();
            this.btnmedium = new System.Windows.Forms.Button();
            this.btnhigh = new System.Windows.Forms.Button();
            this.btnurgent = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnlNotice.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblPersonalBadge);
            this.panel1.Controls.Add(this.lblnewtask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 83);
            this.panel1.TabIndex = 0;
            // 
            // lblPersonalBadge
            // 
            this.lblPersonalBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblPersonalBadge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonalBadge.ForeColor = System.Drawing.Color.White;
            this.lblPersonalBadge.Location = new System.Drawing.Point(655, 33);
            this.lblPersonalBadge.Name = "lblPersonalBadge";
            this.lblPersonalBadge.Size = new System.Drawing.Size(80, 26);
            this.lblPersonalBadge.TabIndex = 1;
            this.lblPersonalBadge.Text = "Personal";
            this.lblPersonalBadge.UseVisualStyleBackColor = false;
            this.lblPersonalBadge.Click += new System.EventHandler(this.lblPersonalBadge_Click);
            // 
            // lblnewtask
            // 
            this.lblnewtask.AutoSize = true;
            this.lblnewtask.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblnewtask.ForeColor = System.Drawing.Color.White;
            this.lblnewtask.Location = new System.Drawing.Point(35, 27);
            this.lblnewtask.Name = "lblnewtask";
            this.lblnewtask.Size = new System.Drawing.Size(121, 32);
            this.lblnewtask.TabIndex = 0;
            this.lblnewtask.Text = "New Task";
            this.lblnewtask.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlNotice
            // 
            this.pnlNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotice.Controls.Add(this.lblnotice);
            this.pnlNotice.Location = new System.Drawing.Point(41, 111);
            this.pnlNotice.Name = "pnlNotice";
            this.pnlNotice.Size = new System.Drawing.Size(694, 60);
            this.pnlNotice.TabIndex = 1;
            // 
            // lblnotice
            // 
            this.lblnotice.AutoSize = true;
            this.lblnotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.lblnotice.Location = new System.Drawing.Point(3, 18);
            this.lblnotice.Name = "lblnotice";
            this.lblnotice.Size = new System.Drawing.Size(576, 20);
            this.lblnotice.TabIndex = 0;
            this.lblnotice.Text = "Personal tasks are private. Only you can see them, and they are not part of any p" +
    "roject.";
            this.lblnotice.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbltittle
            // 
            this.lbltittle.AutoSize = true;
            this.lbltittle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbltittle.Location = new System.Drawing.Point(37, 188);
            this.lbltittle.Name = "lbltittle";
            this.lbltittle.Size = new System.Drawing.Size(48, 23);
            this.lbltittle.TabIndex = 2;
            this.lbltittle.Text = "Tittle";
            this.lbltittle.Click += new System.EventHandler(this.lbltittle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTitle.Location = new System.Drawing.Point(41, 214);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(694, 34);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Text = "Review lecture notes";
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lbldescripition
            // 
            this.lbldescripition.AutoSize = true;
            this.lbldescripition.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lbldescripition.Location = new System.Drawing.Point(36, 262);
            this.lbldescripition.Name = "lbldescripition";
            this.lbldescripition.Size = new System.Drawing.Size(102, 25);
            this.lbldescripition.TabIndex = 4;
            this.lbldescripition.Text = "Description";
            this.lbldescripition.Click += new System.EventHandler(this.lbldescripition_Click);
            // 
            // txtdescripition
            // 
            this.txtdescripition.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripition.Location = new System.Drawing.Point(41, 288);
            this.txtdescripition.Multiline = true;
            this.txtdescripition.Name = "txtdescripition";
            this.txtdescripition.Size = new System.Drawing.Size(694, 89);
            this.txtdescripition.TabIndex = 5;
            this.txtdescripition.Text = "Chapters 4 and 5 before the quiz";
            // 
            // lblpriority
            // 
            this.lblpriority.AutoSize = true;
            this.lblpriority.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpriority.Location = new System.Drawing.Point(37, 391);
            this.lblpriority.Name = "lblpriority";
            this.lblpriority.Size = new System.Drawing.Size(70, 23);
            this.lblpriority.TabIndex = 6;
            this.lblpriority.Text = "Priority";
            this.lblpriority.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(36, 487);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(60, 25);
            this.lblstatus.TabIndex = 11;
            this.lblstatus.Text = "Status";
            // 
            // lbldeadline
            // 
            this.lbldeadline.AutoSize = true;
            this.lbldeadline.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeadline.Location = new System.Drawing.Point(391, 487);
            this.lbldeadline.Name = "lbldeadline";
            this.lbldeadline.Size = new System.Drawing.Size(81, 25);
            this.lbldeadline.TabIndex = 13;
            this.lbldeadline.Text = "Deadline";
            this.lbldeadline.Click += new System.EventHandler(this.lbldeadline_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Location = new System.Drawing.Point(396, 515);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(338, 34);
            this.dtpDeadline.TabIndex = 14;
            // 
            // chkRemind
            // 
            this.chkRemind.AutoSize = true;
            this.chkRemind.Checked = true;
            this.chkRemind.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemind.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemind.Location = new System.Drawing.Point(41, 588);
            this.chkRemind.Name = "chkRemind";
            this.chkRemind.Size = new System.Drawing.Size(331, 24);
            this.chkRemind.TabIndex = 15;
            this.chkRemind.Text = "Remind me in the system tray one day before";
            this.chkRemind.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(475, 635);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 43);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(615, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(2);
            this.btnSave.Size = new System.Drawing.Size(140, 43);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnurgent, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnhigh, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnmedium, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnlow, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 418);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 52);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // btnlow
            // 
            this.btnlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlow.Location = new System.Drawing.Point(0, 0);
            this.btnlow.Margin = new System.Windows.Forms.Padding(0);
            this.btnlow.Name = "btnlow";
            this.btnlow.Size = new System.Drawing.Size(173, 52);
            this.btnlow.TabIndex = 8;
            this.btnlow.Text = "Low";
            this.btnlow.UseVisualStyleBackColor = true;
            // 
            // btnmedium
            // 
            this.btnmedium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmedium.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnmedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmedium.ForeColor = System.Drawing.Color.Black;
            this.btnmedium.Location = new System.Drawing.Point(173, 0);
            this.btnmedium.Margin = new System.Windows.Forms.Padding(0);
            this.btnmedium.Name = "btnmedium";
            this.btnmedium.Size = new System.Drawing.Size(173, 52);
            this.btnmedium.TabIndex = 9;
            this.btnmedium.Text = "Medium";
            this.btnmedium.UseVisualStyleBackColor = false;
            // 
            // btnhigh
            // 
            this.btnhigh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhigh.Location = new System.Drawing.Point(346, 0);
            this.btnhigh.Margin = new System.Windows.Forms.Padding(0);
            this.btnhigh.Name = "btnhigh";
            this.btnhigh.Size = new System.Drawing.Size(173, 52);
            this.btnhigh.TabIndex = 10;
            this.btnhigh.Text = "High";
            this.btnhigh.UseVisualStyleBackColor = true;
            // 
            // btnurgent
            // 
            this.btnurgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnurgent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnurgent.Location = new System.Drawing.Point(519, 0);
            this.btnurgent.Margin = new System.Windows.Forms.Padding(0);
            this.btnurgent.Name = "btnurgent";
            this.btnurgent.Size = new System.Drawing.Size(174, 52);
            this.btnurgent.TabIndex = 11;
            this.btnurgent.Text = "Urgent";
            this.btnurgent.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "inprogress",
            "done"});
            this.cmbStatus.Location = new System.Drawing.Point(41, 515);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(333, 36);
            this.cmbStatus.TabIndex = 25;
            this.cmbStatus.Text = "All";
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 703);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkRemind);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.lbldeadline);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblpriority);
            this.Controls.Add(this.txtdescripition);
            this.Controls.Add(this.lbldescripition);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbltittle);
            this.Controls.Add(this.pnlNotice);
            this.Controls.Add(this.panel1);
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.Load += new System.EventHandler(this.NewTask_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNotice.ResumeLayout(false);
            this.pnlNotice.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnewtask;
        private System.Windows.Forms.Button lblPersonalBadge;
        private System.Windows.Forms.Panel pnlNotice;
        private System.Windows.Forms.Label lblnotice;
        private System.Windows.Forms.Label lbltittle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbldescripition;
        private System.Windows.Forms.TextBox txtdescripition;
        private System.Windows.Forms.Label lblpriority;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbldeadline;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.CheckBox chkRemind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnlow;
        private System.Windows.Forms.Button btnurgent;
        private System.Windows.Forms.Button btnhigh;
        private System.Windows.Forms.Button btnmedium;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}