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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblRememder_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            this.Hide();
            //الكود هيقف هنا لحد ما يسجل دخول و يجرع ل تسجيل الدخول 
            createAccount.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorLogin.Clear();
            bool isValid = true;


            

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                errorLogin.SetError(textBoxEmail, "Please enter an email address.");
                isValid = false;
            }

            if (txtPassword.Text.Length < 6)
            {
                errorLogin.SetError(txtPassword, "Password must be at least 6 characters long.");
                isValid = false;
            }

            
            if (!isValid)
            {
                MessageBox.Show("Please enter correct the Email and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                MessageBox.Show("Login successfully.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            


            Dashboard dashboard = new Dashboard();

            this.Hide();

            dashboard.ShowDialog();

            
            if (dashboard.DialogResult == DialogResult.Yes)
            {
                
                this.Show();
            }
            else
            {
                
                Application.Exit();
            }
        }

        private void checkBox_Remember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_ShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Name@Gmail.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = "Name@Gmail.com";
                textBoxEmail.ForeColor = Color.Gray;
            }
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

  

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "P@$$w0rd")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "P@$$w0rd";
                txtPassword.ForeColor = Color.Gray;
            }
        }
    }
}
