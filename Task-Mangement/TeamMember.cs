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
    public partial class TeamMember : Form
    {
        public TeamMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Team Member has been saved successfully.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
