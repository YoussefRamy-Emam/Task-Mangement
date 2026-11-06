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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void checkBox_ShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBox_ShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxConfPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            ErrorCreateAcc.Clear();
            bool isValid = true;

            
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                ErrorCreateAcc.SetError(txtUserName, "Please enter a username.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                ErrorCreateAcc.SetError(txtemail, "Please enter an email address.");
                isValid = false;
            }

            if (txtPassword.Text.Length < 6)
            {
                ErrorCreateAcc.SetError(txtPassword, "Password must be at least 6 characters long.");
                isValid = false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                ErrorCreateAcc.SetError(txtConfirmPassword, "Passwords do not match.");
                isValid = false;
            }
            if(!isValid)
            {
                MessageBox.Show("Please correct the errors and try again. \n All fields must be filled in, and the password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
            else
            {
                MessageBox.Show("Account created successfully; please log in.", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();   
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Your name")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black; 
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Text = "Your name";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Name@Gmail.com")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                txtemail.Text = "Name@Gmail.com";
                txtemail.ForeColor = Color.Gray;
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
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

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "P@$$w0rd")
            {
                txtConfirmPassword.Text = "";
                txtConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.Text = "P@$$w0rd";
                txtConfirmPassword.ForeColor = Color.Gray;
            }
        }
    }
}
