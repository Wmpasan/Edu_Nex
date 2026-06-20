using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class FeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblPaidDate;
        private DateTimePicker dtpPaidDate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnAddFee;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnViewPending;
        private Button btnViewPaid;
        private Button btnViewOverdue;
        private Button btnRefresh;
        private DataGridView dgvFees;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeeForm));
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblPaidDate = new Label();
            dtpPaidDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAddFee = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnViewPending = new Button();
            btnViewPaid = new Button();
            btnViewOverdue = new Button();
            btnRefresh = new Button();
            dgvFees = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFees).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.White;
            lblStudentId.Location = new Point(20, 126);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(85, 20);
            lblStudentId.TabIndex = 19;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(135, 123);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(120, 27);
            txtStudentId.TabIndex = 18;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.BackColor = Color.Transparent;
            lblAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblAmount.ForeColor = Color.White;
            lblAmount.Location = new Point(318, 126);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(68, 20);
            lblAmount.TabIndex = 17;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(428, 123);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(120, 27);
            txtAmount.TabIndex = 16;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.BackColor = Color.Transparent;
            lblDueDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDueDate.ForeColor = Color.White;
            lblDueDate.Location = new Point(318, 177);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(77, 20);
            lblDueDate.TabIndex = 15;
            lblDueDate.Text = "Due Date:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(428, 172);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(150, 27);
            dtpDueDate.TabIndex = 14;
            // 
            // lblPaidDate
            // 
            lblPaidDate.AutoSize = true;
            lblPaidDate.BackColor = Color.Transparent;
            lblPaidDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPaidDate.ForeColor = Color.White;
            lblPaidDate.Location = new Point(20, 177);
            lblPaidDate.Name = "lblPaidDate";
            lblPaidDate.Size = new Size(79, 20);
            lblPaidDate.TabIndex = 13;
            lblPaidDate.Text = "Paid Date:";
            // 
            // dtpPaidDate
            // 
            dtpPaidDate.Location = new Point(135, 172);
            dtpPaidDate.Name = "dtpPaidDate";
            dtpPaidDate.Size = new Size(150, 27);
            dtpPaidDate.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(620, 126);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Paid", "Overdue" });
            cmbStatus.Location = new Point(716, 126);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(150, 28);
            cmbStatus.TabIndex = 10;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(620, 172);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(91, 20);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(716, 169);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 27);
            txtDescription.TabIndex = 8;
            // 
            // btnAddFee
            // 
            btnAddFee.Location = new Point(888, 123);
            btnAddFee.Name = "btnAddFee";
            btnAddFee.Size = new Size(100, 30);
            btnAddFee.TabIndex = 7;
            btnAddFee.Text = "Add Fee";
            btnAddFee.UseVisualStyleBackColor = true;
            btnAddFee.Click += btnAddFee_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(888, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(161, 548);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnViewPending
            // 
            btnViewPending.Location = new Point(570, 548);
            btnViewPending.Name = "btnViewPending";
            btnViewPending.Size = new Size(100, 30);
            btnViewPending.TabIndex = 4;
            btnViewPending.Text = "Pending";
            btnViewPending.UseVisualStyleBackColor = true;
            btnViewPending.Click += btnViewPending_Click;
            // 
            // btnViewPaid
            // 
            btnViewPaid.Location = new Point(436, 548);
            btnViewPaid.Name = "btnViewPaid";
            btnViewPaid.Size = new Size(100, 30);
            btnViewPaid.TabIndex = 3;
            btnViewPaid.Text = "Paid";
            btnViewPaid.UseVisualStyleBackColor = true;
            btnViewPaid.Click += btnViewPaid_Click;
            // 
            // btnViewOverdue
            // 
            btnViewOverdue.Location = new Point(702, 548);
            btnViewOverdue.Name = "btnViewOverdue";
            btnViewOverdue.Size = new Size(100, 30);
            btnViewOverdue.TabIndex = 2;
            btnViewOverdue.Text = "Overdue";
            btnViewOverdue.UseVisualStyleBackColor = true;
            btnViewOverdue.Click += btnViewOverdue_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(296, 548);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 30);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvFees
            // 
            dgvFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFees.BackgroundColor = Color.White;
            dgvFees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFees.Location = new Point(37, 227);
            dgvFees.Name = "dgvFees";
            dgvFees.RowHeadersWidth = 51;
            dgvFees.Size = new Size(940, 304);
            dgvFees.TabIndex = 0;
            dgvFees.SelectionChanged += dgvFees_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(505, 49);
            label2.Name = "label2";
            label2.Size = new Size(443, 38);
            label2.TabIndex = 26;
            label2.Text = "Class Fee Managment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 23);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 25;
            label1.Text = "EduNex";
            label1.Click += label1_Click;
            // 
            // FeeForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvFees);
            Controls.Add(btnRefresh);
            Controls.Add(btnViewOverdue);
            Controls.Add(btnViewPaid);
            Controls.Add(btnViewPending);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddFee);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dtpPaidDate);
            Controls.Add(lblPaidDate);
            Controls.Add(dtpDueDate);
            Controls.Add(lblDueDate);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Name = "FeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fee Management";
            Load += FeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
    }
}
