namespace Task_Mangement
{
    partial class New_Project
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
            this.lblnewproject = new System.Windows.Forms.Label();
            this.txtdescripition = new System.Windows.Forms.TextBox();
            this.lbldescripition = new System.Windows.Forms.Label();
            this.txtprojectname = new System.Windows.Forms.TextBox();
            this.lblprojectname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btlprojectdeadline = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOwner = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblteammember = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemoveSec = new System.Windows.Forms.Button();
            this.btnRemovethird = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblnewproject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 83);
            this.panel1.TabIndex = 1;
            // 
            // lblnewproject
            // 
            this.lblnewproject.AutoSize = true;
            this.lblnewproject.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblnewproject.ForeColor = System.Drawing.Color.White;
            this.lblnewproject.Location = new System.Drawing.Point(32, 27);
            this.lblnewproject.Name = "lblnewproject";
            this.lblnewproject.Size = new System.Drawing.Size(153, 32);
            this.lblnewproject.TabIndex = 0;
            this.lblnewproject.Text = "New Project";
            this.lblnewproject.Click += new System.EventHandler(this.lblnewtask_Click);
            // 
            // txtdescripition
            // 
            this.txtdescripition.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripition.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtdescripition.Location = new System.Drawing.Point(38, 207);
            this.txtdescripition.Multiline = true;
            this.txtdescripition.Name = "txtdescripition";
            this.txtdescripition.Size = new System.Drawing.Size(591, 75);
            this.txtdescripition.TabIndex = 9;
            this.txtdescripition.Text = "Windows Form app ,TCP, Database";
            // 
            // lbldescripition
            // 
            this.lbldescripition.AutoSize = true;
            this.lbldescripition.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lbldescripition.Location = new System.Drawing.Point(33, 179);
            this.lbldescripition.Name = "lbldescripition";
            this.lbldescripition.Size = new System.Drawing.Size(102, 25);
            this.lbldescripition.TabIndex = 8;
            this.lbldescripition.Text = "Description";
            // 
            // txtprojectname
            // 
            this.txtprojectname.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtprojectname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtprojectname.Location = new System.Drawing.Point(38, 131);
            this.txtprojectname.Name = "txtprojectname";
            this.txtprojectname.Size = new System.Drawing.Size(591, 32);
            this.txtprojectname.TabIndex = 7;
            this.txtprojectname.Text = "CS312 Project";
            // 
            // lblprojectname
            // 
            this.lblprojectname.AutoSize = true;
            this.lblprojectname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblprojectname.Location = new System.Drawing.Point(34, 105);
            this.lblprojectname.Name = "lblprojectname";
            this.lblprojectname.Size = new System.Drawing.Size(126, 23);
            this.lblprojectname.TabIndex = 6;
            this.lblprojectname.Text = "Project Name *";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(38, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(591, 32);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Dec 20 ,2026";
            // 
            // btlprojectdeadline
            // 
            this.btlprojectdeadline.AutoSize = true;
            this.btlprojectdeadline.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btlprojectdeadline.Location = new System.Drawing.Point(34, 299);
            this.btlprojectdeadline.Name = "btlprojectdeadline";
            this.btlprojectdeadline.Size = new System.Drawing.Size(216, 23);
            this.btlprojectdeadline.TabIndex = 10;
            this.btlprojectdeadline.Text = "Project Deadline (Optional)";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnRemovethird);
            this.panel2.Controls.Add(this.btnRemoveSec);
            this.panel2.Controls.Add(this.txtadd);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblOwner);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.lblteammember);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(38, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 300);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtadd
            // 
            this.txtadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtadd.Location = new System.Drawing.Point(13, 246);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(383, 34);
            this.txtadd.TabIndex = 75;
            this.txtadd.Text = "Add member by user name or email";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(435, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 74;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOwner
            // 
            this.lblOwner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOwner.BackColor = System.Drawing.Color.Transparent;
            this.lblOwner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOwner.Location = new System.Drawing.Point(510, 80);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(56, 31);
            this.lblOwner.TabIndex = 70;
            this.lblOwner.Text = "Owner";
            this.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(66, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 17);
            this.label17.TabIndex = 65;
            this.label17.Text = "Galal@Gmail.com";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(65, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 30);
            this.label18.TabIndex = 64;
            this.label18.Text = "Galal";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(18, 182);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(45, 45);
            this.flowLayoutPanel3.TabIndex = 60;
            // 
            // lblteammember
            // 
            this.lblteammember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblteammember.BackColor = System.Drawing.Color.White;
            this.lblteammember.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblteammember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.lblteammember.Location = new System.Drawing.Point(8, 23);
            this.lblteammember.Name = "lblteammember";
            this.lblteammember.Size = new System.Drawing.Size(369, 31);
            this.lblteammember.TabIndex = 51;
            this.lblteammember.Text = "Team Members";
            this.lblteammember.Click += new System.EventHandler(this.label8_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(17, 117);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(45, 45);
            this.flowLayoutPanel2.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(66, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 17);
            this.label15.TabIndex = 57;
            this.label15.Text = "Ismail@Gmail.com";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(45, 45);
            this.flowLayoutPanel1.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(65, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 30);
            this.label16.TabIndex = 56;
            this.label16.Text = "Ismail";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(66, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Yousef@Gmail.com";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(65, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 30);
            this.label10.TabIndex = 53;
            this.label10.Text = "Yousef";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(71, -45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(403, 30);
            this.label9.TabIndex = 52;
            this.label9.Text = "Member see the project as soon as you add them";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCreateProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProject.ForeColor = System.Drawing.Color.White;
            this.btnCreateProject.Location = new System.Drawing.Point(494, 698);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(135, 40);
            this.btnCreateProject.TabIndex = 25;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(373, 698);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemoveSec
            // 
            this.btnRemoveSec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemoveSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveSec.Location = new System.Drawing.Point(478, 130);
            this.btnRemoveSec.Name = "btnRemoveSec";
            this.btnRemoveSec.Size = new System.Drawing.Size(88, 40);
            this.btnRemoveSec.TabIndex = 76;
            this.btnRemoveSec.Text = "Remove";
            this.btnRemoveSec.UseVisualStyleBackColor = true;
            // 
            // btnRemovethird
            // 
            this.btnRemovethird.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemovethird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovethird.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemovethird.Location = new System.Drawing.Point(478, 187);
            this.btnRemovethird.Name = "btnRemovethird";
            this.btnRemovethird.Size = new System.Drawing.Size(88, 40);
            this.btnRemovethird.TabIndex = 77;
            this.btnRemovethird.Text = "Remove";
            this.btnRemovethird.UseVisualStyleBackColor = true;
            // 
            // New_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 750);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btlprojectdeadline);
            this.Controls.Add(this.txtdescripition);
            this.Controls.Add(this.lbldescripition);
            this.Controls.Add(this.txtprojectname);
            this.Controls.Add(this.lblprojectname);
            this.Controls.Add(this.panel1);
            this.Name = "New_Project";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnewproject;
        private System.Windows.Forms.TextBox txtdescripition;
        private System.Windows.Forms.Label lbldescripition;
        private System.Windows.Forms.TextBox txtprojectname;
        private System.Windows.Forms.Label lblprojectname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label btlprojectdeadline;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblteammember;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemovethird;
        private System.Windows.Forms.Button btnRemoveSec;
    }
}