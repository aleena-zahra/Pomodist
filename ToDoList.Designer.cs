namespace pomodist
{
    partial class ToDoList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.addTaskButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.todoListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.addTaskButton.BorderRadius = 8;
            this.addTaskButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addTaskButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addTaskButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addTaskButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addTaskButton.FillColor = System.Drawing.Color.BurlyWood;
            this.addTaskButton.Font = new System.Drawing.Font("Broadway", 9F);
            this.addTaskButton.ForeColor = System.Drawing.Color.Black;
            this.addTaskButton.Location = new System.Drawing.Point(778, 21);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(114, 24);
            this.addTaskButton.TabIndex = 44;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-13, 49);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(943, 417);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // todoListLabel
            // 
            this.todoListLabel.AutoSize = true;
            this.todoListLabel.BackColor = System.Drawing.Color.Transparent;
            this.todoListLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoListLabel.ForeColor = System.Drawing.Color.Black;
            this.todoListLabel.Location = new System.Drawing.Point(2, 2);
            this.todoListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todoListLabel.Name = "todoListLabel";
            this.todoListLabel.Size = new System.Drawing.Size(144, 37);
            this.todoListLabel.TabIndex = 49;
            this.todoListLabel.Text = "To Do List";
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.todoListLabel);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ToDoList";
            this.Size = new System.Drawing.Size(930, 468);
            this.Load += new System.EventHandler(this.ToDoList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addTaskButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label todoListLabel;
    }
}
