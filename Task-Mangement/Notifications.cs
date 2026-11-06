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
    public partial class Notifications : Form
    {
        public Notifications()
        {
            InitializeComponent();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {

        }

        private void btnFilterCompleted_Click(object sender, EventArgs e)
        {

        }

        private void card1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            pnlMainNotif.Controls.Clear();
            pnlSBNotif.Controls.Clear();

            Dashboard dashboardForm = new Dashboard();

            Control mainDashPanel = dashboardForm.Controls["plnMainDashboard"];
            Control sidebarDashPanel = dashboardForm.Controls["pnlSBMainDashboard"];

            if (mainDashPanel != null)
            {
                mainDashPanel.Dock = DockStyle.Fill;
                pnlMainNotif.Controls.Add(mainDashPanel);
            }

            if (sidebarDashPanel != null)
            {
                sidebarDashPanel.Dock = DockStyle.Fill;
                pnlSBNotif.Controls.Add(sidebarDashPanel);
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            pnlMainNotif.Controls.Clear();
            pnlSBNotif.Controls.Clear();

            Project projects = new Project();


            Control mainProjectPanel = projects.Controls["plnProject"];
            Control sidebarProjectPanel = projects.Controls["pnlSBProject"];


            if (mainProjectPanel != null)
            {
                mainProjectPanel.Dock = DockStyle.Fill;
                pnlMainNotif.Controls.Add(mainProjectPanel);
            }


            if (sidebarProjectPanel != null)
            {
                sidebarProjectPanel.Dock = DockStyle.Fill;
                pnlSBNotif.Controls.Add(sidebarProjectPanel);
            }
        }

        private void btnWorkFlowBoard_Click(object sender, EventArgs e)
        {
            pnlMainNotif.Controls.Clear();
            pnlSBNotif.Controls.Clear();

            WorkFlow workFlowForm = new WorkFlow();


            Control mainWorkFlowPanel = workFlowForm.Controls["plnWorkFlow"];
            Control sidebarWorkFlowPanel = workFlowForm.Controls["pnlSBWorkFlow"];


            if (mainWorkFlowPanel != null)
            {
                mainWorkFlowPanel.Dock = DockStyle.Fill;
                pnlMainNotif.Controls.Add(mainWorkFlowPanel);
            }


            if (sidebarWorkFlowPanel != null)
            {
                sidebarWorkFlowPanel.Dock = DockStyle.Fill;
                pnlSBNotif.Controls.Add(sidebarWorkFlowPanel);
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {

        }
    }
}
