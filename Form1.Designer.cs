namespace EduNex
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClear;
        private Button btnRegister;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnClear = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(574, 129);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(574, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 31);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(574, 199);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(574, 224);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 31);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(574, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(714, 289);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 40);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(574, 349);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 40);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-35, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 541);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(857, 559);
            Controls.Add(pictureBox1);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBox1;
    }
}

