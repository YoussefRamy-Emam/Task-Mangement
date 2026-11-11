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
                plnProfile.Controls.Add(mainNotifPanel);

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

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;


            this.Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            errorProviderUser_Email.Clear();
            bool isValid = true;

            // 2. التحقق من حقل الاسم الكامل (Full Name)
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
            {
                errorProviderUser_Email.SetError(fullNameTextBox, "Please enter your full name.");
                isValid = false;
            }

            // 3. التحقق من حقل اسم المستخدم (Username)
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                errorProviderUser_Email.SetError(usernameTextBox, "Please enter a username.");
                isValid = false;
            }

            // 4. التحقق من حقل البريد الإلكتروني (Email)
            if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !emailTextBox.Text.Contains("@"))
            {
                errorProviderUser_Email.SetError(emailTextBox, "Please enter a valid email address.");
                isValid = false;
            }

        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {

            errorProviderPass.Clear();
            bool isValidPass = true;

            if (currentPasswordTextBox.Text == newPasswordTextBox.Text)
            {
                MessageBox.Show("Please enter diffrent password this same password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (!string.IsNullOrEmpty(newPasswordTextBox.Text) || !string.IsNullOrEmpty(confirmPasswordTextBox.Text))
                {
                    if (newPasswordTextBox.Text.Length < 8)
                    {
                        errorProviderUser_Email.SetError(newPasswordTextBox, "Password must be at least 8 characters long.");
                        isValidPass = false;
                    }

                    if (newPasswordTextBox.Text != confirmPasswordTextBox.Text)
                    {
                        errorProviderUser_Email.SetError(confirmPasswordTextBox, "Passwords do not match.");
                        isValidPass = false;
                    }
                }


                if (!isValidPass)
                {
                    MessageBox.Show("Please correct the highlighted errors and try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // هنا يتم حفظ البيانات بنجاح في قاعدة البيانات أو التعديل
                    MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // لو حابب تقفل الشاشة أو تحدث البيانات
                    // this.Close();
                }
            }
            
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
            {
                currentPasswordTextBox.UseSystemPasswordChar = false;
                newPasswordTextBox.UseSystemPasswordChar = false;
                confirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                currentPasswordTextBox.UseSystemPasswordChar = true;
                newPasswordTextBox.UseSystemPasswordChar = true;
                confirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
