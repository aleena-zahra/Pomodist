using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace pomodist
{
    public partial class Pomodoro : UserControl
    {
        System.Timers.Timer timer1;
        int timeLeft;
        bool isTimerRunning;
        public static int timeSet = SettingsManager.PomodoroTime; // 60 minutes
        public string sessiionType = "pomodoro";//pomodooro,break,long break
        public Pomodoro()
        {
            InitializeComponent();

            timer1 = new System.Timers.Timer();
            timeLeft = timeSet * 60; // 60 minutes in seconds

            isTimerRunning = false;
            timer1.Interval = 1000;
            timer1.Elapsed += Timer1_Elapsed;

            UpdateTimerLabel();

        }

        private void Pomodoro_Load(object sender, EventArgs e)
        {
            UpdateTimerLabel();
            ApplyLanguageForPomodoroPage();

        }
        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                Invoke(new Action(UpdateTimerLabel));
            }
            else
            {
                timer1.Stop();
                isTimerRunning = false;
                Invoke(new Action(() => startButton.Text = "Start"));
                if (sessiionType == "pomodoro")
                {
                    sessiionType = "break";
                    Invoke(new Action(() =>
                    {
                        UpdateDatabase();
                        MessageBox.Show("Now take a break!");
                    }
                    ));
                }

            }
        }
        private void UpdateDatabase()
        {
            Database db = new Database();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO pomodoroSessions ( username, endTime, durationMinutes, pomodoroCount) " +
                                   "VALUES (@taskID, @username, @endTime, @durationMinutes, @pomodoroCount)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Replace with actual values; // Replace with actual taskID
                        cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername); // Replace with actual username
                        cmd.Parameters.AddWithValue("@endTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@durationMinutes", timeSet);
                        cmd.Parameters.AddWithValue("@pomodoroCount", 1); // Replace with actual pomodoro count

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timeLeft = SettingsManager.PomodoroTime * 60;
            timeSet = SettingsManager.PomodoroTime;
            UpdateTimerLabel();
            sessiionType = "pomodoro";
            this.BackColor = Color.Red;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            timeLeft = SettingsManager.ShortBreakTime * 60;
            timeSet = SettingsManager.ShortBreakTime;
            UpdateTimerLabel();
            sessiionType = "break";
            //change color of pomodoro page
            this.BackColor = Color.Yellow;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            timeLeft = SettingsManager.LongBreakTime * 60;
            timeSet = SettingsManager.LongBreakTime;
            UpdateTimerLabel();
            sessiionType = "long break";
            //change color of pomodoro page
            this.BackColor = Color.Yellow;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isTimerRunning)
            {
                timer1.Stop();
                startButton.Text = "Start";
            }
            else
            {
                timer1.Start();
                startButton.Text = "Pause";
            }
            ApplyLanguageForPomodoroPage();
            isTimerRunning = !isTimerRunning;
        }
        private void UpdateTimerLabel()
        {
            int hours = timeLeft / 3600;
            int minutes = (timeLeft % 3600) / 60;
            int seconds = timeLeft % 60;
            TimerLabel.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timeLeft = timeSet * 60; // Reset to 60 minutes
            isTimerRunning = false;
            startButton.Text = "Start";
            UpdateTimerLabel();
        }

        private void TimerLabel_Click(object sender, EventArgs e)
        {

        }
        public void ApplyLanguageForPomodoroPage()
        {
            guna2Button1.Text = LanguageManager.CurrentTexts["PomodBut"];
            startButton.Text = LanguageManager.CurrentTexts["StartButton"];
            stopButton.Text = LanguageManager.CurrentTexts["StopButton"];
            guna2Button3.Text = LanguageManager.CurrentTexts["ShortBreakButton"];
            guna2Button2.Text = LanguageManager.CurrentTexts["LongBreakButton"];
        }



    }
}
