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

namespace pomodist
{
    public partial class calendar : UserControl
    {
        private DateTime currentDate;
        string loggedInUser = SessionManager.Username;

        public calendar()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void ApplyLanguageCalendar()
        {
            monday.Text = LanguageManager.CurrentTexts["Monday"];
            tuesday.Text = LanguageManager.CurrentTexts["Tuesday"];
            wednesday.Text = LanguageManager.CurrentTexts["Wednesday"];
            thursday.Text = LanguageManager.CurrentTexts["Thursday"];
            friday.Text = LanguageManager.CurrentTexts["Friday"];
            saturday.Text = LanguageManager.CurrentTexts["Saturday"];
            sunday.Text = LanguageManager.CurrentTexts["Sunday"];

        }
        private void calendar_Load(object sender, EventArgs e)
        {
            currentDate = DateTime.Now; // initialize with today
            displayYear();
            displayMonthName();
            displayDays();
            ApplyLanguageCalendar();
        }
        private void displayYear()
        {
            string year = currentDate.Year.ToString();
            yearLabel.Text = year;
        }
        private void displayMonthName()
        {
            string monthName = currentDate.ToString("MMMM");
            monthLabel.Text = monthName;
        }
        private void displayDays()
        {
            DateTime startOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

            int firstDayOfMonth = ((int)startOfMonth.DayOfWeek + 6) % 7; // Monday = 0

            dayContainer.Controls.Clear();

            for (int i = 0; i < firstDayOfMonth; i++)
            {
                Panel emptyPanel = new Panel
                {
                    Size = new Size(111, 68),
                    BackColor = Color.Transparent
                };
                dayContainer.Controls.Add(emptyPanel);
            }

            // 📦 Load all tasks for the month ONCE
            Dictionary<int, List<string>> tasks = LoadTasksForMonth(currentDate.Year, currentDate.Month);

            for (int day = 1; day <= daysInMonth; day++)
            {
                dayPanel panel = new dayPanel(day.ToString());
                
                panel.EnableClickOnAllChildren(DayPanel_Click);


                // Check if there are tasks for this day
                if (tasks.ContainsKey(day))
                {
                    foreach (var taskName in tasks[day])
                    {
                        panel.AddTask(taskName);
                    }
                }

                dayContainer.Controls.Add(panel);
            }
        }

        private Dictionary<int, List<string>> LoadTasksForMonth(int year, int month)
        {
            Dictionary<int, List<string>> taskMap = new Dictionary<int, List<string>>();
            Database database = new Database();
            using (var conn = database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT taskName, endDate FROM tasks 
                         WHERE YEAR(endDate) = @year AND MONTH(endDate) = @month AND username = @loggedInUser";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@loggedInUser",loggedInUser);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string taskName = reader.GetString("taskName");
                            DateTime startDate = reader.GetDateTime("endDate");
                            int day = startDate.Day;

                            if (!taskMap.ContainsKey(day))
                                taskMap[day] = new List<string>();

                            taskMap[day].Add(taskName);
                        }
                    }
                }
            }

            return taskMap;
        }
        private void DayPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = (Control)sender;

            dayPanel clickedPanel = clickedControl as dayPanel;
            if (clickedPanel == null)
                clickedPanel = clickedControl.Parent as dayPanel;

            if (clickedPanel != null)
            {
                taskForm addForm = new taskForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshCalendar();
                }
            }
        }

        public void RefreshCalendar()
        {
            displayMonthName();
            displayDays();
        }

        private void dayContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nextButton_CheckedChanged(object sender, EventArgs e)
        {
            if (nextButton.Checked)
            {
                currentDate = currentDate.AddMonths(1); // move to next month
                displayMonthName();
                displayYear();
                displayDays();
                nextButton.Checked = false; // reset the button after click (optional, but usually good UX)
            }
        }

        private void prevButton_CheckedChanged(object sender, EventArgs e)
        {
            if (prevButton.Checked)
            {
                currentDate = currentDate.AddMonths(-1); // go back to n month
                displayMonthName();
                displayYear();
                displayDays();
                prevButton.Checked = false; // reset the button after click (optional, but usually good UX)
            }
        }
    }
}
