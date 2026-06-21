using System.Text.RegularExpressions;

namespace EduNex
{
    public partial class Form1 : Form
    {
        private int _loggedInTeacherId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "EduNex - Smart Class Management System - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(997, 604);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Sample teacher data is now handled by database initialization
            // No need to reinitialize on every app load
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter email and password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var teacher = DatabaseHelper.GetTeacherByEmail(email);
            if (teacher != null && teacher.Password == password && teacher.IsActive)
            {
                _loggedInTeacherId = teacher.TeacherID;
                // Open main dashboard
                MainForm mainForm = new MainForm(_loggedInTeacherId, teacher.Name);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            TeacherRegistrationForm registrationForm = new TeacherRegistrationForm();
            registrationForm.ShowDialog();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            // Standard Regex pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // 1. If the box is empty, reset to default (don't show an error yet)
            if (string.IsNullOrWhiteSpace(email))
            {
                txtEmail.BackColor = SystemColors.Window;
            }
            // 2. If the email matches the pattern, indicate success (e.g., Light Green)
            else if (Regex.IsMatch(email, pattern))
            {
                txtEmail.BackColor = Color.LightGreen;
            }
            // 3. If the user is typing and it's not valid yet, indicate an error (e.g., Light Pink)
            else
            {
                txtEmail.BackColor = Color.LightPink;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

