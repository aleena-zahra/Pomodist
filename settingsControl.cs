using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NAudio.Wave;
using System.Diagnostics;

namespace pomodist
{
    public partial class settingsControl : UserControl
    {
        public settingsControl()
        {
            InitializeComponent();
            InitializeLanguageDropdown(); //this is new
            ApplyLanguageForSettingsForm();

            InitializeBreakTimes();
        }

        private void InitializeBreakTimes()
        {
            button1.Text = $"{SettingsManager.PomodoroTime:D2}";
            button2.Text = $"{SettingsManager.ShortBreakTime:D2}";
            button3.Text = $"{SettingsManager.LongBreakTime:D2}";
        }

        private void InitializeLanguageDropdown()
        {
            // Assuming comboBox1 is for language selection
            comboBox1.Items.Clear();
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("French");
            comboBox1.Items.Add("Spanish");
            comboBox1.Items.Add("Urdu");

            // Load saved language preference
            string savedLanguage = Properties.Settings.Default.Language;
            if (!string.IsNullOrEmpty(savedLanguage) && comboBox1.Items.Contains(savedLanguage))
            {
                comboBox1.SelectedItem = savedLanguage;
            }

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TimeSelect form = new TimeSelect(SettingsManager.PomodoroTime);
            if (form.ShowDialog() == DialogResult.OK)
            {
                int selectedTime = form.timeSet;
                button1.Text = $"{selectedTime:D2}";
                SettingsManager.PomodoroTime = selectedTime;
            }
        }

        private void DarkModeTogglebutton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSelect form = new TimeSelect(SettingsManager.ShortBreakTime);
            if (form.ShowDialog() == DialogResult.OK)
            {
                int selectedTime = form.timeSet;
                button2.Text = $"{selectedTime:D2}";
                SettingsManager.ShortBreakTime = selectedTime;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBox1.SelectedItem.ToString();
            LanguageManager.SetLanguage(selectedLanguage);
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            MainForm mainForm = new MainForm();
            mainForm.Close();




        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> soundPaths = new Dictionary<string, string>
            {
                { "Rain", @"D:\Downloads\iteration2\pomodist\Sounds\rain.wav" },
                { "Chirping", @"D:\Downloads\iteration2\pomodist\Sounds\chirping.wav" },
                { "Breeze", @"D:\Downloads\iteration2\pomodist\Sounds\breeze.wav" },
                { "Bells", @"C:\Users\app\OneDrive\Desktop\pomodist\bin\Debug\Sounds\bells.wav" }
            };


            // Get selected sound
            string selectedSound = comboBox2.SelectedItem.ToString();

            if (soundPaths.ContainsKey(selectedSound))
            {
                string path = soundPaths[selectedSound];

                if (File.Exists(path))
                {
                    try
                    {
                        SoundPlayer player = new SoundPlayer(path);
                        player.Load();  // Preload to check for errors
                        player.Play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error playing sound: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("File not found: " + path);
                }
            }
        }
        private void changeName(string firstName, string lastName)
        {
            using (MySqlConnection conn = new Database().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET first_name = @firstName, last_name = @lastName WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Name updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update name.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //on entering the text here the old password will be replaced with the new one
            string newPassword = usernameTextBox.Text.Trim();
            string newFirstName = firstNameTextBox.Text.Trim();
            string newLastName = lastNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(newFirstName) || string.IsNullOrEmpty(newLastName) == false)
            {
                changeName(newFirstName, newLastName);

            }
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }
            if (newPassword.Length > 15)
            {
                MessageBox.Show("Password must not exceed 15 characters.");
                return;
            }
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
            using (MySqlConnection conn = new Database().GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET password_hash = @pwd WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pwd", hashedPassword);
                        cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSelect form = new TimeSelect(SettingsManager.LongBreakTime);
            if (form.ShowDialog() == DialogResult.OK)
            {
                int selectedTime = form.timeSet;
                button3.Text = $"{selectedTime:D2}";
                SettingsManager.LongBreakTime = selectedTime;
            }
        }


        private void SaveRatingToDatabase(int rating)
        {

            string query = "insert into ratings value (@username, @rating)";

            using (MySqlConnection conn = new Database().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Rating", rating);
                    cmd.Parameters.AddWithValue("@Username", LoginPage.enteredUsername); // Make sure this variable holds the logged-in username

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rating updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update rating.");
                    }
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int rating = (int)guna2RatingStar1.Value;
            SaveRatingToDatabase(rating);
            MessageBox.Show($"rating: {rating}");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }


        public void ApplyLanguageForSettingsForm()
        {
            label4.Text = LanguageManager.CurrentTexts["SettingsTitle"];
            label5.Text = LanguageManager.CurrentTexts["ProfileLabel"];
            label13.Text = LanguageManager.CurrentTexts["CFNLabel"];
            label14.Text = LanguageManager.CurrentTexts["CFLLabel"];
            label6.Text = LanguageManager.CurrentTexts["CPLabel"];
            guna2Button2.Text = LanguageManager.CurrentTexts["CButton"];

            label1.Text = LanguageManager.CurrentTexts["OL"];
            label8.Text = LanguageManager.CurrentTexts["PomoL"];
            label3.Text = LanguageManager.CurrentTexts["Short"];
            label2.Text = LanguageManager.CurrentTexts["LongL"];
            label9.Text = LanguageManager.CurrentTexts["SoL"];
            guna2Button4.Text = LanguageManager.CurrentTexts["StButton"];

            label10.Text = LanguageManager.CurrentTexts["RL"];
            guna2Button3.Text = LanguageManager.CurrentTexts["SButton"]; // (if second Stop button exists)

            label7.Text = LanguageManager.CurrentTexts["LangL"];
            label12.Text = LanguageManager.CurrentTexts["FeedL"];
            label11.Text = LanguageManager.CurrentTexts["FL"];
            guna2Button5.Text = LanguageManager.CurrentTexts["SubButton"];
            guna2Button1.Text = LanguageManager.CurrentTexts["Lbutton"];
        }

        //private void settingsControl_Load(object sender, EventArgs e)
        //{
        //    ApplyLanguageForSettingsForm();
        //}




        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.google.com/forms/d/e/1FAIpQLSdtyt_tcc4c8iK09UIj7rtv8bvsWRxWbHHzztCbNEvB8wjibQ/viewform?pli=1",
                UseShellExecute = true
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

