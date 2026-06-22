using System;
using System.Windows.Forms;

namespace EduNex
{
    public partial class ExamForm : Form
    {
        private int _teacherId = 0;

        public ExamForm(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            this.Text = "Exam Results Management";
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1018, 697);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            dgvResults.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            LoadExamData();
        }

        private void LoadExamData()
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            // Admin nam okkoma details enawa, nethnam e teacher dapu details witharak enawa
            var results = isAdmin ? DatabaseHelper.GetAllExamResults() : DatabaseHelper.GetExamResultsByTeacher(_teacherId);

            dgvResults.DataSource = results;
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            // 1. Student ID eka check kireema (Spaces thiyenawanam Trim() eken ewa ain karanawa)
            if (!int.TryParse(txtStudentId.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Marks TextBoxes wala thiyena values gannawa
            string marksText = txtMarksObtained.Text.Trim();
            string totalText = txtTotalMarks.Text.Trim();

            // 3. Number formatting issues nathi wenna InvariantCulture pawichchi karala parse karanawa
            bool isMarksValid = decimal.TryParse(marksText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal marks);
            bool isTotalValid = decimal.TryParse(totalText, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal total);

            if (!isMarksValid || !isTotalValid)
            {
                MessageBox.Show("Please enter valid numbers for marks.\n(Make sure there are no letters or special characters)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Logical Checks: Total eka 0 wenna baha, Marks > Total wenna baha
            if (total <= 0)
            {
                MessageBox.Show("Total marks must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (marks < 0 || marks > total)
            {
                MessageBox.Show($"Marks obtained ({marks}) cannot be less than 0 or greater than Total marks ({total}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Student wa database eken gannawa
            var student = DatabaseHelper.GetStudentById(studentId);
            if (student == null)
            {
                MessageBox.Show("Student not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 6. Percentage eka calculate karala Grade eka hadanawa
            decimal percentage = (marks / total) * 100;
            string grade = CalculateGrade(percentage);

            // 7. Result eka Database ekata save karanawa
            var result = new Models.ExamResult
            {
                StudentID = studentId,
                StudentName = student.Name,
                ExamName = txtExamName.Text,
                Subject = txtSubject.Text,
                MarksObtained = marks,
                TotalMarks = total,
                Percentage = percentage,
                Grade = grade,
                ExamDate = dtpExamDate.Value,
                TeacherID = _teacherId // Logged-in teacher ge ID eka
            };

            DatabaseHelper.AddExamResult(result);
            MessageBox.Show("Exam result added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExamData();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a result to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvResults.SelectedRows[0].Cells[0].Value.ToString(), out int resultId))
            {
                var result = DatabaseHelper.GetAllExamResults().Find(r => r.ResultID == resultId);
                if (result != null && decimal.TryParse(txtMarksObtained.Text, out decimal marks) && decimal.TryParse(txtTotalMarks.Text, out decimal total))
                {
                    result.MarksObtained = marks;
                    result.TotalMarks = total;
                    result.Percentage = (marks / total) * 100;
                    result.Grade = CalculateGrade(result.Percentage);
                    DatabaseHelper.UpdateExamResult(result);
                    MessageBox.Show("Exam result updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExamData();
                    ClearFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a result to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(dgvResults.SelectedRows[0].Cells[0].Value.ToString(), out int resultId))
            {
                DatabaseHelper.DeleteExamResult(resultId);
                MessageBox.Show("Exam result deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadExamData();
            }
        }

        private void btnViewByStudent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var results = DatabaseHelper.GetResultsByStudent(studentId);
            dgvResults.DataSource = results;
        }

        private void btnViewByExam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExamName.Text))
            {
                MessageBox.Show("Please enter exam name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var results = DatabaseHelper.GetResultsByExam(txtExamName.Text);
            dgvResults.DataSource = results;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadExamData();
        }

        private string CalculateGrade(decimal percentage)
        {
            if (percentage >= 90) return "A+";
            if (percentage >= 80) return "A";
            if (percentage >= 70) return "B";
            if (percentage >= 60) return "C";
            if (percentage >= 50) return "D";
            return "F";
        }

        private void ClearFields()
        {
            txtStudentId.Clear();
            txtExamName.Clear();
            txtSubject.Clear();
            txtMarksObtained.Clear();
            txtTotalMarks.Clear();
            dtpExamDate.Value = DateTime.Now;
            dgvResults.ClearSelection();
        }

        private void dgvResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                var row = dgvResults.SelectedRows[0];
                txtStudentId.Text = row.Cells[1].Value?.ToString() ?? "";
                txtExamName.Text = row.Cells[3].Value?.ToString() ?? "";
                txtSubject.Text = row.Cells[4].Value?.ToString() ?? "";
                txtMarksObtained.Text = row.Cells[5].Value?.ToString() ?? "0";
                txtTotalMarks.Text = row.Cells[6].Value?.ToString() ?? "0";
            }
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTotalMarks_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
