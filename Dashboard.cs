using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace pomodist
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardcs_Load(object sender, EventArgs e)
        {

        }

        private void LoadChartData()
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT status, COUNT(*) as count FROM tasks WHERE username = @username GROUP BY status";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            chart1.Series["TasksByStatus"].Points.Clear();

                            while (reader.Read())
                            {
                                string status = reader["status"].ToString();
                                int count = Convert.ToInt32(reader["count"]);

                                chart1.Series["TasksByStatus"].Points.AddXY(status, count);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading chart data: " + ex.Message);
                }
            }
        }


        private void LoadDoughnutChart()
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT priority, COUNT(*) as count FROM tasks WHERE username = @username GROUP BY priority";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            chart2.Series["PriorityBreakdown"].Points.Clear();

                            while (reader.Read())
                            {
                                string priority = reader["priority"].ToString();
                                int count = Convert.ToInt32(reader["count"]);

                                chart2.Series["PriorityBreakdown"].Points.AddXY(priority, count);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Doughnut Chart Error: " + ex.Message);
                }
            }

            chart2.Series["PriorityBreakdown"].ChartType = SeriesChartType.Doughnut;
        }




        private void LoadStackedColumnChart()
        {
            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT status, priority, COUNT(*) as count FROM tasks WHERE username = @username GROUP BY status, priority";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear old data
                            chart3.Series.Clear();

                            // Add series for each priority level
                            var priorities = new[] { "High", "Medium", "Low" };
                            foreach (var priority in priorities)
                            {
                                Series series = new Series(priority)
                                {
                                    ChartType = SeriesChartType.StackedColumn
                                };
                                chart3.Series.Add(series);
                            }

                            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

                            while (reader.Read())
                            {
                                string status = reader["status"].ToString();
                                string priority = reader["priority"].ToString();
                                int count = Convert.ToInt32(reader["count"]);

                                if (!data.ContainsKey(status))
                                    data[status] = new Dictionary<string, int>();

                                data[status][priority] = count;
                            }

                            foreach (var status in data.Keys)
                            {
                                foreach (var priority in priorities)
                                {
                                    int value = data[status].ContainsKey(priority) ? data[status][priority] : 0;
                                    chart3.Series[priority].Points.AddXY(status, value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Stacked Column Chart Error: " + ex.Message);
                }
            }
        }



        public void ApplyLanguageForDashboard()
        {
            // Apply language settings to the dashboard
            this.Text = LanguageManager.CurrentTexts["DashboardLabel"];
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ApplyLanguageForDashboard();
            LoadChartData();
            LoadDoughnutChart();
            LoadStackedColumnChart();
            UpdateProgressBar();

        }

        private void UpdateProgressBar()
        {
            int totalTasks = 0;
            int completedTasks = 0;

            Database db = new Database();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT status FROM tasks WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalTasks++;
                                if (reader["status"].ToString().ToLower() == "Completed")
                                {
                                    completedTasks++;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading progress data: " + ex.Message);
                }
            }




            // 🏷️ Optional label
            //labelProgress.Text = $"Completed: {completedTasks}/{totalTasks}";
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click_1(object sender, EventArgs e)
        {

        }

        private void chart3_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}