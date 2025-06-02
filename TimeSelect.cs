using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pomodist
{
    public partial class TimeSelect : Form
    {
        public int timeSet = 60;
        public TimeSelect(int time)
        {
            timeSet = time;
            InitializeComponent();
        }

        private void TimeSelect_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeSet--;
            label1.Text = $"{timeSet:D2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{timeSet:D2}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeSet++;
            label1.Text = $"{timeSet:D2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
