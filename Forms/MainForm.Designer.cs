using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnExit = new Button();
            btnLogout = new Button();
            btnClassManagement = new Button();
            btnNotifications = new Button();
            btnReports = new Button();
            btnExamResults = new Button();
            btnFeeManagement = new Button();
            btnAttendance = new Button();
            btnStudentManagement = new Button();
            pnlMenu = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(755, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 30);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(869, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 30);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClassManagement
            // 
            btnClassManagement.Location = new Point(622, 122);
            btnClassManagement.Name = "btnClassManagement";
            btnClassManagement.Size = new Size(180, 60);
            btnClassManagement.TabIndex = 6;
            btnClassManagement.Text = "Class Management";
            btnClassManagement.Click += btnClassManagement_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.Location = new Point(392, 122);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(180, 60);
            btnNotifications.TabIndex = 5;
            btnNotifications.Text = "Notifications";
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(162, 122);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(180, 60);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.Click += btnReports_Click;
            // 
            // btnExamResults
            // 
            btnExamResults.Location = new Point(756, 36);
            btnExamResults.Name = "btnExamResults";
            btnExamResults.Size = new Size(180, 60);
            btnExamResults.TabIndex = 3;
            btnExamResults.Text = "Exam Results";
            btnExamResults.Click += btnExamResults_Click;
            // 
            // btnFeeManagement
            // 
            btnFeeManagement.Location = new Point(526, 36);
            btnFeeManagement.Name = "btnFeeManagement";
            btnFeeManagement.Size = new Size(180, 60);
            btnFeeManagement.TabIndex = 2;
            btnFeeManagement.Text = "Fee Management";
            btnFeeManagement.Click += btnFeeManagement_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(296, 36);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(180, 60);
            btnAttendance.TabIndex = 1;
            btnAttendance.Text = "Attendance Tracking";
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.Location = new Point(66, 36);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(180, 60);
            btnStudentManagement.TabIndex = 0;
            btnStudentManagement.Text = "Student Management";
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Transparent;
            pnlMenu.Controls.Add(btnStudentManagement);
            pnlMenu.Controls.Add(btnAttendance);
            pnlMenu.Controls.Add(btnFeeManagement);
            pnlMenu.Controls.Add(btnExamResults);
            pnlMenu.Controls.Add(btnReports);
            pnlMenu.Controls.Add(btnNotifications);
            pnlMenu.Controls.Add(btnClassManagement);
            pnlMenu.Location = new Point(12, 241);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(945, 237);
            pnlMenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 26;
            label1.Text = "EduNex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(117, 175);
            label2.Name = "label2";
            label2.Size = new Size(798, 38);
            label2.TabIndex = 27;
            label2.Text = "The Smartest Class Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(174, 497);
            label3.Name = "label3";
            label3.Size = new Size(607, 32);
            label3.TabIndex = 28;
            label3.Text = "Focus on Teaching. Let EduNex Handle the Rest.";
            // 
            // MainForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(979, 557);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlMenu);
            Controls.Add(btnLogout);
            Controls.Add(btnExit);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnExit;
        private Button btnLogout;
        private Button btnClassManagement;
        private Button btnNotifications;
        private Button btnReports;
        private Button btnExamResults;
        private Button btnFeeManagement;
        private Button btnAttendance;
        private Button btnStudentManagement;
        private Panel pnlMenu;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
