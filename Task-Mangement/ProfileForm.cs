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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            //ProfileBar.Controls.Clear();
            //plnProfile.Controls.Clear();

            //Dashboard dashboardForm = new Dashboard();

            //Control mainDashPanel = dashboardForm.Controls["plnMainDashboard"];
            //Control sidebarDashPanel = dashboardForm.Controls["pnlSBMainDashboard"];

            //if (mainDashPanel != null)
            //{
            //    mainDashPanel.Dock = DockStyle.Fill;
            //    sidebarDashPanel.Controls.Add(mainDashPanel);
            //}

            //if (sidebarDashPanel != null)
            //{
            //    sidebarDashPanel.Dock = DockStyle.Fill;
            //    sidebarDashPanel.Controls.Add(sidebarDashPanel);
            //}
            plnProfile.Controls.Clear();
            ProfileBar.Controls.Clear();

            Dashboard dashboardForm = new Dashboard();

            Control mainDashPanel = dashboardForm.Controls["plnMainDashboard"];
            Control sidebarDashPanel = dashboardForm.Controls["pnlSBMainDashboard"];

            if (mainDashPanel != null)
            {
                mainDashPanel.Dock = DockStyle.Fill;
                plnProfile.Controls.Add(mainDashPanel);
            }

            if (sidebarDashPanel != null)
            {
                sidebarDashPanel.Dock = DockStyle.Fill;
                ProfileBar.Controls.Add(sidebarDashPanel);
            }

            
        }

        private void ProfileBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ProfileBar.Controls.Clear();
            plnProfile.Controls.Clear();

            Notifications notificationsForm = new Notifications();

            Control[] mainNotifSearch = notificationsForm.Controls.Find("pnlMainNotif", true);
            Control[] sideNotifSearch = notificationsForm.Controls.Find("pnlSBNotif", true);

            if (mainNotifSearch.Length > 0)
            {
                Control mainNotifPanel = mainNotifSearch[0];
                mainNotifPanel.Dock = DockStyle.Fill;
                ProfileBar.Controls.Add(mainNotifPanel);

                mainNotifPanel.BringToFront();
            }


            if (sideNotifSearch.Length > 0)
            {
                Control sideNotifPanel = sideNotifSearch[0];
                sideNotifPanel.Dock = DockStyle.Fill;
                ProfileBar.Controls.Add(sideNotifPanel);

                sideNotifPanel.BringToFront();
            }
        }

        private void btnWorkFlowBoard_Click(object sender, EventArgs e)
        {
            ProfileBar.Controls.Clear();
            plnProfile.Controls.Clear();

            WorkFlow workFlowForm = new WorkFlow();


            Control mainWorkFlowPanel = workFlowForm.Controls["plnWorkFlow"];
            Control sidebarWorkFlowPanel = workFlowForm.Controls["pnlSBWorkFlow"];


            if (mainWorkFlowPanel != null)
            {
                mainWorkFlowPanel.Dock = DockStyle.Fill;
                plnProfile.Controls.Add(mainWorkFlowPanel);
            }


            if (sidebarWorkFlowPanel != null)
            {
                sidebarWorkFlowPanel.Dock = DockStyle.Fill;
                ProfileBar.Controls.Add(sidebarWorkFlowPanel);
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProfileBar.Controls.Clear();
            plnProfile.Controls.Clear();

            Project projects = new Project();


            Control mainProjectPanel = projects.Controls["plnProject"];
            Control sidebarProjectPanel = projects.Controls["pnlSBProject"];


            if (mainProjectPanel != null)
            {
                mainProjectPanel.Dock = DockStyle.Fill;
                plnProfile.Controls.Add(mainProjectPanel);
            }


            if (sidebarProjectPanel != null)
            {
                sidebarProjectPanel.Dock = DockStyle.Fill;
                ProfileBar.Controls.Add(sidebarProjectPanel);
            }
        }
    }
}
