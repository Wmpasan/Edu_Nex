using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EduNex
{
    public partial class StudentForm : Form
    {
        private int _teacherId = 0;

        public StudentForm(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.Text = "Student Management";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(990, 674);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            dgvStudents.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            // Normal teacher kenek nam witharak class eka lock karanawa
            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                cmbClass.Text = teacher.Class;
                cmbClass.Enabled = false;
            }
            // Admin nam cmbClass eka open eke thiyenawa ona class ekak select karanna

            LoadStudentData();
        }

        private void LoadStudentData()
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            var students = DatabaseHelper.GetAllStudents();

            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            // Admin nemei nam witharak class eken filter karanawa
            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                students = students.Where(s => s.Class == teacher.Class).ToList();
            }

            dgvStudents.DataSource = students;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtRollNumber.Text))
            {
                MessageBox.Show("Please fill required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = new Models.Student
            {
                Name = txtName.Text,
                RollNumber = txtRollNumber.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Gender = cmbGender.SelectedItem?.ToString() ?? "Not Specified",
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                ParentName = txtParentName.Text,
                ParentPhoneNumber = txtParentPhoneNumber.Text,
                ParentEmail = txtParentEmail.Text,
                EnrollmentDate = DateTime.Now,
                Class = cmbClass.SelectedItem?.ToString() ?? "Not Specified",
                MonthlyFee = decimal.TryParse(txtMonthlyFee.Text, out var fee) ? fee : 0,
                IsActive = true
            };

            DatabaseHelper.AddStudent(student);
            MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadStudentData();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvStudents.SelectedRows[0].Cells[0].Value.ToString(), out int studentId))
            {
                var student = DatabaseHelper.GetStudentById(studentId);
                if (student != null)
                {
                    student.Name = txtName.Text;
                    student.RollNumber = txtRollNumber.Text;
                    student.DateOfBirth = dtpDateOfBirth.Value;
                    student.Gender = cmbGender.SelectedItem?.ToString() ?? "Not Specified";
                    student.Address = txtAddress.Text;
                    student.PhoneNumber = txtPhoneNumber.Text;
                    student.ParentName = txtParentName.Text;
                    student.ParentPhoneNumber = txtParentPhoneNumber.Text;
                    student.ParentEmail = txtParentEmail.Text;
                    student.Class = cmbClass.SelectedItem?.ToString() ?? "Not Specified";
                    student.MonthlyFee = decimal.TryParse(txtMonthlyFee.Text, out var fee) ? fee : 0;

                    DatabaseHelper.UpdateStudent(student);
                    MessageBox.Show("Student updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentData();
                    ClearFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvStudents.SelectedRows[0].Cells[0].Value.ToString(), out int studentId))
            {
                DatabaseHelper.DeleteStudent(studentId);
                MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStudentData();
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];
                txtName.Text = row.Cells[1].Value?.ToString() ?? "";
                txtRollNumber.Text = row.Cells[2].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells[6].Value?.ToString() ?? "";
                txtParentName.Text = row.Cells[8].Value?.ToString() ?? "";
                txtParentPhoneNumber.Text = row.Cells[9].Value?.ToString() ?? "";
                txtParentEmail.Text = row.Cells[10].Value?.ToString() ?? "";
                txtMonthlyFee.Text = row.Cells[13].Value?.ToString() ?? "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtRollNumber.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtParentName.Clear();
            txtParentPhoneNumber.Clear();
            txtParentEmail.Clear();
            txtMonthlyFee.Clear();
            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Now;
        }
    }
}
