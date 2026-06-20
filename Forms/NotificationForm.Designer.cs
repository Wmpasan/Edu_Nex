using System;
using System.Windows.Forms;

namespace EduNex
{
    partial class NotificationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblMessage;
        private TextBox txtMessage;
        private Label lblNotificationType;
        private ComboBox cmbNotificationType;
        private Button btnCreateNotification;
        private Button btnSendNotification;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridView dgvNotifications;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblMessage = new Label();
            txtMessage = new TextBox();
            lblNotificationType = new Label();
            cmbNotificationType = new ComboBox();
            btnCreateNotification = new Button();
            btnSendNotification = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvNotifications = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).BeginInit();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.White;
            lblStudentId.Location = new Point(21, 141);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(85, 20);
            lblStudentId.TabIndex = 10;
            lblStudentId.Text = "Student ID:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(117, 138);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(120, 27);
            txtStudentId.TabIndex = 9;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMessage.ForeColor = Color.White;
            lblMessage.Location = new Point(21, 217);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(72, 20);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Message:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(117, 188);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(518, 60);
            txtMessage.TabIndex = 7;
            // 
            // lblNotificationType
            // 
            lblNotificationType.AutoSize = true;
            lblNotificationType.BackColor = Color.Transparent;
            lblNotificationType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNotificationType.ForeColor = Color.White;
            lblNotificationType.Location = new Point(359, 140);
            lblNotificationType.Name = "lblNotificationType";
            lblNotificationType.Size = new Size(45, 20);
            lblNotificationType.TabIndex = 6;
            lblNotificationType.Text = "Type:";
            // 
            // cmbNotificationType
            // 
            cmbNotificationType.FormattingEnabled = true;
            cmbNotificationType.Items.AddRange(new object[] { "Attendance", "Fee", "Exam", "General" });
            cmbNotificationType.Location = new Point(435, 137);
            cmbNotificationType.Name = "cmbNotificationType";
            cmbNotificationType.Size = new Size(200, 28);
            cmbNotificationType.TabIndex = 5;
            // 
            // btnCreateNotification
            // 
            btnCreateNotification.Location = new Point(711, 200);
            btnCreateNotification.Name = "btnCreateNotification";
            btnCreateNotification.Size = new Size(140, 30);
            btnCreateNotification.TabIndex = 4;
            btnCreateNotification.Text = "Create Notification";
            btnCreateNotification.UseVisualStyleBackColor = true;
            btnCreateNotification.Click += btnCreateNotification_Click;
            // 
            // btnSendNotification
            // 
            btnSendNotification.Location = new Point(711, 150);
            btnSendNotification.Name = "btnSendNotification";
            btnSendNotification.Size = new Size(140, 30);
            btnSendNotification.TabIndex = 3;
            btnSendNotification.Text = "Send All Notifications";
            btnSendNotification.UseVisualStyleBackColor = true;
            btnSendNotification.Click += btnSendNotification_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(262, 549);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(470, 549);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 30);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvNotifications
            // 
            dgvNotifications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvNotifications.BackgroundColor = Color.White;
            dgvNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotifications.Location = new Point(20, 281);
            dgvNotifications.Name = "dgvNotifications";
            dgvNotifications.RowHeadersWidth = 51;
            dgvNotifications.Size = new Size(850, 253);
            dgvNotifications.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(405, 35);
            label2.Name = "label2";
            label2.Size = new Size(490, 38);
            label2.TabIndex = 24;
            label2.Text = "Notification Managment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(300, 91);
            label1.TabIndex = 23;
            label1.Text = "EduNex";
            // 
            // NotificationForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(900, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvNotifications);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnSendNotification);
            Controls.Add(btnCreateNotification);
            Controls.Add(cmbNotificationType);
            Controls.Add(lblNotificationType);
            Controls.Add(txtMessage);
            Controls.Add(lblMessage);
            Controls.Add(txtStudentId);
            Controls.Add(lblStudentId);
            Name = "NotificationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notification Management";
            Load += NotificationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotifications).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Label label1;
    }
}
