using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace pomodist
{
    public partial class taskPanel : UserControl
    {
      
        public taskPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                Database db = new Database();
                using (MySqlConnection conn = db.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM tasks WHERE taskID = @taskID";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@taskID", taskID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Task deleted successfully!");

                            // Remove this task panel from its parent container
                            this.Parent.Controls.Remove(this);
                            this.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void taskPanel_Load(object sender, EventArgs e)
        {
            ApplyLanguageForTaskPanel();
        }
        public void ApplyLanguageForTaskPanel()
        {
            descriptionL.Text = LanguageManager.CurrentTexts["TaskPanelDescription"];
            priorityL.Text = LanguageManager.CurrentTexts["TaskPanelPriority"];
            labelL.Text = LanguageManager.CurrentTexts["TaskPanelLabel"];
            statusL.Text = LanguageManager.CurrentTexts["TaskPanelStatus"];
            startL.Text = LanguageManager.CurrentTexts["TaskPanelStartDate"];
            endL.Text = LanguageManager.CurrentTexts["TaskPanelEndDate"];
            editButton.Text = LanguageManager.CurrentTexts["TaskPanelEditButton"];
            completeButton.Text = LanguageManager.CurrentTexts["TaskPanelCompleteButton"];
            deleteButton.Text = LanguageManager.CurrentTexts["TaskPanelDeleteButton"];

        }
        public string taskID { get; set; }
        private void editButton_Click(object sender, EventArgs e)
        {
            taskForm editForm = new taskForm();

            // Pre-fill the form with existing task data
            editForm.setTaskData(
                taskID,
                titleLabel.Text,
                descriptionLabel.Text,
                priorityLabel.Text,
                label.Text,
                statusLabel.Text,
                startTimeLabel.Text,
                endTimeLabel.Text
            );

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // After editing and saving, refresh UI
                Database db = new Database();
                using (MySqlConnection conn = db.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = @"UPDATE tasks 
                                 SET taskName = @taskName, description = @description, priority = @priority, 
                                     label = @label, status = @status, endDate = @endDate 
                                 WHERE taskID = @taskID";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@taskID", taskID);
                            cmd.Parameters.AddWithValue("@taskName", editForm.taskNameTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", editForm.descriptionTextBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@priority", editForm.PriorityComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@label", editForm.labelComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", editForm.StatusComboBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@endDate", editForm.dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                            cmd.ExecuteNonQuery();
                        }

                        // Reflect changes immediately on UI
                        titleLabel.Text = editForm.taskNameTextBox.Text.Trim();
                        descriptionLabel.Text = editForm.descriptionTextBox.Text.Trim();
                        priorityLabel.Text = editForm.PriorityComboBox.Text.Trim();
                        label.Text = editForm.labelComboBox.Text.Trim();
                        statusLabel.Text = editForm.StatusComboBox.Text.Trim();
                        endTimeLabel.Text = editForm.dateTimePicker1.Value.ToString("yyyy-MM-dd");

                        MessageBox.Show("Task updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void completeButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE tasks SET status = 'Completed' WHERE taskID = @taskID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@taskID", taskID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Task marked as completed!");

                        // Update the UI immediately too
                        statusLabel.Text = "Completed";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
