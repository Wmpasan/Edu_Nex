using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAttendanceReport;
        private Button btnFeeReport;
        private Button btnExamReport;
        private Button btnSummaryReport;
        private Button btnExportToCSV;
        private Button btnPrint;
        private DataGridView dgvReport;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            btnAttendanceReport = new Button();
            btnFeeReport = new Button();
            btnExamReport = new Button();
            btnSummaryReport = new Button();
            btnExportToCSV = new Button();
            btnPrint = new Button();
            dgvReport = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // btnAttendanceReport
            // 
            btnAttendanceReport.Location = new Point(21, 132);
            btnAttendanceReport.Name = "btnAttendanceReport";
            btnAttendanceReport.Size = new Size(170, 30);
            btnAttendanceReport.TabIndex = 6;
            btnAttendanceReport.Text = "Attendance Report";
            btnAttendanceReport.UseVisualStyleBackColor = true;
            btnAttendanceReport.Click += btnAttendanceReport_Click;
            // 
            // btnFeeReport
            // 
            btnFeeReport.Location = new Point(280, 132);
            btnFeeReport.Name = "btnFeeReport";
            btnFeeReport.Size = new Size(170, 30);
            btnFeeReport.TabIndex = 5;
            btnFeeReport.Text = "Fee Report";
            btnFeeReport.UseVisualStyleBackColor = true;
            btnFeeReport.Click += btnFeeReport_Click;
            // 
            // btnExamReport
            // 
            btnExamReport.Location = new Point(555, 132);
            btnExamReport.Name = "btnExamReport";
            btnExamReport.Size = new Size(170, 30);
            btnExamReport.TabIndex = 4;
            btnExamReport.Text = "Exam Report";
            btnExamReport.UseVisualStyleBackColor = true;
            btnExamReport.Click += btnExamReport_Click;
            // 
            // btnSummaryReport
            // 
            btnSummaryReport.Location = new Point(20, 179);
            btnSummaryReport.Name = "btnSummaryReport";
            btnSummaryReport.Size = new Size(170, 30);
            btnSummaryReport.TabIndex = 3;
            btnSummaryReport.Text = "Summary Report";
            btnSummaryReport.UseVisualStyleBackColor = true;
            btnSummaryReport.Click += btnSummaryReport_Click;
            // 
            // btnExportToCSV
            // 
            btnExportToCSV.Location = new Point(279, 179);
            btnExportToCSV.Name = "btnExportToCSV";
            btnExportToCSV.Size = new Size(170, 30);
            btnExportToCSV.TabIndex = 2;
            btnExportToCSV.Text = "Export to CSV";
            btnExportToCSV.UseVisualStyleBackColor = true;
            btnExportToCSV.Click += btnExportToCSV_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(554, 179);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(170, 30);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReport.BackgroundColor = Color.White;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(20, 225);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(705, 331);
            dgvReport.TabIndex = 0;
            dgvReport.CellContentClick += dgvReport_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(337, 39);
            label2.Name = "label2";
            label2.Size = new Size(387, 38);
            label2.TabIndex = 26;
            label2.Text = "Report Managment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 25;
            label1.Text = "EduNex";
            label1.Click += label1_Click;
            // 
            // ReportForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(746, 583);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvReport);
            Controls.Add(btnPrint);
            Controls.Add(btnExportToCSV);
            Controls.Add(btnSummaryReport);
            Controls.Add(btnExamReport);
            Controls.Add(btnFeeReport);
            Controls.Add(btnAttendanceReport);
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report Management";
            Load += ReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
    }
}
