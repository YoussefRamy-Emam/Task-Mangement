namespace Task_Mangement
{
    partial class ReportProjectTeam
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.pnlCardStatus = new System.Windows.Forms.Panel();
            this.lblLegendDone = new System.Windows.Forms.Label();
            this.lblLegendProgress = new System.Windows.Forms.Label();
            this.lblLegendTodo = new System.Windows.Forms.Label();
            this.lblCardStatusTitle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblValLow = new System.Windows.Forms.Label();
            this.lblValMed = new System.Windows.Forms.Label();
            this.lblValHigh = new System.Windows.Forms.Label();
            this.lblValUrgent = new System.Windows.Forms.Label();
            this.lblTagLow = new System.Windows.Forms.Label();
            this.lblTagMed = new System.Windows.Forms.Label();
            this.lblTagHigh = new System.Windows.Forms.Label();
            this.lblTagUrgent = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.lblReportsSubtitle = new System.Windows.Forms.Label();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.pnlBarLow = new System.Windows.Forms.Panel();
            this.plnReport = new System.Windows.Forms.Panel();
            this.pnlCardPriority = new System.Windows.Forms.Panel();
            this.pnlBarMed = new System.Windows.Forms.Panel();
            this.pnlBarHigh = new System.Windows.Forms.Panel();
            this.pnlBarUrgent = new System.Windows.Forms.Panel();
            this.lblCardPriorityTitle = new System.Windows.Forms.Label();
            this.newProjectTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newPersonalTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOverdue2User = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOverdue1User = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCardCompleted = new System.Windows.Forms.Panel();
            this.lblAhmedCount = new System.Windows.Forms.Label();
            this.pbAhmed = new System.Windows.Forms.ProgressBar();
            this.lblAhmed = new System.Windows.Forms.Label();
            this.lblYousefCount = new System.Windows.Forms.Label();
            this.pbYousef = new System.Windows.Forms.ProgressBar();
            this.lblYousef = new System.Windows.Forms.Label();
            this.lblMonaCount = new System.Windows.Forms.Label();
            this.pbMona = new System.Windows.Forms.ProgressBar();
            this.lblMona = new System.Windows.Forms.Label();
            this.lblSaraCount = new System.Windows.Forms.Label();
            this.pbSara = new System.Windows.Forms.ProgressBar();
            this.lblSara = new System.Windows.Forms.Label();
            this.lblCardCompletedTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlCardStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.plnReport.SuspendLayout();
            this.pnlCardPriority.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlCardCompleted.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCardStatus
            // 
            this.pnlCardStatus.BackColor = System.Drawing.Color.White;
            this.pnlCardStatus.Controls.Add(this.lblLegendDone);
            this.pnlCardStatus.Controls.Add(this.lblLegendProgress);
            this.pnlCardStatus.Controls.Add(this.lblLegendTodo);
            this.pnlCardStatus.Controls.Add(this.lblCardStatusTitle);
            this.pnlCardStatus.Controls.Add(this.chart1);
            this.pnlCardStatus.Location = new System.Drawing.Point(26, 128);
            this.pnlCardStatus.Name = "pnlCardStatus";
            this.pnlCardStatus.Size = new System.Drawing.Size(515, 290);
            this.pnlCardStatus.TabIndex = 7;
            // 
            // lblLegendDone
            // 
            this.lblLegendDone.AutoSize = true;
            this.lblLegendDone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLegendDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblLegendDone.Location = new System.Drawing.Point(8, 235);
            this.lblLegendDone.Name = "lblLegendDone";
            this.lblLegendDone.Size = new System.Drawing.Size(137, 21);
            this.lblLegendDone.TabIndex = 0;
            this.lblLegendDone.Text = "■  Done · 2 (25%)";
            // 
            // lblLegendProgress
            // 
            this.lblLegendProgress.AutoSize = true;
            this.lblLegendProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLegendProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblLegendProgress.Location = new System.Drawing.Point(8, 259);
            this.lblLegendProgress.Name = "lblLegendProgress";
            this.lblLegendProgress.Size = new System.Drawing.Size(181, 21);
            this.lblLegendProgress.TabIndex = 1;
            this.lblLegendProgress.Text = "■  In progress · 2 (25%)";
            // 
            // lblLegendTodo
            // 
            this.lblLegendTodo.AutoSize = true;
            this.lblLegendTodo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLegendTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblLegendTodo.Location = new System.Drawing.Point(6, 209);
            this.lblLegendTodo.Name = "lblLegendTodo";
            this.lblLegendTodo.Size = new System.Drawing.Size(139, 21);
            this.lblLegendTodo.TabIndex = 2;
            this.lblLegendTodo.Text = "■  To do · 4 (50%)";
            // 
            // lblCardStatusTitle
            // 
            this.lblCardStatusTitle.AutoSize = true;
            this.lblCardStatusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCardStatusTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardStatusTitle.Name = "lblCardStatusTitle";
            this.lblCardStatusTitle.Size = new System.Drawing.Size(154, 28);
            this.lblCardStatusTitle.TabIndex = 4;
            this.lblCardStatusTitle.Text = "Tasks by status";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.Silver;
            dataPoint2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataPoint3.Color = System.Drawing.Color.Blue;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(515, 290);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // lblValLow
            // 
            this.lblValLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValLow.Location = new System.Drawing.Point(385, 145);
            this.lblValLow.Name = "lblValLow";
            this.lblValLow.Size = new System.Drawing.Size(50, 20);
            this.lblValLow.TabIndex = 4;
            this.lblValLow.Text = "1";
            this.lblValLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValMed
            // 
            this.lblValMed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValMed.Location = new System.Drawing.Point(280, 45);
            this.lblValMed.Name = "lblValMed";
            this.lblValMed.Size = new System.Drawing.Size(50, 20);
            this.lblValMed.TabIndex = 5;
            this.lblValMed.Text = "3";
            this.lblValMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValHigh
            // 
            this.lblValHigh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValHigh.Location = new System.Drawing.Point(175, 45);
            this.lblValHigh.Name = "lblValHigh";
            this.lblValHigh.Size = new System.Drawing.Size(50, 20);
            this.lblValHigh.TabIndex = 6;
            this.lblValHigh.Text = "3";
            this.lblValHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValUrgent
            // 
            this.lblValUrgent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValUrgent.Location = new System.Drawing.Point(70, 145);
            this.lblValUrgent.Name = "lblValUrgent";
            this.lblValUrgent.Size = new System.Drawing.Size(50, 20);
            this.lblValUrgent.TabIndex = 7;
            this.lblValUrgent.Text = "1";
            this.lblValUrgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagLow
            // 
            this.lblTagLow.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagLow.Location = new System.Drawing.Point(375, 235);
            this.lblTagLow.Name = "lblTagLow";
            this.lblTagLow.Size = new System.Drawing.Size(70, 25);
            this.lblTagLow.TabIndex = 0;
            this.lblTagLow.Text = "Low";
            this.lblTagLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagMed
            // 
            this.lblTagMed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagMed.Location = new System.Drawing.Point(270, 235);
            this.lblTagMed.Name = "lblTagMed";
            this.lblTagMed.Size = new System.Drawing.Size(70, 25);
            this.lblTagMed.TabIndex = 1;
            this.lblTagMed.Text = "Medium";
            this.lblTagMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagHigh
            // 
            this.lblTagHigh.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagHigh.Location = new System.Drawing.Point(165, 235);
            this.lblTagHigh.Name = "lblTagHigh";
            this.lblTagHigh.Size = new System.Drawing.Size(70, 25);
            this.lblTagHigh.TabIndex = 2;
            this.lblTagHigh.Text = "High";
            this.lblTagHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagUrgent
            // 
            this.lblTagUrgent.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagUrgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagUrgent.Location = new System.Drawing.Point(60, 235);
            this.lblTagUrgent.Name = "lblTagUrgent";
            this.lblTagUrgent.Size = new System.Drawing.Size(70, 25);
            this.lblTagUrgent.TabIndex = 3;
            this.lblTagUrgent.Text = "Urgent";
            this.lblTagUrgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.btnExportCsv);
            this.pnlHeader.Controls.Add(this.btnExportExcel);
            this.pnlHeader.Controls.Add(this.btnExportPdf);
            this.pnlHeader.Controls.Add(this.lblReportsSubtitle);
            this.pnlHeader.Controls.Add(this.lblReportsTitle);
            this.pnlHeader.Location = new System.Drawing.Point(26, 38);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1070, 75);
            this.pnlHeader.TabIndex = 6;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.BackColor = System.Drawing.Color.White;
            this.btnExportCsv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnExportCsv.Location = new System.Drawing.Point(589, 18);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(110, 36);
            this.btnExportCsv.TabIndex = 0;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnExportExcel.Location = new System.Drawing.Point(825, 18);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(115, 36);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.White;
            this.btnExportPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnExportPdf.Location = new System.Drawing.Point(705, 18);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(110, 36);
            this.btnExportPdf.TabIndex = 2;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // lblReportsSubtitle
            // 
            this.lblReportsSubtitle.AutoSize = true;
            this.lblReportsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReportsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblReportsSubtitle.Location = new System.Drawing.Point(6, 48);
            this.lblReportsSubtitle.Name = "lblReportsSubtitle";
            this.lblReportsSubtitle.Size = new System.Drawing.Size(252, 21);
            this.lblReportsSubtitle.TabIndex = 3;
            this.lblReportsSubtitle.Text = "CS.312 · 8 tasks · as of Oct 31 2026";
            this.lblReportsSubtitle.Click += new System.EventHandler(this.lblReportsSubtitle_Click);
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblReportsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.lblReportsTitle.Location = new System.Drawing.Point(3, 0);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(157, 50);
            this.lblReportsTitle.TabIndex = 4;
            this.lblReportsTitle.Text = "Reports";
            // 
            // pnlBarLow
            // 
            this.pnlBarLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.pnlBarLow.Location = new System.Drawing.Point(385, 170);
            this.pnlBarLow.Name = "pnlBarLow";
            this.pnlBarLow.Size = new System.Drawing.Size(50, 60);
            this.pnlBarLow.TabIndex = 8;
            // 
            // plnReport
            // 
            this.plnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plnReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plnReport.Controls.Add(this.panel1);
            this.plnReport.Controls.Add(this.pnlCardCompleted);
            this.plnReport.Controls.Add(this.pnlCardPriority);
            this.plnReport.Controls.Add(this.pnlCardStatus);
            this.plnReport.Controls.Add(this.pnlHeader);
            this.plnReport.Location = new System.Drawing.Point(101, 12);
            this.plnReport.Name = "plnReport";
            this.plnReport.Size = new System.Drawing.Size(1122, 760);
            this.plnReport.TabIndex = 5;
            // 
            // pnlCardPriority
            // 
            this.pnlCardPriority.BackColor = System.Drawing.Color.White;
            this.pnlCardPriority.Controls.Add(this.lblTagLow);
            this.pnlCardPriority.Controls.Add(this.lblTagMed);
            this.pnlCardPriority.Controls.Add(this.lblTagHigh);
            this.pnlCardPriority.Controls.Add(this.lblTagUrgent);
            this.pnlCardPriority.Controls.Add(this.lblValLow);
            this.pnlCardPriority.Controls.Add(this.lblValMed);
            this.pnlCardPriority.Controls.Add(this.lblValHigh);
            this.pnlCardPriority.Controls.Add(this.lblValUrgent);
            this.pnlCardPriority.Controls.Add(this.pnlBarLow);
            this.pnlCardPriority.Controls.Add(this.pnlBarMed);
            this.pnlCardPriority.Controls.Add(this.pnlBarHigh);
            this.pnlCardPriority.Controls.Add(this.pnlBarUrgent);
            this.pnlCardPriority.Controls.Add(this.lblCardPriorityTitle);
            this.pnlCardPriority.Location = new System.Drawing.Point(571, 128);
            this.pnlCardPriority.Name = "pnlCardPriority";
            this.pnlCardPriority.Size = new System.Drawing.Size(525, 290);
            this.pnlCardPriority.TabIndex = 8;
            // 
            // pnlBarMed
            // 
            this.pnlBarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.pnlBarMed.Location = new System.Drawing.Point(280, 70);
            this.pnlBarMed.Name = "pnlBarMed";
            this.pnlBarMed.Size = new System.Drawing.Size(50, 160);
            this.pnlBarMed.TabIndex = 9;
            // 
            // pnlBarHigh
            // 
            this.pnlBarHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlBarHigh.Location = new System.Drawing.Point(175, 70);
            this.pnlBarHigh.Name = "pnlBarHigh";
            this.pnlBarHigh.Size = new System.Drawing.Size(50, 160);
            this.pnlBarHigh.TabIndex = 10;
            // 
            // pnlBarUrgent
            // 
            this.pnlBarUrgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlBarUrgent.Location = new System.Drawing.Point(70, 170);
            this.pnlBarUrgent.Name = "pnlBarUrgent";
            this.pnlBarUrgent.Size = new System.Drawing.Size(50, 60);
            this.pnlBarUrgent.TabIndex = 11;
            // 
            // lblCardPriorityTitle
            // 
            this.lblCardPriorityTitle.AutoSize = true;
            this.lblCardPriorityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardPriorityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCardPriorityTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardPriorityTitle.Name = "lblCardPriorityTitle";
            this.lblCardPriorityTitle.Size = new System.Drawing.Size(168, 28);
            this.lblCardPriorityTitle.TabIndex = 12;
            this.lblCardPriorityTitle.Text = "Tasks by priority";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(26, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 280);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(20, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "2 of 6 open tasks are past their deadline";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblOverdue2User);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(20, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 45);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(390, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oct 30";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOverdue2User
            // 
            this.lblOverdue2User.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblOverdue2User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblOverdue2User.Location = new System.Drawing.Point(250, 10);
            this.lblOverdue2User.Name = "lblOverdue2User";
            this.lblOverdue2User.Size = new System.Drawing.Size(100, 25);
            this.lblOverdue2User.TabIndex = 1;
            this.lblOverdue2User.Text = "Yousef";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prepare demo scenario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblOverdue1User);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(20, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 45);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label4.Location = new System.Drawing.Point(390, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oct 29";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOverdue1User
            // 
            this.lblOverdue1User.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblOverdue1User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblOverdue1User.Location = new System.Drawing.Point(250, 10);
            this.lblOverdue1User.Name = "lblOverdue1User";
            this.lblOverdue1User.Size = new System.Drawing.Size(100, 25);
            this.lblOverdue1User.TabIndex = 1;
            this.lblOverdue1User.Text = "Ahmed";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Create SQL script";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Overdue tasks";
            // 
            // pnlCardCompleted
            // 
            this.pnlCardCompleted.BackColor = System.Drawing.Color.White;
            this.pnlCardCompleted.Controls.Add(this.lblAhmedCount);
            this.pnlCardCompleted.Controls.Add(this.pbAhmed);
            this.pnlCardCompleted.Controls.Add(this.lblAhmed);
            this.pnlCardCompleted.Controls.Add(this.lblYousefCount);
            this.pnlCardCompleted.Controls.Add(this.pbYousef);
            this.pnlCardCompleted.Controls.Add(this.lblYousef);
            this.pnlCardCompleted.Controls.Add(this.lblMonaCount);
            this.pnlCardCompleted.Controls.Add(this.pbMona);
            this.pnlCardCompleted.Controls.Add(this.lblMona);
            this.pnlCardCompleted.Controls.Add(this.lblSaraCount);
            this.pnlCardCompleted.Controls.Add(this.pbSara);
            this.pnlCardCompleted.Controls.Add(this.lblSara);
            this.pnlCardCompleted.Controls.Add(this.lblCardCompletedTitle);
            this.pnlCardCompleted.Location = new System.Drawing.Point(571, 437);
            this.pnlCardCompleted.Name = "pnlCardCompleted";
            this.pnlCardCompleted.Size = new System.Drawing.Size(525, 280);
            this.pnlCardCompleted.TabIndex = 13;
            // 
            // lblAhmedCount
            // 
            this.lblAhmedCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAhmedCount.Location = new System.Drawing.Point(465, 215);
            this.lblAhmedCount.Name = "lblAhmedCount";
            this.lblAhmedCount.Size = new System.Drawing.Size(30, 25);
            this.lblAhmedCount.TabIndex = 0;
            this.lblAhmedCount.Text = "0";
            // 
            // pbAhmed
            // 
            this.pbAhmed.Location = new System.Drawing.Point(85, 220);
            this.pbAhmed.Name = "pbAhmed";
            this.pbAhmed.Size = new System.Drawing.Size(370, 12);
            this.pbAhmed.TabIndex = 1;
            // 
            // lblAhmed
            // 
            this.lblAhmed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAhmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblAhmed.Location = new System.Drawing.Point(15, 215);
            this.lblAhmed.Name = "lblAhmed";
            this.lblAhmed.Size = new System.Drawing.Size(65, 25);
            this.lblAhmed.TabIndex = 2;
            this.lblAhmed.Text = "Ahmed";
            // 
            // lblYousefCount
            // 
            this.lblYousefCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYousefCount.Location = new System.Drawing.Point(465, 165);
            this.lblYousefCount.Name = "lblYousefCount";
            this.lblYousefCount.Size = new System.Drawing.Size(30, 25);
            this.lblYousefCount.TabIndex = 3;
            this.lblYousefCount.Text = "0";
            // 
            // pbYousef
            // 
            this.pbYousef.Location = new System.Drawing.Point(85, 170);
            this.pbYousef.Name = "pbYousef";
            this.pbYousef.Size = new System.Drawing.Size(370, 12);
            this.pbYousef.TabIndex = 4;
            // 
            // lblYousef
            // 
            this.lblYousef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYousef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblYousef.Location = new System.Drawing.Point(15, 165);
            this.lblYousef.Name = "lblYousef";
            this.lblYousef.Size = new System.Drawing.Size(65, 25);
            this.lblYousef.TabIndex = 5;
            this.lblYousef.Text = "Yousef";
            // 
            // lblMonaCount
            // 
            this.lblMonaCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonaCount.Location = new System.Drawing.Point(465, 115);
            this.lblMonaCount.Name = "lblMonaCount";
            this.lblMonaCount.Size = new System.Drawing.Size(30, 25);
            this.lblMonaCount.TabIndex = 6;
            this.lblMonaCount.Text = "1";
            // 
            // pbMona
            // 
            this.pbMona.Location = new System.Drawing.Point(85, 120);
            this.pbMona.Name = "pbMona";
            this.pbMona.Size = new System.Drawing.Size(370, 12);
            this.pbMona.TabIndex = 7;
            this.pbMona.Value = 100;
            // 
            // lblMona
            // 
            this.lblMona.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMona.Location = new System.Drawing.Point(15, 115);
            this.lblMona.Name = "lblMona";
            this.lblMona.Size = new System.Drawing.Size(65, 25);
            this.lblMona.TabIndex = 8;
            this.lblMona.Text = "Mona";
            // 
            // lblSaraCount
            // 
            this.lblSaraCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaraCount.Location = new System.Drawing.Point(465, 65);
            this.lblSaraCount.Name = "lblSaraCount";
            this.lblSaraCount.Size = new System.Drawing.Size(30, 25);
            this.lblSaraCount.TabIndex = 9;
            this.lblSaraCount.Text = "1";
            // 
            // pbSara
            // 
            this.pbSara.Location = new System.Drawing.Point(85, 70);
            this.pbSara.Name = "pbSara";
            this.pbSara.Size = new System.Drawing.Size(370, 12);
            this.pbSara.TabIndex = 10;
            this.pbSara.Value = 100;
            // 
            // lblSara
            // 
            this.lblSara.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSara.Location = new System.Drawing.Point(15, 65);
            this.lblSara.Name = "lblSara";
            this.lblSara.Size = new System.Drawing.Size(65, 25);
            this.lblSara.TabIndex = 11;
            this.lblSara.Text = "Sara";
            // 
            // lblCardCompletedTitle
            // 
            this.lblCardCompletedTitle.AutoSize = true;
            this.lblCardCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardCompletedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCardCompletedTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardCompletedTitle.Name = "lblCardCompletedTitle";
            this.lblCardCompletedTitle.Size = new System.Drawing.Size(275, 28);
            this.lblCardCompletedTitle.TabIndex = 12;
            this.lblCardCompletedTitle.Text = "Completed tasks per person";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnClose.Location = new System.Drawing.Point(946, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ReportProjectTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.plnReport);
            this.Name = "ReportProjectTeam";
            this.Text = "ReportProjectTeam";
            this.pnlCardStatus.ResumeLayout(false);
            this.pnlCardStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.plnReport.ResumeLayout(false);
            this.pnlCardPriority.ResumeLayout(false);
            this.pnlCardPriority.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlCardCompleted.ResumeLayout(false);
            this.pnlCardCompleted.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCardStatus;
        private System.Windows.Forms.Label lblLegendDone;
        private System.Windows.Forms.Label lblLegendProgress;
        private System.Windows.Forms.Label lblLegendTodo;
        private System.Windows.Forms.Label lblCardStatusTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblValLow;
        private System.Windows.Forms.Label lblValMed;
        private System.Windows.Forms.Label lblValHigh;
        private System.Windows.Forms.Label lblValUrgent;
        private System.Windows.Forms.Label lblTagLow;
        private System.Windows.Forms.Label lblTagMed;
        private System.Windows.Forms.Label lblTagHigh;
        private System.Windows.Forms.Label lblTagUrgent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Label lblReportsSubtitle;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Panel pnlBarLow;
        private System.Windows.Forms.Panel plnReport;
        private System.Windows.Forms.Panel pnlCardPriority;
        private System.Windows.Forms.Panel pnlBarMed;
        private System.Windows.Forms.Panel pnlBarHigh;
        private System.Windows.Forms.Panel pnlBarUrgent;
        private System.Windows.Forms.Label lblCardPriorityTitle;
        private System.Windows.Forms.ToolStripMenuItem newProjectTaskToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newPersonalTaskToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOverdue2User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOverdue1User;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCardCompleted;
        private System.Windows.Forms.Label lblAhmedCount;
        private System.Windows.Forms.ProgressBar pbAhmed;
        private System.Windows.Forms.Label lblAhmed;
        private System.Windows.Forms.Label lblYousefCount;
        private System.Windows.Forms.ProgressBar pbYousef;
        private System.Windows.Forms.Label lblYousef;
        private System.Windows.Forms.Label lblMonaCount;
        private System.Windows.Forms.ProgressBar pbMona;
        private System.Windows.Forms.Label lblMona;
        private System.Windows.Forms.Label lblSaraCount;
        private System.Windows.Forms.ProgressBar pbSara;
        private System.Windows.Forms.Label lblSara;
        private System.Windows.Forms.Label lblCardCompletedTitle;
        private System.Windows.Forms.Button btnClose;
    }
}