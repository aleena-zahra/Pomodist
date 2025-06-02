using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodist
{
    public partial class dayPanel : UserControl
    {
        string date;
        private int taskCount = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public dayPanel(string date)
        {
            InitializeComponent();
            this.date = date;
            dateLabel.Text = date;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
        public void AddTask(string taskName)
        {
            taskCount++;

            if (taskCount == 1)
            {
                label1.Text = taskName;
                label1.Visible = true;
            }
            else if (taskCount == 2)
            {
                label2.Text = taskName;
                label2.Visible = true;
            }
            else if (taskCount == 3)
            {
                label3.Text = taskName;
                label3.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void EnableClickOnAllChildren(EventHandler handler)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Click += handler;
            }
            this.Click += handler; // itself too
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
