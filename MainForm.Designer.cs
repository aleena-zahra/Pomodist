namespace pomodist
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.navBarLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pomodoroBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.sideNavPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dashboardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.todoListBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.calendarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.sideNavPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(44, 40);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(930, 436);
            this.contentPanel.TabIndex = 9;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.navBarLabel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 34);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // navBarLabel
            // 
            this.navBarLabel.BackColor = System.Drawing.Color.Transparent;
            this.navBarLabel.Location = new System.Drawing.Point(51, 7);
            this.navBarLabel.Name = "navBarLabel";
            this.navBarLabel.Size = new System.Drawing.Size(134, 15);
            this.navBarLabel.TabIndex = 14;
            this.navBarLabel.Text = "Aleena | Muaz | FSE Project";
            this.navBarLabel.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pomodoroBtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 40);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pomodoroBtn
            // 
            this.pomodoroBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pomodoroBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pomodoroBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pomodoroBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pomodoroBtn.FillColor = System.Drawing.Color.BurlyWood;
            this.pomodoroBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pomodoroBtn.ForeColor = System.Drawing.Color.Black;
            this.pomodoroBtn.Location = new System.Drawing.Point(-38, -7);
            this.pomodoroBtn.Name = "pomodoroBtn";
            this.pomodoroBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pomodoroBtn.PressedColor = System.Drawing.Color.Peru;
            this.pomodoroBtn.Size = new System.Drawing.Size(214, 54);
            this.pomodoroBtn.TabIndex = 1;
            this.pomodoroBtn.Text = "Pomodist";
            this.pomodoroBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.Controls.Add(this.panel2);
            this.sideNavPanel.Controls.Add(this.panel3);
            this.sideNavPanel.Controls.Add(this.panel4);
            this.sideNavPanel.Controls.Add(this.panel5);
            this.sideNavPanel.Controls.Add(this.panel6);
            this.sideNavPanel.Location = new System.Drawing.Point(0, 40);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(39, 231);
            this.sideNavPanel.TabIndex = 10;
            this.sideNavPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sideNavPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.dashboardBtn);
            this.panel3.Location = new System.Drawing.Point(3, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 40);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardBtn.FillColor = System.Drawing.Color.BurlyWood;
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashboardBtn.ForeColor = System.Drawing.Color.Black;
            this.dashboardBtn.Location = new System.Drawing.Point(-38, -16);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.dashboardBtn.PressedColor = System.Drawing.Color.Peru;
            this.dashboardBtn.Size = new System.Drawing.Size(214, 73);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.todoListBtn);
            this.panel4.Location = new System.Drawing.Point(3, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(126, 40);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // todoListBtn
            // 
            this.todoListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.todoListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.todoListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.todoListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.todoListBtn.FillColor = System.Drawing.Color.BurlyWood;
            this.todoListBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.todoListBtn.ForeColor = System.Drawing.Color.Black;
            this.todoListBtn.Location = new System.Drawing.Point(-38, -16);
            this.todoListBtn.Name = "todoListBtn";
            this.todoListBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.todoListBtn.PressedColor = System.Drawing.Color.Peru;
            this.todoListBtn.Size = new System.Drawing.Size(214, 72);
            this.todoListBtn.TabIndex = 1;
            this.todoListBtn.Text = "To Do List";
            this.todoListBtn.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.calendarBtn);
            this.panel5.Location = new System.Drawing.Point(3, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(126, 40);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // calendarBtn
            // 
            this.calendarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calendarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calendarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calendarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calendarBtn.FillColor = System.Drawing.Color.BurlyWood;
            this.calendarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calendarBtn.ForeColor = System.Drawing.Color.Black;
            this.calendarBtn.Location = new System.Drawing.Point(-38, -29);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.calendarBtn.PressedColor = System.Drawing.Color.Peru;
            this.calendarBtn.Size = new System.Drawing.Size(214, 95);
            this.calendarBtn.TabIndex = 1;
            this.calendarBtn.Text = "Calendar  ";
            this.calendarBtn.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.settingsBtn);
            this.panel6.Location = new System.Drawing.Point(3, 187);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(126, 40);
            this.panel6.TabIndex = 4;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.BurlyWood;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsBtn.ForeColor = System.Drawing.Color.Black;
            this.settingsBtn.Location = new System.Drawing.Point(-38, -17);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.settingsBtn.PressedColor = System.Drawing.Color.Peru;
            this.settingsBtn.Size = new System.Drawing.Size(214, 76);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(980, 440);
            this.Controls.Add(this.sideNavPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contentPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Pomodist";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.sideNavPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button pomodoroBtn;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.FlowLayoutPanel sideNavPanel;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button dashboardBtn;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button todoListBtn;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button calendarBtn;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2HtmlLabel navBarLabel;
    }
}