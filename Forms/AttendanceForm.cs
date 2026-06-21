using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EduNex
{
    public partial class AttendanceForm : Form
    {
        private int _teacherId = 0;

        public AttendanceForm(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            this.Text = "Attendance Tracking";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(944, 647);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Grid text color eka Black karanawa
            dgvAttendance.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            LoadAttendanceData();
        }

        private void LoadAttendanceData()
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            var attendances = DatabaseHelper.GetAllAttendances();
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            // Admin nemei nam (saha class ekak thiyenawanam) filter karanawa
            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                var studentIds = DatabaseHelper.GetAllStudents()
                                    .Where(s => s.Class == teacher.Class)
                                    .Select(s => s.StudentID)
                                    .ToList();

                attendances = attendances.Where(a => studentIds.Contains(a.StudentID)).ToList();
            }

            dgvAttendance.DataSource = attendances;
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentId.Text) || cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please fill all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStudentId.Text, out int studentId))
            {
                MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var student = DatabaseHelper.GetStudentById(studentId);
            if (student == null)
            {
                MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- SECURITY CHECK: Admin nemei nam wena class walata add karanna baha ---
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                if (student.Class != teacher.Class)
                {
                    MessageBox.Show($"Access Denied! You can only add attendance for students in the '{teacher.Class}' class.",
                                    "Class Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var attendance = new Models.Attendance
            {
                StudentID = studentId,
                StudentName = student.Name,
                AttendanceDate = dtpAttendanceDate.Value,
                Status = cmbStatus.SelectedItem.ToString(),
                Remarks = txtRemarks.Text,
                TeacherID = _teacherId
            };

            DatabaseHelper.AddAttendance(attendance);
            MessageBox.Show("Attendance recorded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAttendanceData();
            ClearFields();
        }

        private void btnViewByDate_Click(object sender, EventArgs e)
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            var attendances = DatabaseHelper.GetAttendanceByDate(dtpAttendanceDate.Value);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            // Search karaddith admin nemei nam eyage class ekata witharak filter karanawa
            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                var studentIds = DatabaseHelper.GetAllStudents()
                                    .Where(s => s.Class == teacher.Class)
                                    .Select(s => s.StudentID)
                                    .ToList();

                attendances = attendances.Where(a => studentIds.Contains(a.StudentID)).ToList();
            }

            dgvAttendance.DataSource = attendances;
        }

        private void btnViewByStudent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            var attendances = DatabaseHelper.GetAttendanceByStudent(studentId);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            // Search karaddith admin nemei nam wena class wala lamai pennanne naha
            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                var student = DatabaseHelper.GetStudentById(studentId);
                if (student != null && student.Class != teacher.Class)
                {
                    MessageBox.Show("Access Denied! You can only view attendance for students in your class.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dgvAttendance.DataSource = attendances;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvAttendance.SelectedRows[0].Cells[0].Value.ToString(), out int attendanceId))
            {
                DatabaseHelper.DeleteAttendance(attendanceId);
                MessageBox.Show("Attendance record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAttendanceData();
            }
        }

        private void ClearFields()
        {
            txtStudentId.Clear();
            cmbStatus.SelectedIndex = -1;
            txtRemarks.Clear();
            dtpAttendanceDate.Value = DateTime.Now;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }
    }
}