using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pomodist
{
    

    public partial class LoginPage : Form
    {
        public static string enteredUsername;
        public string enteredPassword;
        public LoginPage()
        {
            InitializeComponent();
        }
        public void ApplyLanguage()
        {
            label1.Text = LanguageManager.CurrentTexts["UsernameLabel"];
            label2.Text = LanguageManager.CurrentTexts["PasswordLabel"];
            //guna2button1.Text = LanguageManager.CurrentTexts["LoginButton"];
            this.Text = LanguageManager.CurrentTexts["FormTitle"];
        }



        private void LoginPage_Load(object sender, EventArgs e)
        {
            ApplyLanguage();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            enteredUsername = usernameTextBox.Text.Trim();
            enteredPassword = passwordTextBox.Text.Trim();
            //display the entered username and password
            
            
            if (ValidateCredentials(enteredUsername, enteredPassword))
            {
                MessageBox.Show("come here");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
            MessageBox.Show("dont come here");
        }
     

        private bool ValidateCredentials(string username, string password)
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password_hash FROM users WHERE username = @username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string storedPasswordHash = result.ToString();

                            // Compare the entered password with the hashed password in the database
                            if (BCrypt.Net.BCrypt.Verify(password, storedPasswordHash))
                            {
                                //globalVariables.username = username;
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                                SessionManager.Username = username;
                                return true; // Login successful
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}");
                }
            }

            MessageBox.Show("Invalid username or password.");
            return false;
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        //private void signupPageBtn_Click(object sender, EventArgs e)
        //{
        //    SignupPage signupPage = new SignupPage();
        //    signupPage.Show();
        //    Hide();
        //}

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            enteredUsername = usernameTextBox.Text.Trim();
            enteredPassword = passwordTextBox.Text.Trim();
            //display the entered username and password


            if (ValidateCredentials(enteredUsername, enteredPassword))
            {
                //PomodoroPage pomodoroPage = new PomodoroPage();
                //pomodoroPage.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SignupPage signupPage = new SignupPage();
            signupPage.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
