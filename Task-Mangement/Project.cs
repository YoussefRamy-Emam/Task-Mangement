using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Mangement
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pbCompletion_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblDote1_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void plnProject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            plnProject.Controls.Clear();
            pnlSBProject.Controls.Clear();

            Dashboard dashboardForm = new Dashboard();

            Control mainDashPanel = dashboardForm.Controls["plnMainDashboard"];
            Control sidebarDashPanel = dashboardForm.Controls["pnlSBMainDashboard"];

            if (mainDashPanel != null)
            {
                mainDashPanel.Dock = DockStyle.Fill;
                plnProject.Controls.Add(mainDashPanel);
            }

            if (sidebarDashPanel != null)
            {
                sidebarDashPanel.Dock = DockStyle.Fill;
                pnlSBProject.Controls.Add(sidebarDashPanel);
            }
        }

        private void newProjectTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void newPersonalTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            New_Project newProjectForm = new New_Project();
            newProjectForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTitleProjects_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;


            this.Close();
        }

        private void lblNumNotif_Click(object sender, EventArgs e)
        {

        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
           

            plnProject.Controls.Clear();
            pnlSBProject.Controls.Clear();

            Notifications notificationsForm = new Notifications();

            Control[] mainNotifSearch = notificationsForm.Controls.Find("pnlMainNotif", true);
            Control[] sideNotifSearch = notificationsForm.Controls.Find("pnlSBNotif", true);

            if (mainNotifSearch.Length > 0)
            {
                Control mainNotifPanel = mainNotifSearch[0];
                mainNotifPanel.Dock = DockStyle.Fill;
                plnProject.Controls.Add(mainNotifPanel);

                mainNotifPanel.BringToFront();
            }
            

            if (sideNotifSearch.Length > 0)
            {
                Control sideNotifPanel = sideNotifSearch[0];
                sideNotifPanel.Dock = DockStyle.Fill;
                pnlSBProject.Controls.Add(sideNotifPanel);

                sideNotifPanel.BringToFront();
            }
            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkFlowBoard_Click(object sender, EventArgs e)
        {
            plnProject.Controls.Clear();
            pnlSBProject.Controls.Clear();

            WorkFlow workFlowForm = new WorkFlow();


            Control mainWorkFlowPanel = workFlowForm.Controls["plnWorkFlow"];
            Control sidebarWorkFlowPanel = workFlowForm.Controls["pnlSBWorkFlow"];


            if (mainWorkFlowPanel != null)
            {
                mainWorkFlowPanel.Dock = DockStyle.Fill;
                plnProject.Controls.Add(mainWorkFlowPanel);
            }


            if (sidebarWorkFlowPanel != null)
            {
                sidebarWorkFlowPanel.Dock = DockStyle.Fill;
                pnlSBProject.Controls.Add(sidebarWorkFlowPanel);
            }


        }

        private void btnProjects_Click(object sender, EventArgs e)
        {

        }

        private void lblTaskify_Click(object sender, EventArgs e)
        {

        }

        private void pnlSBProject_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            plnProject.Controls.Clear();
            pnlSBProject.Controls.Clear();

            ProfileForm profileForm = new ProfileForm();

            Control mainProfilePanel = profileForm.Controls["plnProfile"];
            Control sidebarProfilePanel = profileForm.Controls["ProfileBar"];


            if (mainProfilePanel != null)
            {
                mainProfilePanel.Dock = DockStyle.Fill;
                plnProject.Controls.Add(mainProfilePanel);
            }


            if (sidebarProfilePanel != null)
            {
                sidebarProfilePanel.Dock = DockStyle.Fill;
                pnlSBProject.Controls.Add(sidebarProfilePanel);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TeamMember teamMemberForm = new TeamMember();
            teamMemberForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportProjectTeam reportProjectForm = new ReportProjectTeam();
            reportProjectForm.ShowDialog();
        }

        private void btnReportProject_Click(object sender, EventArgs e)
        {
            ReportProjectTeam reportProjectForm = new ReportProjectTeam();
            reportProjectForm.ShowDialog();
        }
    }
}
