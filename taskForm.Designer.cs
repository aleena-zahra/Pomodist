namespace pomodist
{
    partial class taskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taskForm));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.labelComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StatusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PriorityComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.taskNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Label";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Priority";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.BurlyWood;
            this.guna2Button1.Font = new System.Drawing.Font("Broadway", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(24, 366);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(114, 24);
            this.guna2Button1.TabIndex = 54;
            this.guna2Button1.Text = "Add Task";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // labelComboBox
            // 
            this.labelComboBox.AllowDrop = true;
            this.labelComboBox.BackColor = System.Drawing.Color.Transparent;
            this.labelComboBox.BorderRadius = 20;
            this.labelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.labelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.labelComboBox.FillColor = System.Drawing.Color.BurlyWood;
            this.labelComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.labelComboBox.ItemHeight = 30;
            this.labelComboBox.Items.AddRange(new object[] {
            "Work",
            "Study",
            "Leisure"});
            this.labelComboBox.Location = new System.Drawing.Point(101, 250);
            this.labelComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.labelComboBox.Name = "labelComboBox";
            this.labelComboBox.Size = new System.Drawing.Size(170, 36);
            this.labelComboBox.TabIndex = 53;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.AllowDrop = true;
            this.StatusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusComboBox.BorderRadius = 20;
            this.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FillColor = System.Drawing.Color.BurlyWood;
            this.StatusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StatusComboBox.ItemHeight = 30;
            this.StatusComboBox.Items.AddRange(new object[] {
            "To Do",
            "In Progress",
            "Completed",
            "Overdue"});
            this.StatusComboBox.Location = new System.Drawing.Point(101, 200);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(170, 36);
            this.StatusComboBox.TabIndex = 52;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.AllowDrop = true;
            this.PriorityComboBox.BackColor = System.Drawing.Color.Transparent;
            this.PriorityComboBox.BorderRadius = 20;
            this.PriorityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityComboBox.FillColor = System.Drawing.Color.BurlyWood;
            this.PriorityComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriorityComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriorityComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PriorityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PriorityComboBox.ItemHeight = 30;
            this.PriorityComboBox.Items.AddRange(new object[] {
            "High",
            "Low",
            "Medium",
            "No Priority",
            "Urgent"});
            this.PriorityComboBox.Location = new System.Drawing.Point(101, 152);
            this.PriorityComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(170, 36);
            this.PriorityComboBox.Sorted = true;
            this.PriorityComboBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.descriptionTextBox.BorderRadius = 8;
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(102, 99);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PlaceholderText = "";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.Size = new System.Drawing.Size(169, 48);
            this.descriptionTextBox.TabIndex = 49;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(22, 9);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(164, 37);
            this.loginLabel.TabIndex = 48;
            this.loginLabel.Text = "Create Task";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.taskNameTextBox.BorderRadius = 8;
            this.taskNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taskNameTextBox.DefaultText = "Task Title";
            this.taskNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.taskNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.taskNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.taskNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.taskNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.taskNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.taskNameTextBox.Location = new System.Drawing.Point(24, 49);
            this.taskNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.PlaceholderText = "";
            this.taskNameTextBox.SelectedText = "";
            this.taskNameTextBox.Size = new System.Drawing.Size(169, 24);
            this.taskNameTextBox.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "Date Due";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // taskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(303, 430);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.labelComboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.PriorityComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.taskNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "taskForm";
            this.Text = "taskForm";
            this.Load += new System.EventHandler(this.taskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2ComboBox labelComboBox;
        public Guna.UI2.WinForms.Guna2ComboBox StatusComboBox;
        public Guna.UI2.WinForms.Guna2ComboBox PriorityComboBox;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        public System.Windows.Forms.Label loginLabel;
        public Guna.UI2.WinForms.Guna2TextBox taskNameTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}