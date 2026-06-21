using System;
using System.Windows.Forms;

namespace EduNex
{
    public partial class MainForm : Form
    {
        private int _teacherId = 0;
        private string _teacherName = "";

        public MainForm(int teacherId, string teacherName)
        {
            InitializeComponent();
            _teacherId = teacherId;
            _teacherName = teacherName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"EduNex - Main Dashboard - Welcome {_teacherName}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(997, 604);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Log wela inna user ge details gannawa
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            // Admin nemei nam button eke text ekata lock symbol eka add karanawa
            if (!isAdmin)
            {
                btnClassManagement.Text = "🔒 Class Management";
            }
            else
            {
                btnClassManagement.Text = "Class Management"; // Admin nam normal penawa
            }
        }

        private void btnStudentManagement_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(_teacherId);
            studentForm.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm(_teacherId);
            attendanceForm.Show();
        }

        private void btnFeeManagement_Click(object sender, EventArgs e)
        {
            FeeForm feeForm = new FeeForm(_teacherId);
            feeForm.Show();
        }

        private void btnExamResults_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm(_teacherId);
            examForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(_teacherId);
            reportForm.Show();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            NotificationForm notificationForm = new NotificationForm(_teacherId);
            notificationForm.Show();
        }

        private void btnClassManagement_Click(object sender, EventArgs e)
        {
            // Log wela inna user ge details database eken aran admin da balanawa
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            if (isAdmin)
            {
                // Admin nam form eka open wenawa
                ClassManagementForm classForm = new ClassManagementForm(_teacherId);
                classForm.Show();
            }
            else
            {
                // Admin nemei nam warning message ekak pennanawa
                MessageBox.Show("Admin access needed! You do not have permission to access Class Management.",
                                "Access Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
