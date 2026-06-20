using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class ClassManagementForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblClassName;
        private TextBox txtClassName;
        private Label lblSection;
        private TextBox txtSection;
        private Label lblClassTeacher;
        private ComboBox cmbClassTeacher;
        private Label lblRoom;
        private TextBox txtRoom;
        private Label lblSchedule;
        private TextBox txtSchedule;
        private Label lblTotalStudents;
        private TextBox txtTotalStudents;
        private Button btnAddClass;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnClear;
        private DataGridView dgvClasses;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassManagementForm));
            lblClassName = new Label();
            txtClassName = new TextBox();
            lblSection = new Label();
            txtSection = new TextBox();
            lblClassTeacher = new Label();
            cmbClassTeacher = new ComboBox();
            lblRoom = new Label();
            txtRoom = new TextBox();
            lblSchedule = new Label();
            txtSchedule = new TextBox();
            lblTotalStudents = new Label();
            txtTotalStudents = new TextBox();
            btnAddClass = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnClear = new Button();
            dgvClasses = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            SuspendLayout();
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.BackColor = Color.Transparent;
            lblClassName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblClassName.ForeColor = Color.White;
            lblClassName.Location = new Point(43, 116);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(91, 20);
            lblClassName.TabIndex = 17;
            lblClassName.Text = "Class Name:";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(153, 116);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(150, 27);
            txtClassName.TabIndex = 16;
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.BackColor = Color.Transparent;
            lblSection.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSection.ForeColor = Color.White;
            lblSection.Location = new Point(333, 116);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(63, 20);
            lblSection.TabIndex = 15;
            lblSection.Text = "Section:";
            // 
            // txtSection
            // 
            txtSection.Location = new Point(457, 113);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(100, 27);
            txtSection.TabIndex = 14;
            // 
            // lblClassTeacher
            // 
            lblClassTeacher.AutoSize = true;
            lblClassTeacher.BackColor = Color.Transparent;
            lblClassTeacher.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblClassTeacher.ForeColor = Color.White;
            lblClassTeacher.Location = new Point(43, 170);
            lblClassTeacher.Name = "lblClassTeacher";
            lblClassTeacher.Size = new Size(104, 20);
            lblClassTeacher.TabIndex = 13;
            lblClassTeacher.Text = "Class Teacher:";
            // 
            // cmbClassTeacher
            // 
            cmbClassTeacher.FormattingEnabled = true;
            cmbClassTeacher.Location = new Point(153, 167);
            cmbClassTeacher.Name = "cmbClassTeacher";
            cmbClassTeacher.Size = new Size(150, 28);
            cmbClassTeacher.TabIndex = 12;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.BackColor = Color.Transparent;
            lblRoom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRoom.ForeColor = Color.White;
            lblRoom.Location = new Point(587, 116);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(53, 20);
            lblRoom.TabIndex = 11;
            lblRoom.Text = "Room:";
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(685, 116);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(150, 27);
            txtRoom.TabIndex = 10;
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.BackColor = Color.Transparent;
            lblSchedule.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSchedule.ForeColor = Color.White;
            lblSchedule.Location = new Point(587, 170);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(75, 20);
            lblSchedule.TabIndex = 9;
            lblSchedule.Text = "Schedule:";
            // 
            // txtSchedule
            // 
            txtSchedule.Location = new Point(685, 173);
            txtSchedule.Multiline = true;
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(150, 27);
            txtSchedule.TabIndex = 8;
            // 
            // lblTotalStudents
            // 
            lblTotalStudents.AutoSize = true;
            lblTotalStudents.BackColor = Color.Transparent;
            lblTotalStudents.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTotalStudents.ForeColor = Color.White;
            lblTotalStudents.Location = new Point(333, 173);
            lblTotalStudents.Name = "lblTotalStudents";
            lblTotalStudents.Size = new Size(109, 20);
            lblTotalStudents.TabIndex = 7;
            lblTotalStudents.Text = "Total Students:";
            // 
            // txtTotalStudents
            // 
            txtTotalStudents.Location = new Point(457, 167);
            txtTotalStudents.Name = "txtTotalStudents";
            txtTotalStudents.Size = new Size(100, 27);
            txtTotalStudents.TabIndex = 6;
            // 
            // btnAddClass
            // 
            btnAddClass.Location = new Point(860, 149);
            btnAddClass.Name = "btnAddClass";
            btnAddClass.Size = new Size(100, 34);
            btnAddClass.TabIndex = 5;
            btnAddClass.Text = "Add Class";
            btnAddClass.UseVisualStyleBackColor = true;
            btnAddClass.Click += btnAddClass_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(860, 109);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 34);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(521, 598);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(385, 598);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(860, 188);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvClasses
            // 
            dgvClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClasses.BackgroundColor = Color.White;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.Location = new Point(43, 232);
            dgvClasses.Name = "dgvClasses";
            dgvClasses.RowHeadersWidth = 51;
            dgvClasses.Size = new Size(917, 350);
            dgvClasses.TabIndex = 0;
            dgvClasses.SelectionChanged += dgvClasses_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(513, 42);
            label2.Name = "label2";
            label2.Size = new Size(365, 38);
            label2.TabIndex = 22;
            label2.Text = "Class Managment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 21;
            label1.Text = "EduNex";
            label1.Click += label1_Click;
            // 
            // ClassManagementForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 650);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvClasses);
            Controls.Add(btnClear);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddClass);
            Controls.Add(txtTotalStudents);
            Controls.Add(lblTotalStudents);
            Controls.Add(txtSchedule);
            Controls.Add(lblSchedule);
            Controls.Add(txtRoom);
            Controls.Add(lblRoom);
            Controls.Add(cmbClassTeacher);
            Controls.Add(lblClassTeacher);
            Controls.Add(txtSection);
            Controls.Add(lblSection);
            Controls.Add(txtClassName);
            Controls.Add(lblClassName);
            Name = "ClassManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Management";
            Load += ClassManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
    }
}
