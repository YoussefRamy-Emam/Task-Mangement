using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Mangement
{
    public partial class New_Project_Task : Form
    {
        public New_Project_Task()
        {
            InitializeComponent();
        }

        private void lblpriority_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The task has been saved successfully.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PriorityButton_Click(object sender, EventArgs e)
        {
            btnLow.BackColor = Color.WhiteSmoke;
            btnMedium.BackColor = Color.WhiteSmoke;
            btnHigh.BackColor = Color.WhiteSmoke;
            btnUrgent.BackColor = Color.WhiteSmoke;

            Button clickedBtn = (Button)sender;
            clickedBtn.BackColor = Color.Moccasin;
        }
    }
}
