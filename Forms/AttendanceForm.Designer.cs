using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblDate;
        private DateTimePicker dtpAttendanceDate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblRemarks;
        private TextBox txtRemarks;
        private Button btnAddAttendance;
        private Button btnViewByDate;
        private Button btnViewByStudent;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dgvAttendance;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblDate = new Label();
            dtpAttendanceDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();
            btnAddAttendance = new Button();
            btnViewByDate = new Button();
            btnViewByStudent = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvAttendance = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.White;
            lblStudentId.Location = new Point(62, 208);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(85, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(162, 205);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(150, 27);
            txtStudentId.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(62, 152);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(45, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date:";
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Location = new Point(162, 147);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(150, 27);
            dtpAttendanceDate.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(544, 143);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.Items.AddRange(new object[] { "Present", "Absent", "Late", "Leave" });
            cmbStatus.Location = new Point(644, 140);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 28);
            cmbStatus.TabIndex = 5;
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.BackColor = Color.Transparent;
            lblRemarks.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRemarks.ForeColor = Color.White;
            lblRemarks.Location = new Point(544, 212);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(71, 20);
            lblRemarks.TabIndex = 6;
            lblRemarks.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(644, 205);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(200, 27);
            txtRemarks.TabIndex = 7;
            // 
            // btnAddAttendance
            // 
            btnAddAttendance.Location = new Point(882, 172);
            btnAddAttendance.Name = "btnAddAttendance";
            btnAddAttendance.Size = new Size(132, 35);
            btnAddAttendance.TabIndex = 8;
            btnAddAttendance.Text = "Add Attendance";
            btnAddAttendance.Click += btnAddAttendance_Click;
            // 
            // btnViewByDate
            // 
            btnViewByDate.Location = new Point(365, 140);
            btnViewByDate.Name = "btnViewByDate";
            btnViewByDate.Size = new Size(132, 35);
            btnViewByDate.TabIndex = 9;
            btnViewByDate.Text = "View by Date";
            btnViewByDate.Click += btnViewByDate_Click;
            // 
            // btnViewByStudent
            // 
            btnViewByStudent.Location = new Point(365, 201);
            btnViewByStudent.Name = "btnViewByStudent";
            btnViewByStudent.Size = new Size(132, 35);
            btnViewByStudent.TabIndex = 10;
            btnViewByStudent.Text = "View by Student";
            btnViewByStudent.Click += btnViewByStudent_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(388, 553);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 35);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(523, 553);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 35);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeight = 29;
            dgvAttendance.Location = new Point(20, 261);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(1027, 274);
            dgvAttendance.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(514, 52);
            label2.Name = "label2";
            label2.Size = new Size(394, 38);
            label2.TabIndex = 20;
            label2.Text = "Attendance Portal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(143, 19);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 19;
            label1.Text = "EduNex";
            // 
            // AttendanceForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1069, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblStudentId);
            Controls.Add(txtStudentId);
            Controls.Add(lblDate);
            Controls.Add(dtpAttendanceDate);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblRemarks);
            Controls.Add(txtRemarks);
            Controls.Add(btnAddAttendance);
            Controls.Add(btnViewByDate);
            Controls.Add(btnViewByStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvAttendance);
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
    }
}
