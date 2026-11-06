using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Mangement
{
    
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, lblNumNotif.Width, lblNumNotif.Height);
            lblNumNotif.Region = new Region(circlePath);


        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNumDone_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void lblProject_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_3(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

            
            this.Close();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
           

            plnMainDashboard.Controls.Clear();
            pnlSBMainDashboard.Controls.Clear();

            Project projects = new Project();


            Control mainProjectPanel = projects.Controls["plnProject"];
            Control sidebarProjectPanel = projects.Controls["pnlSBProject"];


            if (mainProjectPanel != null)
            {
                mainProjectPanel.Dock = DockStyle.Fill; 
                plnMainDashboard.Controls.Add(mainProjectPanel);
            }


            if (sidebarProjectPanel != null)
            {
                sidebarProjectPanel.Dock = DockStyle.Fill; 
                pnlSBMainDashboard.Controls.Add(sidebarProjectPanel);
            }
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalTasks_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnNewTask, new Point(0, btnNewTask.Height));

        }

        private void newPersonalTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();

            
            newTask.ShowDialog();
        }

        private void newProjectTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Project_Task newTask = new New_Project_Task();


            newTask.ShowDialog();
        }

        private void plnMainDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {

            plnMainDashboard.Controls.Clear();
            pnlSBMainDashboard.Controls.Clear();

            Notifications notificationsForm = new Notifications();

            Control[] mainNotifSearch = notificationsForm.Controls.Find("pnlMainNotif", true);
            Control[] sideNotifSearch = notificationsForm.Controls.Find("pnlSBNotif", true);

            if (mainNotifSearch.Length > 0)
            {
                Control mainNotifPanel = mainNotifSearch[0];
                mainNotifPanel.Dock = DockStyle.Fill;
                plnMainDashboard.Controls.Add(mainNotifPanel);

                mainNotifPanel.BringToFront();
            }


            if (sideNotifSearch.Length > 0)
            {
                Control sideNotifPanel = sideNotifSearch[0];
                sideNotifPanel.Dock = DockStyle.Fill;
                pnlSBMainDashboard.Controls.Add(sideNotifPanel);

                sideNotifPanel.BringToFront();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkFlowBoard_Click(object sender, EventArgs e)
        {
            plnMainDashboard.Controls.Clear();
            pnlSBMainDashboard.Controls.Clear();

            WorkFlow workFlowForm = new WorkFlow();


            Control mainWorkFlowPanel = workFlowForm.Controls["plnWorkFlow"];
            Control sidebarWorkFlowPanel = workFlowForm.Controls["pnlSBWorkFlow"];


            if (mainWorkFlowPanel != null)
            {
                mainWorkFlowPanel.Dock = DockStyle.Fill;
                plnMainDashboard.Controls.Add(mainWorkFlowPanel);
            }


            if (sidebarWorkFlowPanel != null)
            {
                sidebarWorkFlowPanel.Dock = DockStyle.Fill;
                pnlSBMainDashboard.Controls.Add(sidebarWorkFlowPanel);
            }
        }

        private void lblTaskify_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void pnlBTN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_4(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblTableDeadline_Click(object sender, EventArgs e)
        {

        }

        private void lblTableAssignedTo_Click(object sender, EventArgs e)
        {

        }

        private void lblTableStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblTablePriority_Click(object sender, EventArgs e)
        {

        }

        private void lblTableProject_Click(object sender, EventArgs e)
        {

        }

        private void lblTableAction_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutFilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelDeadline_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDeadline_Click(object sender, EventArgs e)
        {

        }

        private void cmbDeadline_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelProject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelStatuse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelPriorty_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPriority_Click(object sender, EventArgs e)
        {

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMessageNotif_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTotalTasks_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbCompletion_Click(object sender, EventArgs e)
        {

        }

        private void lblCompletion_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOverDur_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNumProgress_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }

    

}
