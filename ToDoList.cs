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
    public partial class ToDoList : UserControl
    {
        string loggedInUser = SessionManager.Username;
        public ToDoList()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            taskForm taskForm = new taskForm();
            taskForm.Show();


        }
        private void LoadTasks()
        {
            Database db = new Database();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT taskID, taskName, description, priority, label, status, startDate, endDate FROM tasks WHERE username = @loggedInUser";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@loggedInUser", loggedInUser);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AddTaskCard(
                                    reader["taskID"].ToString(),
                                    reader["taskName"].ToString(),
                                    reader["description"].ToString(),
                                    reader["priority"].ToString(),
                                    reader["label"].ToString(),
                                    reader["status"].ToString(),
                                    reader["startDate"].ToString(),
                                    reader["endDate"].ToString()

                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddTaskCard(string taskID,string name, string description, string priority, string label, string status, string startDate, string endDate)
        {
            // Create an instance of your predesigned taskPanel UserControl
            taskPanel task = new taskPanel();
            task.taskID = taskID;
            // Set the texts for the labels
            task.titleLabel.Text = name;
            task.descriptionLabel.Text = description;
            task.priorityLabel.Text = priority;
            task.label.Text = label;
            task.statusLabel.Text = status;
            task.startTimeLabel.Text = startDate;
            task.endTimeLabel.Text = endDate;
            

            // Set the color of the task based on its priority
            switch (priority.ToLower())
            {
                case "high":
                    task.BackColor = Color.Red;
                    break;
                case "medium":
                    task.BackColor = Color.Yellow;
                    break;
                case "low":
                    task.BackColor = Color.Green;
                    break;
                default:
                    task.BackColor = Color.RosyBrown; // Default color
                    break;
            }

            // Add the ready task panel into the flow layout
            flowLayoutPanel1.Controls.Add(task);
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ApplyLanguageToDoList()
        {
            this.todoListLabel.Text = LanguageManager.CurrentTexts["ToDoListLabel"];
            this.addTaskButton.Text = LanguageManager.CurrentTexts["addTaskButton"];
        }
        private void ToDoList_Load(object sender, EventArgs e)
        {
            ApplyLanguageToDoList();
        }
    }
}
