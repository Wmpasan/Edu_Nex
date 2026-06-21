using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EduNex
{
    public partial class TeacherRegistrationForm : Form
    {
        public TeacherRegistrationForm()
        {
            InitializeComponent();
        }

        private void TeacherRegistrationForm_Load(object sender, EventArgs e)
        {
            this.Text = "Teacher Registration";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(845, 590);
            btnRegister.Enabled = false; // Start disabled
        }

        // --- VALIDATION EVENTS ---

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.BackColor = SystemColors.Window;
            }
            else if (txtName.Text.Trim().Length < 2) // Basic check for a valid name length
            {
                txtName.BackColor = Color.LightPink;
            }
            else
            {
                txtName.BackColor = Color.LightGreen;
            }
            ValidateForm();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim(); // .Trim() removes accidental spaces at the end

            if (string.IsNullOrEmpty(email))
            {
                // Box is empty: Reset everything
                lblEmailError.Text = "";
                txtEmail.BackColor = SystemColors.Window;
            }
            else
            {
                // The pattern for a valid email
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                if (Regex.IsMatch(email, pattern))
                {
                    // Valid Email!
                    lblEmailError.Text = "Valid email!";
                    lblEmailError.ForeColor = Color.Green;
                    txtEmail.BackColor = Color.LightGreen;
                }
                else
                {
                    // Invalid Email (Turns pink immediately if it's not perfect)
                    lblEmailError.Text = "Please enter a valid email address.";
                    lblEmailError.ForeColor = Color.Red;
                    txtEmail.BackColor = Color.LightPink;
                }
            }

            ValidateForm();
        }


        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.BackColor = SystemColors.Window;
            }
            // FIX: Check if they match AND if the main password meets the 6-character minimum
            else if (txtPassword.Text == txtConfirmPassword.Text && txtPassword.Text.Length >= 6)
            {
                txtConfirmPassword.BackColor = Color.LightGreen;
            }
            else
            {
                txtConfirmPassword.BackColor = Color.LightPink;
            }
            ValidateForm();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                txtPhoneNumber.BackColor = SystemColors.Window;
            }
            else
            {
                // Example regex for exactly 10 digits. Adjust as needed.
                string pattern = @"^\d{10}$";
                if (Regex.IsMatch(txtPhoneNumber.Text, pattern))
                {
                    txtPhoneNumber.BackColor = Color.LightGreen;
                }
                else
                {
                    txtPhoneNumber.BackColor = Color.LightPink;
                }
            }
            ValidateForm();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1)
            {
                cmbSubject.BackColor = SystemColors.Window;
            }
            else
            {
                cmbSubject.BackColor = Color.LightGreen;
            }
            ValidateForm();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex == -1)
            {
                cmbClass.BackColor = SystemColors.Window;
            }
            else
            {
                cmbClass.BackColor = Color.LightGreen;
            }
            ValidateForm();
        }

        // --- MASTER VALIDATION ---

        private void ValidateForm()
        {
            // 1. Check if all required fields have text/selections
            bool allFieldsFilled = !string.IsNullOrWhiteSpace(txtName.Text) &&
                                   !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                                   !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                                   !string.IsNullOrWhiteSpace(txtConfirmPassword.Text) &&
                                   !string.IsNullOrWhiteSpace(txtPhoneNumber.Text);

            bool allCombosSelected = cmbSubject.SelectedIndex != -1 &&
                                     cmbClass.SelectedIndex != -1;

            // 2. Check for any "Error" colors (If any field is Pink, the form is invalid)
            bool hasAnyErrorColors = txtName.BackColor == Color.LightPink ||
                                     txtEmail.BackColor == Color.LightPink ||
                                     txtPassword.BackColor == Color.LightPink ||
                                     txtPhoneNumber.BackColor == Color.LightPink ||
                                     txtConfirmPassword.BackColor == Color.LightPink;

            // 3. Final Logic: Button is ONLY enabled if everything is perfect
            btnRegister.Enabled = allFieldsFilled && allCombosSelected && !hasAnyErrorColors;
        }

        // --- REMAINING METHODS ---

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Note: Make sure DatabaseHelper and Models.Teacher are correctly referenced in your project.
            var existingTeacher = DatabaseHelper.GetTeacherByEmail(txtEmail.Text);
            if (existingTeacher != null)
            {
                MessageBox.Show("Email already registered", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var teacher = new Models.Teacher
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Subject = cmbSubject.SelectedItem?.ToString(),
                Class = cmbClass.SelectedItem?.ToString(),
                JoiningDate = DateTime.Now,
                IsActive = true
            };

            DatabaseHelper.AddTeacher(teacher);
            MessageBox.Show("Teacher registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            this.Close();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtPhoneNumber.Clear();

            cmbSubject.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;

            // Reset background colors to default
            txtName.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            txtPassword.BackColor = SystemColors.Window;
            txtConfirmPassword.BackColor = SystemColors.Window;
            txtPhoneNumber.BackColor = SystemColors.Window;
            cmbSubject.BackColor = SystemColors.Window;
            cmbClass.BackColor = SystemColors.Window;

            lblEmailError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.BackColor = SystemColors.Window;
            }
            else if (txtPassword.Text.Length < 6) // Require at least 6 characters
            {
                txtPassword.BackColor = Color.LightPink;
            }
            else
            {
                txtPassword.BackColor = Color.LightGreen;
            }

            // Call the safe helper method instead of the event handler
            ValidateConfirmPassword();
            ValidateForm();
        }


        // --- NEW HELPER METHOD ---
        private void ValidateConfirmPassword()
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                txtConfirmPassword.BackColor = SystemColors.Window;
            }
            else if (txtPassword.Text == txtConfirmPassword.Text && txtPassword.BackColor == Color.LightGreen)
            {
                // Only turns green if they match AND the main password is valid (>= 6 chars)
                txtConfirmPassword.BackColor = Color.LightGreen;
            }
            else
            {
                txtConfirmPassword.BackColor = Color.LightPink;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. Clear all text boxes
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtPhoneNumber.Clear();

            // 2. Reset ComboBoxes to have no selection
            cmbSubject.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;

            // 3. Reset all background colors back to default
            txtName.BackColor = SystemColors.Window;
            txtEmail.BackColor = SystemColors.Window;
            txtPassword.BackColor = SystemColors.Window;
            txtConfirmPassword.BackColor = SystemColors.Window;
            txtPhoneNumber.BackColor = SystemColors.Window;
            cmbSubject.BackColor = SystemColors.Window;
            cmbClass.BackColor = SystemColors.Window;

            // 4. Clear any error labels
            lblEmailError.Text = "";

            // 5. Re-run validation so the Register button disables itself again
            ValidateForm();

            // 6. Put the typing cursor back in the very first box
            txtName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}