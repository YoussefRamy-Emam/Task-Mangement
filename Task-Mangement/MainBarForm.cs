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
    public partial class MainBarForm : Form
    {
        public MainBarForm()
        {
            InitializeComponent();
            MainBarForm_Load(null, null);
        }

        // 1. حدث فتح الفورم لأول مرة (بيخلي زر الداشبورد يفتح تلقائياً أول ما تدخل)
        private void MainBarForm_Load(object sender, EventArgs e)
        {
            btnNavDashboard_Click(btnNavDashboard, EventArgs.Empty);
            Dashboard DashBoardForm = new Dashboard();
            Control mainDashboardPanel = DashBoardForm.Controls["plnMainDashboard"];

            if (mainDashboardPanel != null)
            {
                LoadMainScreen(mainDashboardPanel);
            }
        }

        // 2. دالة تلوين الأزرار (تفعيل الزر المضغوط وإلغاء الباقي)
        private void SetActiveButton(Button activeBtn)
        {
            Button[] allButtons = { btnNavDashboard, btnProjects, btnWorkFlowBoard, btnReport, btnProfile, btnNotifications };

            foreach (Button btn in allButtons)
            {
                if (btn == activeBtn)
                {
                    // الزر النشط - لون أزرق
                    btn.BackColor = Color.FromArgb(47, 111, 237);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(47, 111, 237);
                    btn.ForeColor = Color.White;
                }
                else
                {
                    // الأزرار غير النشطة - اللون الغامق
                    btn.BackColor = Color.FromArgb(27, 37, 64);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(27, 37, 64);
                    btn.ForeColor = SystemColors.ControlDark;
                }
                btn.FlatStyle = FlatStyle.Flat;
            }
        }

        // 3. دالة تفريغ وعرض الـ Control أو الـ Panel داخل الشاشة الرئيسية
        private void LoadMainScreen(Control screenControl)
        {
            plnMainPanel.Controls.Clear();
            screenControl.Dock = DockStyle.Fill;
            plnMainPanel.Controls.Add(screenControl);
            screenControl.BringToFront();
        }

        // 4. زر الـ Dashboard
        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavDashboard);

            Dashboard DashBoardForm = new Dashboard();
            Control mainDashboardPanel = DashBoardForm.Controls["plnMainDashboard"];

            if (mainDashboardPanel != null)
            {
                LoadMainScreen(mainDashboardPanel);
            }
        }

        // 5. زر الـ Projects (بسحب الـ Panel بتاعتك زي ما كنت عامل)
        private void btnProjects_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProjects);

            Project projectsForm = new Project();
            Control mainProjectPanel = projectsForm.Controls["plnProject"];

            if (mainProjectPanel != null)
            {
                LoadMainScreen(mainProjectPanel);
            }
        }

        // 6. زر الـ WorkFlow Board
        private void btnWorkFlowBoard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnWorkFlowBoard);

            WorkFlow workFlowForm = new WorkFlow();

            Control mainWorkFlowPanel = workFlowForm.Controls["plnWorkFlow"];


            if (mainWorkFlowPanel != null)
            {
                LoadMainScreen(mainWorkFlowPanel);
            }

        }

        // 7. زر الـ Profile
        private void btnProfile_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnProfile);

            ProfileForm profileForm = new ProfileForm();

            Control mainProfilePanel = profileForm.Controls["plnProfile"];


            if (mainProfilePanel != null)
            {
                LoadMainScreen(mainProfilePanel);
            }

        }

        // 8. زر الـ Notifications
        private void btnNotifications_Click(object sender, EventArgs e)
        {
            
            SetActiveButton(btnNotifications);

            // 2. إنشاء كائن من شاشة Notifications
            Notifications notificationsForm = new Notifications();

            // 3. البحث عن الـ Panel الرئيسية بالطريقة المضمونة بتاعتك
            Control[] mainNotifSearch = notificationsForm.Controls.Find("pnlMainNotif", true);

            if (mainNotifSearch.Length > 0)
            {
                Control mainNotifPanel = mainNotifSearch[0];

                // 4. عرضها باستخدام دالة التحميل الموحدة بتاعتنا
                LoadMainScreen(mainNotifPanel);
            }
            else
            {
                MessageBox.Show("خطأ: لم يتم العثور على الـ Panel المطلوبة!");
            }

        }

        // 9. زر تسجيل الخروج (Sign Out)
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            
            this.Close(); 
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReport);

            ReportForm reportsForm = new   ReportForm();

            Control mainReportsPanel = reportsForm.Controls["plnReport"];


            if (mainReportsPanel != null)
            {
                LoadMainScreen(mainReportsPanel);
            }
        }
    }
}