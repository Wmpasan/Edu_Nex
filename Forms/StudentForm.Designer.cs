using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private TextBox txtName;
        private Label lblRollNumber;
        private TextBox txtRollNumber;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblParentName;
        private TextBox txtParentName;
        private Label lblParentPhone;
        private TextBox txtParentPhoneNumber;
        private Label lblParentEmail;
        private TextBox txtParentEmail;
        private Label lblClass;
        private ComboBox cmbClass;
        private Label lblMonthlyFee;
        private TextBox txtMonthlyFee;
        private Button btnAddStudent;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvStudents;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            lblName = new Label();
            txtName = new TextBox();
            lblRollNumber = new Label();
            txtRollNumber = new TextBox();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblParentName = new Label();
            txtParentName = new TextBox();
            lblParentPhone = new Label();
            txtParentPhoneNumber = new TextBox();
            lblParentEmail = new Label();
            txtParentEmail = new TextBox();
            lblClass = new Label();
            cmbClass = new ComboBox();
            lblMonthlyFee = new Label();
            txtMonthlyFee = new TextBox();
            btnAddStudent = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvStudents = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(20, 180);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 26;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 177);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 27);
            txtName.TabIndex = 25;
            // 
            // lblRollNumber
            // 
            lblRollNumber.AutoSize = true;
            lblRollNumber.BackColor = Color.Transparent;
            lblRollNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblRollNumber.ForeColor = Color.White;
            lblRollNumber.Location = new Point(20, 147);
            lblRollNumber.Name = "lblRollNumber";
            lblRollNumber.Size = new Size(128, 20);
            lblRollNumber.TabIndex = 24;
            lblRollNumber.Text = "Student Number:";
            // 
            // txtRollNumber
            // 
            txtRollNumber.Location = new Point(150, 144);
            txtRollNumber.Name = "txtRollNumber";
            txtRollNumber.Size = new Size(182, 27);
            txtRollNumber.TabIndex = 23;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.Transparent;
            lblDateOfBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDateOfBirth.ForeColor = Color.White;
            lblDateOfBirth.Location = new Point(20, 282);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(44, 20);
            lblDateOfBirth.TabIndex = 22;
            lblDateOfBirth.Text = "DOB:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(150, 277);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(182, 27);
            dtpDateOfBirth.TabIndex = 21;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.White;
            lblGender.Location = new Point(20, 213);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 20);
            lblGender.TabIndex = 20;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(150, 210);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 28);
            cmbGender.TabIndex = 19;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(652, 151);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 18;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(652, 180);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(290, 40);
            txtAddress.TabIndex = 17;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.Transparent;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.White;
            lblPhoneNumber.Location = new Point(20, 247);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(57, 20);
            lblPhoneNumber.TabIndex = 16;
            lblPhoneNumber.Text = "Phone:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(150, 244);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(182, 27);
            txtPhoneNumber.TabIndex = 15;
            // 
            // lblParentName
            // 
            lblParentName.AutoSize = true;
            lblParentName.BackColor = Color.Transparent;
            lblParentName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParentName.ForeColor = Color.White;
            lblParentName.Location = new Point(345, 147);
            lblParentName.Name = "lblParentName";
            lblParentName.Size = new Size(103, 20);
            lblParentName.TabIndex = 14;
            lblParentName.Text = "Parent Name:";
            // 
            // txtParentName
            // 
            txtParentName.Location = new Point(467, 144);
            txtParentName.Name = "txtParentName";
            txtParentName.Size = new Size(150, 27);
            txtParentName.TabIndex = 13;
            // 
            // lblParentPhone
            // 
            lblParentPhone.AutoSize = true;
            lblParentPhone.BackColor = Color.Transparent;
            lblParentPhone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblParentPhone.ForeColor = Color.White;
            lblParentPhone.Location = new Point(345, 180);
            lblParentPhone.Name = "lblParentPhone";
            lblParentPhone.Size = new Size(106, 20);
            lblParentPhone.TabIndex = 12;
            lblParentPhone.Text = "Parent Phone:";
            // 
            // txtParentPhoneNumber
            // 
            txtParentPhoneNumber.Location = new Point(467, 177);
            txtParentPhoneNumber.Name = "txtParentPhoneNumber";
            txtParentPhoneNumber.Size = new Size(150, 27);
            txtParentPhoneNumber.TabIndex = 11;
            // 
            // lblParentEmail
            // 
            lblParentEmail.AutoSize = true;
            lblParentEmail.BackColor = Color.Transparent;
            lblParentEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblParentEmail.ForeColor = Color.White;
            lblParentEmail.Location = new Point(345, 213);
            lblParentEmail.Name = "lblParentEmail";
            lblParentEmail.Size = new Size(99, 20);
            lblParentEmail.TabIndex = 10;
            lblParentEmail.Text = "Parent Email:";
            // 
            // txtParentEmail
            // 
            txtParentEmail.Location = new Point(467, 213);
            txtParentEmail.Name = "txtParentEmail";
            txtParentEmail.Size = new Size(150, 27);
            txtParentEmail.TabIndex = 9;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.BackColor = Color.Transparent;
            lblClass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblClass.ForeColor = Color.White;
            lblClass.Location = new Point(345, 247);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(46, 20);
            lblClass.TabIndex = 8;
            lblClass.Text = "Class:";
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "6-A", "7-A", "8-A", "9-A", "10-A", "10-B", "11-A", "12-A" });
            cmbClass.Location = new Point(467, 247);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(150, 28);
            cmbClass.TabIndex = 7;
            // 
            // lblMonthlyFee
            // 
            lblMonthlyFee.AutoSize = true;
            lblMonthlyFee.BackColor = Color.Transparent;
            lblMonthlyFee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMonthlyFee.ForeColor = Color.White;
            lblMonthlyFee.Location = new Point(345, 282);
            lblMonthlyFee.Name = "lblMonthlyFee";
            lblMonthlyFee.Size = new Size(99, 20);
            lblMonthlyFee.TabIndex = 6;
            lblMonthlyFee.Text = "Monthly Fee:";
            // 
            // txtMonthlyFee
            // 
            txtMonthlyFee.Location = new Point(467, 282);
            txtMonthlyFee.Name = "txtMonthlyFee";
            txtMonthlyFee.Size = new Size(150, 27);
            txtMonthlyFee.TabIndex = 5;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(652, 237);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(120, 30);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(652, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 30);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(822, 284);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(822, 237);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 30);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStudents.BackgroundColor = Color.White;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(20, 334);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(930, 277);
            dgvStudents.TabIndex = 0;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(440, 48);
            label2.Name = "label2";
            label2.Size = new Size(406, 38);
            label2.TabIndex = 28;
            label2.Text = "Student Managment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 22);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 27;
            label1.Text = "EduNex";
            // 
            // StudentForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(972, 627);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddStudent);
            Controls.Add(txtMonthlyFee);
            Controls.Add(lblMonthlyFee);
            Controls.Add(cmbClass);
            Controls.Add(lblClass);
            Controls.Add(txtParentEmail);
            Controls.Add(lblParentEmail);
            Controls.Add(txtParentPhoneNumber);
            Controls.Add(lblParentPhone);
            Controls.Add(txtParentName);
            Controls.Add(lblParentName);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(cmbGender);
            Controls.Add(lblGender);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtRollNumber);
            Controls.Add(lblRollNumber);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Management";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
    }
}
