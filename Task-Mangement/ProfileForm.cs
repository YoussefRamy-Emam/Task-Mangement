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

        private void ProfileBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
