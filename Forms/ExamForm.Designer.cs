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
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.White;
            lblStudentId.Location = new Point(515, 155);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(85, 20);
            lblStudentId.TabIndex = 18;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(655, 157);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(120, 27);
            txtStudentId.TabIndex = 17;
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.BackColor = Color.Transparent;
            lblExamName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblExamName.ForeColor = Color.White;
            lblExamName.Location = new Point(41, 163);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(95, 20);
            lblExamName.TabIndex = 16;
            lblExamName.Text = "Exam Name:";
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(159, 163);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(150, 27);
            txtExamName.TabIndex = 15;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.BackColor = Color.Transparent;
            lblSubject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSubject.ForeColor = Color.White;
            lblSubject.Location = new Point(515, 203);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(63, 20);
            lblSubject.TabIndex = 14;
            lblSubject.Text = "Subject:";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(655, 202);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(120, 27);
            txtSubject.TabIndex = 13;
            // 
            // lblMarksObtained
            // 
            lblMarksObtained.AutoSize = true;
            lblMarksObtained.BackColor = Color.Transparent;
            lblMarksObtained.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMarksObtained.ForeColor = Color.White;
            lblMarksObtained.Location = new Point(515, 247);
            lblMarksObtained.Name = "lblMarksObtained";
            lblMarksObtained.Size = new Size(122, 20);
            lblMarksObtained.TabIndex = 12;
            lblMarksObtained.Text = "Marks Obtained:";
            // 
            // txtMarksObtained
            // 
            txtMarksObtained.Location = new Point(655, 244);
            txtMarksObtained.Name = "txtMarksObtained";
            txtMarksObtained.Size = new Size(120, 27);
            txtMarksObtained.TabIndex = 11;
            // 
            // lblTotalMarks
            // 
            lblTotalMarks.AutoSize = true;
            lblTotalMarks.Location = new Point(506, 325);
            lblTotalMarks.Name = "lblTotalMarks";
            lblTotalMarks.Size = new Size(92, 20);
            lblTotalMarks.TabIndex = 10;
            lblTotalMarks.Text = "Total Marks:";
            // 
            // txtTotalMarks
            // 
            txtTotalMarks.Location = new Point(646, 322);
            txtTotalMarks.Name = "txtTotalMarks";
            txtTotalMarks.Size = new Size(120, 27);
            txtTotalMarks.TabIndex = 9;
            // 
            // lblExamDate
            // 
            lblExamDate.AutoSize = true;
            lblExamDate.BackColor = Color.Transparent;
            lblExamDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblExamDate.ForeColor = Color.White;
            lblExamDate.Location = new Point(41, 209);
            lblExamDate.Name = "lblExamDate";
            lblExamDate.Size = new Size(86, 20);
            lblExamDate.TabIndex = 8;
            lblExamDate.Text = "Exam Date:";
            // 
            // dtpExamDate
            // 
            dtpExamDate.Location = new Point(159, 209);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(150, 27);
            dtpExamDate.TabIndex = 7;
            // 
            // btnAddResult
            // 
            btnAddResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddResult.ForeColor = Color.Black;
            btnAddResult.Location = new Point(807, 221);
            btnAddResult.Name = "btnAddResult";
            btnAddResult.Size = new Size(135, 30);
            btnAddResult.TabIndex = 6;
            btnAddResult.Text = "Add Result";
            btnAddResult.UseVisualStyleBackColor = true;
            btnAddResult.Click += btnAddResult_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(798, 325);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(240, 585);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewByStudent
            // 
            btnViewByStudent.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewByStudent.ForeColor = Color.Black;
            btnViewByStudent.Location = new Point(807, 155);
            btnViewByStudent.Name = "btnViewByStudent";
            btnViewByStudent.Size = new Size(135, 30);
            btnViewByStudent.TabIndex = 3;
            btnViewByStudent.Text = "By Student";
            btnViewByStudent.UseVisualStyleBackColor = true;
            btnViewByStudent.Click += btnViewByStudent_Click;
            // 
            // btnViewByExam
            // 
            btnViewByExam.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewByExam.ForeColor = Color.Black;
            btnViewByExam.Location = new Point(338, 163);
            btnViewByExam.Name = "btnViewByExam";
            btnViewByExam.Size = new Size(135, 30);
            btnViewByExam.TabIndex = 2;
            btnViewByExam.Text = "By Exam";
            btnViewByExam.UseVisualStyleBackColor = true;
            btnViewByExam.Click += btnViewByExam_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(570, 585);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(135, 30);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvResults
            // 
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResults.BackgroundColor = Color.DimGray;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.GridColor = Color.White;
            dgvResults.Location = new Point(20, 308);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 51;
            dgvResults.Size = new Size(940, 262);
            dgvResults.TabIndex = 0;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            dgvResults.SelectionChanged += dgvResults_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(506, 66);
            label2.Name = "label2";
            label2.Size = new Size(350, 38);
            label2.TabIndex = 24;
            label2.Text = "Exam Managment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 33);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 23;
            label1.Text = "EduNex";
            // 
            // ExamForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 650);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ForeColor = Color.White;
            Name = "ExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam Management";
            Load += ExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
    }
}
