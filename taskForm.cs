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
    public partial class taskForm : Form
    {
        private bool isEditMode = false;
        private string editingTaskID = "";

        public taskForm()
        {
            InitializeComponent();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string taskName = taskNameTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();
            string priority = PriorityComboBox.Text.Trim();
            string status = StatusComboBox.Text.Trim();
            string label = labelComboBox.Text.Trim();
            string endDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Database db = new Database();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query;

                    if (isEditMode)
                    {
                        // UPDATE existing task
                        query = "UPDATE tasks SET taskName = @taskName, description = @description, priority = @priority, label = @label, status = @status, endDate = @endDate WHERE taskID = @taskID";
                    }
                    else
                    {
                        // INSERT new task
                        query = "INSERT INTO tasks (taskName, description, priority, label, status, endDate, username) VALUES (@taskName, @description, @priority, @label, @status, @endDate, @username)";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@taskName", taskName);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@priority", priority);
                        cmd.Parameters.AddWithValue("@label", label);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@endDate", endDate);

                        if (isEditMode)
                        {
                            cmd.Parameters.AddWithValue("@taskID", editingTaskID);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@username", LoginPage.enteredUsername);
                        }

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(isEditMode ? "Task updated successfully!" : "Task added successfully!");
                    this.Close(); // Close the form after save
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void taskForm_Load(object sender, EventArgs e)
        {
            ApplyLanguageForTaskForm();
        }
        public void setTaskData(string taskID, string taskName, string description, string priority, string label, string status, string startDate, string endDate)
        {
            isEditMode = true; // THIS tells the form it's editing, not adding.
            editingTaskID = taskID;
            taskNameTextBox.Text = taskName;
            descriptionTextBox.Text = description;
            PriorityComboBox.Text = priority;
            labelComboBox.Text = label;
            StatusComboBox.Text = status;
            dateTimePicker1.Value = DateTime.Parse(endDate);
        }
        public void ApplyLanguageForTaskForm()
        {
            this.Text = LanguageManager.CurrentTexts["CreateTaskTitle"];
            loginLabel.Text = LanguageManager.CurrentTexts["CreateTaskTitle"];
            taskNameTextBox.PlaceholderText = LanguageManager.CurrentTexts["TaskTitlePlaceholder"];
            label1.Text = LanguageManager.CurrentTexts["DescriptionLabel"];
            label5.Text = LanguageManager.CurrentTexts["PriorityLabel"];
            label6.Text = LanguageManager.CurrentTexts["StatusLabel"];
            label7.Text = LanguageManager.CurrentTexts["LabelLabel"];
            guna2Button1.Text = LanguageManager.CurrentTexts["AddTaskButton"];
        }

    }
}
