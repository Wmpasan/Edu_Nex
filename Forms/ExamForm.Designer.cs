using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class ExamForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblExamName;
        private TextBox txtExamName;
        private Label lblSubject;
        private TextBox txtSubject;
        private Label lblMarksObtained;
        private TextBox txtMarksObtained;
        private Label lblTotalMarks;
        private TextBox txtTotalMarks;
        private Label lblExamDate;
        private DateTimePicker dtpExamDate;
        private Button btnAddResult;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnViewByStudent;
        private Button btnViewByExam;
        private Button btnRefresh;
        private DataGridView dgvResults;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblExamName = new Label();
            txtExamName = new TextBox();
            lblSubject = new Label();
            txtSubject = new TextBox();
            lblMarksObtained = new Label();
            txtMarksObtained = new TextBox();
            lblTotalMarks = new Label();
            txtTotalMarks = new TextBox();
            lblExamDate = new Label();
            dtpExamDate = new DateTimePicker();
            btnAddResult = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnViewByStudent = new Button();
            btnViewByExam = new Button();
            btnRefresh = new Button();
            dgvResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(20, 20);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(82, 20);
            lblStudentId.TabIndex = 18;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(160, 22);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(120, 27);
            txtStudentId.TabIndex = 17;
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Location = new Point(503, 61);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(92, 20);
            lblExamName.TabIndex = 16;
            lblExamName.Text = "Exam Name:";
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(621, 61);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(150, 27);
            txtExamName.TabIndex = 15;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(20, 68);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(61, 20);
            lblSubject.TabIndex = 14;
            lblSubject.Text = "Subject:";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(160, 67);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(120, 27);
            txtSubject.TabIndex = 13;
            // 
            // lblMarksObtained
            // 
            lblMarksObtained.AutoSize = true;
            lblMarksObtained.Location = new Point(20, 112);
            lblMarksObtained.Name = "lblMarksObtained";
            lblMarksObtained.Size = new Size(117, 20);
            lblMarksObtained.TabIndex = 12;
            lblMarksObtained.Text = "Marks Obtained:";
            // 
            // txtMarksObtained
            // 
            txtMarksObtained.Location = new Point(160, 109);
            txtMarksObtained.Name = "txtMarksObtained";
            txtMarksObtained.Size = new Size(120, 27);
            txtMarksObtained.TabIndex = 11;
            // 
            // lblTotalMarks
            // 
            lblTotalMarks.AutoSize = true;
            lblTotalMarks.Location = new Point(20, 154);
            lblTotalMarks.Name = "lblTotalMarks";
            lblTotalMarks.Size = new Size(88, 20);
            lblTotalMarks.TabIndex = 10;
            lblTotalMarks.Text = "Total Marks:";
            // 
            // txtTotalMarks
            // 
            txtTotalMarks.Location = new Point(160, 151);
            txtTotalMarks.Name = "txtTotalMarks";
            txtTotalMarks.Size = new Size(120, 27);
            txtTotalMarks.TabIndex = 9;
            // 
            // lblExamDate
            // 
            lblExamDate.AutoSize = true;
            lblExamDate.Location = new Point(503, 107);
            lblExamDate.Name = "lblExamDate";
            lblExamDate.Size = new Size(84, 20);
            lblExamDate.TabIndex = 8;
            lblExamDate.Text = "Exam Date:";
            // 
            // dtpExamDate
            // 
            dtpExamDate.Location = new Point(621, 107);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(150, 27);
            dtpExamDate.TabIndex = 7;
            // 
            // btnAddResult
            // 
            btnAddResult.Location = new Point(312, 86);
            btnAddResult.Name = "btnAddResult";
            btnAddResult.Size = new Size(135, 30);
            btnAddResult.TabIndex = 6;
            btnAddResult.Text = "Add Result";
            btnAddResult.UseVisualStyleBackColor = true;
            btnAddResult.Click += btnAddResult_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(312, 154);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(240, 585);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewByStudent
            // 
            btnViewByStudent.Location = new Point(312, 20);
            btnViewByStudent.Name = "btnViewByStudent";
            btnViewByStudent.Size = new Size(135, 30);
            btnViewByStudent.TabIndex = 3;
            btnViewByStudent.Text = "By Student";
            btnViewByStudent.UseVisualStyleBackColor = true;
            btnViewByStudent.Click += btnViewByStudent_Click;
            // 
            // btnViewByExam
            // 
            btnViewByExam.Location = new Point(798, 79);
            btnViewByExam.Name = "btnViewByExam";
            btnViewByExam.Size = new Size(135, 30);
            btnViewByExam.TabIndex = 2;
            btnViewByExam.Text = "By Exam";
            btnViewByExam.UseVisualStyleBackColor = true;
            btnViewByExam.Click += btnViewByExam_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(570, 585);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 40);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvResults
            // 
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(20, 308);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(940, 262);
            dgvResults.TabIndex = 0;
            dgvResults.SelectionChanged += dgvResults_SelectionChanged;
            // 
            // ExamForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 650);
            Controls.Add(dgvResults);
            Controls.Add(btnRefresh);
            Controls.Add(btnViewByExam);
            Controls.Add(btnViewByStudent);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddResult);
            Controls.Add(dtpExamDate);
            Controls.Add(lblExamDate);
            Controls.Add(txtTotalMarks);
            Controls.Add(lblTotalMarks);
            Controls.Add(txtMarksObtained);
            Controls.Add(lblMarksObtained);
            Controls.Add(txtSubject);
            Controls.Add(lblSubject);
            Controls.Add(txtExamName);
            Controls.Add(lblExamName);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Name = "ExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Management";
            Load += ExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
