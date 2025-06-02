using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pomodist.Properties;

namespace pomodist
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadPage(new Pomodoro());
        }
        public void LoadPage(UserControl page)
        {
            contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }
        private void pomodoroNavButton_Click(object sender, EventArgs e)
        {
            LoadPage(new Pomodoro());
        }
        public void ApplyLanguageToMainForm()
        {
            // Apply language settings to the main form

            pomodoroBtn.Text = LanguageManager.CurrentTexts["NavPomodist"];
            dashboardBtn.Text = LanguageManager.CurrentTexts["NavDashboard"];
            todoListBtn.Text = LanguageManager.CurrentTexts["NavToDoList"];
            calendarBtn.Text = LanguageManager.CurrentTexts["NavCalendar"];
            settingsBtn.Text = LanguageManager.CurrentTexts["NavSettings"];
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyLanguageToMainForm();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toDoListNavButton_Click(object sender, EventArgs e)
        {
            LoadPage(new ToDoList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPage(new calendar());
        }

        private void settingsNavbutton_Click(object sender, EventArgs e)
        {
            //pass the setting control the username 
            LoadPage(new settingsControl());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadPage(new Pomodoro());
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            ToggleSidebar();
        }
private void ToggleSidebar()
        {
            if (sidebarExpand)
            {
                // Shrink the sidebar  
                while (sideNavPanel.Width > 40)
                {
                    sideNavPanel.Width -= 10;
                    Application.DoEvents();
                }
            }
            else
            {
                // Expand the sidebar  
                while (sideNavPanel.Width < 130)
                {
                    sideNavPanel.Width += 10;
                    Application.DoEvents();
                }
            }
            sidebarTransition.Stop();
            sidebarExpand = !sidebarExpand;
        }

      



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!sidebarTransition.Enabled)
            {
                sidebarTransition.Start();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
             LoadPage(new Dashboard());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadPage(new ToDoList());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadPage(new calendar());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoadPage(new settingsControl());
        }

        private void sideNavPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadPage(new Pomodoro());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadPage(new Dashboard());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LoadPage(new ToDoList());   
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LoadPage(new calendar());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LoadPage(new settingsControl());
        }
    }
}