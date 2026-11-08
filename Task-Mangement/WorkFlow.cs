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
    public partial class WorkFlow : Form
    {
        public WorkFlow()
        {
            InitializeComponent();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblUnreadCount_Click(object sender, EventArgs e)
        {

        }

        private void btnMarkAllRead_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }

        private void flpFilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilterProjects_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterDeadlines_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterCompleted_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterAssigned_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterUnread_Click(object sender, EventArgs e)
        {

        }

        private void btnFilterAll_Click(object sender, EventArgs e)
        {

        }

        private void flpNotifications_Paint(object sender, PaintEventArgs e)
        {

        }

        private void card6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c6Dismiss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c6Time_Click(object sender, EventArgs e)
        {

        }

        private void c6Badge_Click(object sender, EventArgs e)
        {

        }

        private void c6Desc_Click(object sender, EventArgs e)
        {

        }

        private void c6Title_Click(object sender, EventArgs e)
        {

        }

        private void c6Icon_Click(object sender, EventArgs e)
        {

        }

        private void card5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c5Dismiss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c5Time_Click(object sender, EventArgs e)
        {

        }

        private void c5Badge_Click(object sender, EventArgs e)
        {

        }

        private void c5Desc_Click(object sender, EventArgs e)
        {

        }

        private void c5Title_Click(object sender, EventArgs e)
        {

        }

        private void c5Icon_Click(object sender, EventArgs e)
        {

        }

        private void card4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c4Dismiss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c4Time_Click(object sender, EventArgs e)
        {

        }

        private void c4Badge_Click(object sender, EventArgs e)
        {

        }

        private void c4Desc_Click(object sender, EventArgs e)
        {

        }

        private void c4Title_Click(object sender, EventArgs e)
        {

        }

        private void c4Icon_Click(object sender, EventArgs e)
        {

        }

        private void card3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c3Dismiss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c3MarkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c3Time_Click(object sender, EventArgs e)
        {

        }

        private void c3Badge_Click(object sender, EventArgs e)
        {

        }

        private void c3Desc_Click(object sender, EventArgs e)
        {

        }

        private void c3Title_Click(object sender, EventArgs e)
        {

        }

        private void c3Icon_Click(object sender, EventArgs e)
        {

        }

        private void c3Dot_Click(object sender, EventArgs e)
        {

        }

        private void card2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c2Dismiss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c2MarkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c2Time_Click(object sender, EventArgs e)
        {

        }

        private void c2Badge_Click(object sender, EventArgs e)
        {

        }

        private void c2Desc_Click(object sender, EventArgs e)
        {

        }

        private void c2Title_Click(object sender, EventArgs e)
        {

        }

        private void c2Icon_Click(object sender, EventArgs e)
        {

        }

        private void c2Dot_Click(object sender, EventArgs e)
        {

        }

        private void c1Dismiss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c1MarkRead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void c1Time_Click(object sender, EventArgs e)
        {

        }

        private void c1Badge_Click(object sender, EventArgs e)
        {

        }

        private void c1Desc_Click(object sender, EventArgs e)
        {

        }

        private void c1Title_Click(object sender, EventArgs e)
        {

        }

        private void c1Icon_Click(object sender, EventArgs e)
        {

        }

        private void c1Dot_Click(object sender, EventArgs e)
        {

        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            plnWorkFlow.Controls.Clear();
            pnlSBWorkFlow.Controls.Clear();

            Dashboard dashboardForm = new Dashboard();

            Control mainDashPanel = dashboardForm.Controls["plnMainDashboard"];
            Control sidebarDashPanel = dashboardForm.Controls["pnlSBMainDashboard"];

            if (mainDashPanel != null)
            {
                mainDashPanel.Dock = DockStyle.Fill;
                plnWorkFlow.Controls.Add(mainDashPanel);
            }

            if (sidebarDashPanel != null)
            {
                sidebarDashPanel.Dock = DockStyle.Fill;
                pnlSBWorkFlow.Controls.Add(sidebarDashPanel);
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            plnWorkFlow.Controls.Clear();
            pnlSBWorkFlow.Controls.Clear();

            Notifications notificationsForm = new Notifications();

            Control[] mainNotifSearch = notificationsForm.Controls.Find("pnlMainNotif", true);
            Control[] sideNotifSearch = notificationsForm.Controls.Find("pnlSBNotif", true);

            if (mainNotifSearch.Length > 0)
            {
                Control mainNotifPanel = mainNotifSearch[0];
                mainNotifPanel.Dock = DockStyle.Fill;
                plnWorkFlow.Controls.Add(mainNotifPanel);

                mainNotifPanel.BringToFront();
            }


            if (sideNotifSearch.Length > 0)
            {
                Control sideNotifPanel = sideNotifSearch[0];
                sideNotifPanel.Dock = DockStyle.Fill;
                pnlSBWorkFlow.Controls.Add(sideNotifPanel);

                sideNotifPanel.BringToFront();
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            plnWorkFlow.Controls.Clear();
            pnlSBWorkFlow.Controls.Clear();

            Project projects = new Project();


            Control mainProjectPanel = projects.Controls["plnProject"];
            Control sidebarProjectPanel = projects.Controls["pnlSBProject"];


            if (mainProjectPanel != null)
            {
                mainProjectPanel.Dock = DockStyle.Fill;
                plnWorkFlow.Controls.Add(mainProjectPanel);
            }


            if (sidebarProjectPanel != null)
            {
                sidebarProjectPanel.Dock = DockStyle.Fill;
                pnlSBWorkFlow.Controls.Add(sidebarProjectPanel);
            }
        }

        private void lblProjectFilter_Click(object sender, EventArgs e)
        {

        }

        private void c4Title_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTodoCount_Click(object sender, EventArgs e)
        {

        }

        private void lblPageTitle_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            plnWorkFlow.Controls.Clear();
            pnlSBWorkFlow.Controls.Clear();

            ProfileForm profileForm = new ProfileForm();

            Control mainProfilePanel = profileForm.Controls["plnProfile"];
            Control sidebarProfilePanel = profileForm.Controls["ProfileBar"];


            if (mainProfilePanel != null)
            {
                mainProfilePanel.Dock = DockStyle.Fill;
                plnWorkFlow.Controls.Add(mainProfilePanel);
            }


            if (sidebarProfilePanel != null)
            {
                sidebarProfilePanel.Dock = DockStyle.Fill;
                pnlSBWorkFlow.Controls.Add(sidebarProfilePanel);
            }

        }
    }
}
