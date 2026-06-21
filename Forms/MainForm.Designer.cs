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
            components = new System.ComponentModel.Container();
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
            panel3 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            lblDateTime = new Label();
            panel2 = new Panel();
            lblWelcomeUser = new Label();
            monthCalendar1 = new MonthCalendar();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panel4 = new Panel();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Violet;
            btnExit.Font = new Font("Microsoft JhengHei UI", 10.8F);
            btnExit.Location = new Point(867, 31);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 41);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Violet;
            btnLogout.Font = new Font("Microsoft JhengHei UI", 10.8F);
            btnLogout.Location = new Point(771, 31);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 41);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClassManagement
            // 
            btnClassManagement.BackColor = Color.LightSeaGreen;
            btnClassManagement.Font = new Font("Microsoft JhengHei UI", 12F);
            btnClassManagement.Location = new Point(382, 142);
            btnClassManagement.Name = "btnClassManagement";
            btnClassManagement.Size = new Size(240, 69);
            btnClassManagement.TabIndex = 6;
            btnClassManagement.Text = "Class Management";
            btnClassManagement.UseVisualStyleBackColor = false;
            btnClassManagement.Click += btnClassManagement_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.Lavender;
            btnNotifications.Font = new Font("Microsoft JhengHei UI", 12F);
            btnNotifications.Location = new Point(9, 99);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(262, 60);
            btnNotifications.TabIndex = 5;
            btnNotifications.Text = "Notifications";
            btnNotifications.UseVisualStyleBackColor = false;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.LightSeaGreen;
            btnReports.Font = new Font("Microsoft JhengHei UI", 12F);
            btnReports.Location = new Point(66, 260);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(240, 69);
            btnReports.TabIndex = 4;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnExamResults
            // 
            btnExamResults.BackColor = Color.LightSeaGreen;
            btnExamResults.Font = new Font("Microsoft JhengHei UI", 12F);
            btnExamResults.Location = new Point(382, 260);
            btnExamResults.Name = "btnExamResults";
            btnExamResults.Size = new Size(240, 69);
            btnExamResults.TabIndex = 3;
            btnExamResults.Text = "Exam Results";
            btnExamResults.UseVisualStyleBackColor = false;
            btnExamResults.Click += btnExamResults_Click;
            // 
            // btnFeeManagement
            // 
            btnFeeManagement.BackColor = Color.LightSeaGreen;
            btnFeeManagement.Font = new Font("Microsoft JhengHei UI", 12F);
            btnFeeManagement.Location = new Point(382, 21);
            btnFeeManagement.Name = "btnFeeManagement";
            btnFeeManagement.Size = new Size(240, 69);
            btnFeeManagement.TabIndex = 2;
            btnFeeManagement.Text = "Fee Management";
            btnFeeManagement.UseVisualStyleBackColor = false;
            btnFeeManagement.Click += btnFeeManagement_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.LightSeaGreen;
            btnAttendance.Font = new Font("Microsoft JhengHei UI", 12F);
            btnAttendance.Location = new Point(66, 142);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(240, 69);
            btnAttendance.TabIndex = 1;
            btnAttendance.Text = "Attendance Tracking";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnStudentManagement
            // 
            btnStudentManagement.BackColor = Color.LightSeaGreen;
            btnStudentManagement.Font = new Font("Microsoft JhengHei UI", 12F);
            btnStudentManagement.Location = new Point(66, 21);
            btnStudentManagement.Name = "btnStudentManagement";
            btnStudentManagement.Size = new Size(240, 69);
            btnStudentManagement.TabIndex = 0;
            btnStudentManagement.Text = "Student Management";
            btnStudentManagement.UseVisualStyleBackColor = false;
            btnStudentManagement.Click += btnStudentManagement_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Transparent;
            pnlMenu.Controls.Add(panel3);
            pnlMenu.Controls.Add(btnStudentManagement);
            pnlMenu.Controls.Add(btnAttendance);
            pnlMenu.Controls.Add(btnFeeManagement);
            pnlMenu.Controls.Add(btnExamResults);
            pnlMenu.Controls.Add(btnReports);
            pnlMenu.Controls.Add(btnClassManagement);
            pnlMenu.Location = new Point(306, 177);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(674, 377);
            pnlMenu.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Location = new Point(-224, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(980, 27);
            panel3.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(306, 72);
            label3.Name = "label3";
            label3.Size = new Size(398, 20);
            label3.TabIndex = 28;
            label3.Text = "Focus on Teaching. Let EduNex Handle the Rest.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-48, -74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 107);
            panel1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(420, 23);
            label2.Name = "label2";
            label2.Size = new Size(195, 38);
            label2.TabIndex = 30;
            label2.Text = "Welcome";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.ForeColor = Color.AliceBlue;
            lblDateTime.Location = new Point(595, 120);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(385, 25);
            lblDateTime.TabIndex = 31;
            lblDateTime.Text = "Date&time-------------------------------------------";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Indigo;
            panel2.Controls.Add(lblWelcomeUser);
            panel2.Controls.Add(monthCalendar1);
            panel2.Controls.Add(btnNotifications);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 458);
            panel2.TabIndex = 7;
            // 
            // lblWelcomeUser
            // 
            lblWelcomeUser.AutoSize = true;
            lblWelcomeUser.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeUser.ForeColor = Color.White;
            lblWelcomeUser.Location = new Point(98, 37);
            lblWelcomeUser.Name = "lblWelcomeUser";
            lblWelcomeUser.Size = new Size(104, 28);
            lblWelcomeUser.TabIndex = 32;
            lblWelcomeUser.Text = "Username";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(9, 191);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 31;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumVioletRed;
            label1.Location = new Point(365, 5);
            label1.Name = "label1";
            label1.Size = new Size(307, 25);
            label1.TabIndex = 31;
            label1.Text = "© 2026 EduNex. All Rights Reserved. ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumVioletRed;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(1, 560);
            panel4.Name = "panel4";
            panel4.Size = new Size(1012, 34);
            panel4.TabIndex = 32;
            // 
            // MainForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1013, 595);
            Controls.Add(lblDateTime);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlMenu);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Label lblDateTime;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label lblWelcomeUser;
        private MonthCalendar monthCalendar1;
    }
}
