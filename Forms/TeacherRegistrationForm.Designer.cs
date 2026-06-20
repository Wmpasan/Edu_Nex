using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class TeacherRegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private TextBox txtName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private Label lblSubject;
        private ComboBox cmbSubject;
        private Label lblClass;
        private ComboBox cmbClass;
        private Button btnRegister;
        private Button btnClear;
        private Button btnCancel;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherRegistrationForm));
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblSubject = new Label();
            cmbSubject = new ComboBox();
            lblClass = new Label();
            cmbClass = new ComboBox();
            btnRegister = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(12, 241);
            lblName.Name = "lblName";
            lblName.Size = new Size(87, 20);
            lblName.TabIndex = 16;
            lblName.Text = "Full Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 238);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 27);
            txtName.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(404, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 20);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(582, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 13;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(12, 328);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(81, 20);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(147, 325);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 11;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(404, 328);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(140, 20);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Confirm Password :";
            lblConfirmPassword.Click += lblConfirmPassword_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(582, 325);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 27);
            txtConfirmPassword.TabIndex = 9;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.BackColor = Color.Transparent;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.White;
            lblPhoneNumber.Location = new Point(12, 283);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(122, 20);
            lblPhoneNumber.TabIndex = 8;
            lblPhoneNumber.Text = "Phone Number :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(147, 280);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 27);
            txtPhoneNumber.TabIndex = 7;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.BackColor = Color.Transparent;
            lblSubject.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSubject.ForeColor = Color.White;
            lblSubject.Location = new Point(12, 367);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(63, 20);
            lblSubject.TabIndex = 6;
            lblSubject.Text = "Subject:";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Items.AddRange(new object[] { "Mathematics", "Science", "English", "History", "Geography", "Computer Science", "Physical Education" });
            cmbSubject.Location = new Point(147, 367);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(200, 28);
            cmbSubject.TabIndex = 5;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.BackColor = Color.Transparent;
            lblClass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblClass.ForeColor = Color.White;
            lblClass.Location = new Point(404, 370);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(46, 20);
            lblClass.TabIndex = 4;
            lblClass.Text = "Class:";
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Items.AddRange(new object[] { "6-A", "7-A", "8-A", "9-A", "10-A", "10-B", "11-A", "12-A" });
            cmbClass.Location = new Point(582, 367);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(200, 28);
            cmbClass.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(224, 456);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 40);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(334, 456);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(444, 456);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 20);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 17;
            label1.Text = "EduNex";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(162, 128);
            label2.Name = "label2";
            label2.Size = new Size(446, 38);
            label2.TabIndex = 18;
            label2.Text = " Teacher Registration";
            // 
            // TeacherRegistrationForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(827, 536);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(cmbClass);
            Controls.Add(lblClass);
            Controls.Add(cmbSubject);
            Controls.Add(lblSubject);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtName);
            Controls.Add(lblName);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TeacherRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teacher Registration";
            Load += TeacherRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
    }
}
