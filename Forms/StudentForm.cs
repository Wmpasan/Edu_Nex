using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EduNex
{
    public partial class StudentForm : Form
    {
        private int _teacherId = 0;
        private string _assignedClass = null;  // Store the auto-assigned class for non-admin teachers

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
                _assignedClass = teacher.Class;  // Store the assigned class
                cmbClass.Text = teacher.Class;
                cmbClass.Enabled = false;
            }
            // Admin nam cmbClass eka open eke thiyenawa ona class ekak select karanna

            // Subscribe to text change events for required fields
            txtName.TextChanged += (s, e) => UpdateAddButtonState();
            txtRollNumber.TextChanged += (s, e) => UpdateAddButtonState();
            txtAddress.TextChanged += (s, e) => UpdateAddButtonState();
            txtPhoneNumber.TextChanged += (s, e) => UpdateAddButtonState();
            txtParentName.TextChanged += (s, e) => UpdateAddButtonState();
            txtParentPhoneNumber.TextChanged += (s, e) => UpdateAddButtonState();
            txtParentEmail.TextChanged += (s, e) => UpdateAddButtonState();
            txtMonthlyFee.TextChanged += (s, e) => UpdateAddButtonState();
            cmbGender.SelectedIndexChanged += (s, e) => UpdateAddButtonState();
            cmbClass.SelectedIndexChanged += (s, e) => UpdateAddButtonState();

            // Initialize button state
            btnAddStudent.Enabled = false;

            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                var teacher = DatabaseHelper.GetTeacherById(_teacherId);
                var students = DatabaseHelper.GetAllStudents();

                if (students == null)
                {
                    students = new List<Models.Student>();
                }

                bool isAdmin = teacher != null && teacher.Subject == "Class Management";

                // Admin nemei nam witharak class eken filter karanawa
                if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
                {
                    students = students.Where(s => s.Class == teacher.Class).ToList();
                }

                // Clear existing DataSource and rebind to force refresh
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = new List<Models.Student>(students);

                // Debugging: Show count
                System.Diagnostics.Debug.WriteLine($"Loaded {students.Count} students");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"LoadStudentData Error: {ex}");
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtRollNumber.Text) || 
                string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtParentName.Text) || string.IsNullOrEmpty(txtParentPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtParentEmail.Text) || string.IsNullOrEmpty(txtMonthlyFee.Text) ||
                cmbGender.SelectedIndex < 0 || cmbClass.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill all required fields: Name, Roll Number, Address, Phone Number, Parent Name, Parent Phone, Parent Email, Monthly Fee, Gender, and Class", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var cellValue = dgvStudents.SelectedRows[0].Cells[0].Value;
                if (cellValue == null)
                {
                    MessageBox.Show("Invalid student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (int.TryParse(cellValue.ToString(), out int studentId))
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

                        bool updateSuccess = DatabaseHelper.UpdateStudent(student);
                        System.Diagnostics.Debug.WriteLine($"Update Success: {updateSuccess}");

                        if (updateSuccess)
                        {
                            MessageBox.Show("Student updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            dgvStudents.ClearSelection();
                            LoadStudentData(); // Reload after update
                        }
                        else
                        {
                            MessageBox.Show("Failed to update student. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid student ID format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"btnUpdate Error: {ex}");
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

                // Handle DateOfBirth (column 3)
                if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime dob))
                {
                    dtpDateOfBirth.Value = dob;
                }

                // Handle Gender (column 4)
                if (row.Cells[4].Value != null)
                {
                    cmbGender.Text = row.Cells[4].Value.ToString();
                }

                // Handle Address (column 5)
                txtAddress.Text = row.Cells[5].Value?.ToString() ?? "";
                txtPhoneNumber.Text = row.Cells[6].Value?.ToString() ?? "";
                txtParentName.Text = row.Cells[8].Value?.ToString() ?? "";
                txtParentPhoneNumber.Text = row.Cells[9].Value?.ToString() ?? "";
                txtParentEmail.Text = row.Cells[10].Value?.ToString() ?? "";

                // Handle Class (column 11)
                if (row.Cells[11].Value != null)
                {
                    cmbClass.Text = row.Cells[11].Value.ToString();
                }

                txtMonthlyFee.Text = row.Cells[12].Value?.ToString() ?? "0";
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

            // For non-admin teachers, restore the assigned class instead of clearing
            if (_assignedClass != null)
            {
                cmbClass.Text = _assignedClass;
            }
            else
            {
                cmbClass.SelectedIndex = -1;
            }

            dtpDateOfBirth.Value = DateTime.Now;
            dgvStudents.ClearSelection();
            UpdateAddButtonState();
        }

        private void UpdateAddButtonState()
        {
            // Check if ALL fields are filled
            bool isNameFilled = !string.IsNullOrWhiteSpace(txtName.Text);
            bool isRollNumberFilled = !string.IsNullOrWhiteSpace(txtRollNumber.Text);
            bool isAddressFilled = !string.IsNullOrWhiteSpace(txtAddress.Text);
            bool isPhoneNumberFilled = !string.IsNullOrWhiteSpace(txtPhoneNumber.Text);
            bool isParentNameFilled = !string.IsNullOrWhiteSpace(txtParentName.Text);
            bool isParentPhoneNumberFilled = !string.IsNullOrWhiteSpace(txtParentPhoneNumber.Text);
            bool isParentEmailFilled = !string.IsNullOrWhiteSpace(txtParentEmail.Text);
            bool isMonthlyFeeFilled = !string.IsNullOrWhiteSpace(txtMonthlyFee.Text);
            bool isGenderSelected = cmbGender.SelectedIndex >= 0;
            bool isClassSelected = cmbClass.SelectedIndex >= 0;

            // Enable button only if ALL fields are filled
            btnAddStudent.Enabled = isNameFilled && isRollNumberFilled && isAddressFilled && isPhoneNumberFilled && 
                                   isParentNameFilled && isParentPhoneNumberFilled && isParentEmailFilled && 
                                   isMonthlyFeeFilled && isGenderSelected && isClassSelected;
        }
    }
}
