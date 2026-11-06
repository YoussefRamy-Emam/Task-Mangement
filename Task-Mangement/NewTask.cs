using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Mangement
{

    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPersonalBadge_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbldescripition_Click(object sender, EventArgs e)
        {

        }

        private void NewTask_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lbldeadline_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                    }

        private void lbltittle_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The task has been saved successfully.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            this.Close();
        }

        private void btnlow_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUrgent_Click(object sender, EventArgs e)
        {
            
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
