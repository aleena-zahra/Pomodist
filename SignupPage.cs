using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pomodist
{
    public partial class SignupPage : Form
    {
        
        public SignupPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void ApplyLanguageForSignup()
        {
            this.Text = LanguageManager.CurrentTexts["SignupTitle"];
            fnTextBox.Text = LanguageManager.CurrentTexts["FirstNamePlaceholder"];
            lnTextBox.Text = LanguageManager.CurrentTexts["LastNamePlaceholder"];
            emailTextBox.Text = LanguageManager.CurrentTexts["EmailPlaceholder"];
            passwordTextBox.Text = LanguageManager.CurrentTexts["PasswordPlaceholder"];
            showPasswordCheckBox.Text = LanguageManager.CurrentTexts["ShowPasswordCheckbox"];
            signupBtn.Text = LanguageManager.CurrentTexts["SignupButton"];
            noAccountLabel.Text = LanguageManager.CurrentTexts["AlreadyHaveAccountLabel"];
            loginPageBtn.Text = LanguageManager.CurrentTexts["LoginButtonBelow"];
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {
            ApplyLanguageForSignup();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void noAccountLabel_Click(object sender, EventArgs e)
        {

        }

        private void signupPageBtn_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string firstName = fnTextBox.Text.Trim();
            string lastName = lnTextBox.Text.Trim();
            string username = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password.Length > 15)
            {
                MessageBox.Show("Password must not exceed 15 characters.");
                return;
            }
            if (firstName.Length < 2 || !firstName.All(char.IsLetter))
            {
                MessageBox.Show("First name must be at least 2 letters and only alphabets.");
                return;
            }

            if (lastName.Length < 2 || !lastName.All(char.IsLetter))
            {
                MessageBox.Show("Last name must be at least 2 letters and only alphabets.");
                return;
            }

            if (!IsValidUsername(username))
            {
                MessageBox.Show("Username must be at least 4 characters and contain only letters, numbers, or underscores.");
                return;
            }

            if (password.Length < 8 || password.Length > 15 || !password.Any(char.IsLetter) || !password.Any(char.IsDigit))
            {
                MessageBox.Show("Password must be 8-15 characters and contain both letters and numbers.");
                return;
            }

            

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);


            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (first_name, last_name, username, password_hash) VALUES (@fn, @ln, @username, @pwd)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fn", firstName);
                        cmd.Parameters.AddWithValue("@ln", lastName);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@pwd", hashedPassword);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("User registered successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");

                }
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            Hide();
        }
        private bool IsValidUsername(string username)
        {
            if (username.Length < 4)
                return false;

            return username.All(c => char.IsLetterOrDigit(c) || c == '_');
        }


    }
}
