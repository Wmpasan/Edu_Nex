using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EduNex
{
    public partial class ReportForm : Form
    {
        private int _teacherId = 0;

        public ReportForm(int teacherId)
        {
            InitializeComponent();
            _teacherId = teacherId;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.Text = "Reports";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(764, 630);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Grid text color eka Black karanawa
            dgvReport.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            LoadAttendanceReport();
        }

        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
            LoadAttendanceReport();
        }

        private void LoadAttendanceReport()
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            var attendances = DatabaseHelper.GetAllAttendances();

            // Admin da kiyala check karanawa
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

            var report = attendances.GroupBy(a => a.StudentName)
                .Select(g => new
                {
                    StudentName = g.Key,
                    Present = g.Count(a => a.Status == "Present"),
                    Absent = g.Count(a => a.Status == "Absent"),
                    Late = g.Count(a => a.Status == "Late"),
                    Leave = g.Count(a => a.Status == "Leave"),
                    Total = g.Count(),
                    Percentage = g.Count() > 0 ? (g.Count(a => a.Status == "Present") * 100m) / g.Count() : 0
                }).ToList();

            dgvReport.DataSource = report;
        }

        private void btnFeeReport_Click(object sender, EventArgs e)
        {
            LoadFeeReport();
        }

        private void LoadFeeReport()
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            var fees = DatabaseHelper.GetAllFees();

            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                var studentIds = DatabaseHelper.GetAllStudents()
                                    .Where(s => s.Class == teacher.Class)
                                    .Select(s => s.StudentID)
                                    .ToList();

                fees = fees.Where(f => studentIds.Contains(f.StudentID)).ToList();
            }

            var report = fees.GroupBy(f => f.StudentName)
                .Select(g => new
                {
                    StudentName = g.Key,
                    TotalFees = g.Sum(f => f.Amount),
                    Paid = g.Where(f => f.Status == "Paid").Sum(f => f.Amount),
                    Pending = g.Where(f => f.Status == "Pending").Sum(f => f.Amount),
                    Overdue = g.Where(f => f.Status == "Overdue").Sum(f => f.Amount)
                }).ToList();

            dgvReport.DataSource = report;
        }

        private void btnExamReport_Click(object sender, EventArgs e)
        {
            LoadExamReport();
        }

        private void LoadExamReport()
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            var results = DatabaseHelper.GetAllExamResults();

            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            if (teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin)
            {
                var studentIds = DatabaseHelper.GetAllStudents()
                                    .Where(s => s.Class == teacher.Class)
                                    .Select(s => s.StudentID)
                                    .ToList();

                results = results.Where(r => studentIds.Contains(r.StudentID)).ToList();
            }

            var report = results.GroupBy(r => r.StudentName)
                .Select(g => new
                {
                    StudentName = g.Key,
                    AveragePercentage = Math.Round(g.Average(r => r.Percentage), 2),
                    HighestMarks = g.Max(r => r.MarksObtained),
                    LowestMarks = g.Min(r => r.MarksObtained),
                    ExamCount = g.Count(),
                    GradeCount = g.Count()
                }).ToList();

            dgvReport.DataSource = report;
        }

        private void btnSummaryReport_Click(object sender, EventArgs e)
        {
            LoadSummaryReport();
        }

        private void LoadSummaryReport()
        {
            var teacher = DatabaseHelper.GetTeacherById(_teacherId);
            bool isAdmin = teacher != null && teacher.Subject == "Class Management";

            var allStudents = DatabaseHelper.GetAllStudents();
            var attendances = DatabaseHelper.GetAllAttendances();
            var fees = DatabaseHelper.GetAllFees();
            var results = DatabaseHelper.GetAllExamResults();

            // Admin nam okkoma lamai, nethnam teacher ge class eke lamai witharai
            var students = teacher != null && !string.IsNullOrEmpty(teacher.Class) && !isAdmin
                           ? allStudents.Where(s => s.Class == teacher.Class).ToList()
                           : allStudents;

            var report = students.Select(s => new
            {
                StudentName = s.Name,
                RollNumber = s.RollNumber,
                Class = s.Class,
                AttendanceCount = attendances.Count(a => a.StudentID == s.StudentID),
                PendingFees = fees.Where(f => f.StudentID == s.StudentID && f.Status == "Pending").Sum(f => f.Amount),
                ExamAverage = results.Where(r => r.StudentID == s.StudentID).Any() ?
                    Math.Round(results.Where(r => r.StudentID == s.StudentID).Average(r => r.Percentage), 2) : 0
            }).ToList();

            dgvReport.DataSource = report;
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";
            saveFileDialog.Title = "Export Report to CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        // Write headers
                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            writer.Write(dgvReport.Columns[i].HeaderText);
                            if (i < dgvReport.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();

                        // Write data
                        foreach (DataGridViewRow row in dgvReport.Rows)
                        {
                            for (int i = 0; i < dgvReport.Columns.Count; i++)
                            {
                                writer.Write(row.Cells[i].Value);
                                if (i < dgvReport.Columns.Count - 1)
                                    writer.Write(",");
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Report exported successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print functionality - integrate with your printer settings", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Prevent errors if the teacher accidentally clicks the column header (RowIndex -1)
            if (e.RowIndex >= 0)
            {
                // 2. Grab the entire row that was clicked
                DataGridViewRow row = dgvReport.Rows[e.RowIndex];

                // 3. Extract the student's name (this column exists in all our reports)
                string studentName = row.Cells["StudentName"].Value?.ToString() ?? "Unknown Student";

                // --- EXAMPLE: Reacting to a specific column click ---

                // Let's say they are on the Summary Report and click the "PendingFees" cell
                if (dgvReport.Columns[e.ColumnIndex].Name == "PendingFees")
                {
                    string pendingAmount = row.Cells["PendingFees"].Value?.ToString();

                    // For now, let's just show a MessageBox. 
                    MessageBox.Show($"Showing detailed fee history for {studentName}.\nTotal Pending: Rs {pendingAmount}",
                                    "Fee Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Let's say they click the "ExamAverage" cell
                else if (dgvReport.Columns[e.ColumnIndex].Name == "ExamAverage")
                {
                    MessageBox.Show($"Opening exam breakdown for {studentName}...",
                                    "Exam Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}