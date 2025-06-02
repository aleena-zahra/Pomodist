namespace pomodist
{
    partial class taskPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(taskPanel));
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionL = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.statusL = new System.Windows.Forms.Label();
            this.priorityL = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startL = new System.Windows.Forms.Label();
            this.endL = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.BackColor = System.Drawing.Color.BurlyWood;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(15, 198);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(69, 28);
            this.editButton.TabIndex = 17;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.BackColor = System.Drawing.Color.BurlyWood;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(124, 198);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 28);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // completeButton
            // 
            this.completeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.completeButton.BackColor = System.Drawing.Color.BurlyWood;
            this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.completeButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeButton.Location = new System.Drawing.Point(234, 198);
            this.completeButton.Margin = new System.Windows.Forms.Padding(2);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(101, 28);
            this.completeButton.TabIndex = 19;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = false;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Black;
            this.titleLabel.Location = new System.Drawing.Point(18, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(59, 30);
            this.titleLabel.TabIndex = 49;
            this.titleLabel.Text = "Title";
            this.titleLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // descriptionL
            // 
            this.descriptionL.AutoSize = true;
            this.descriptionL.BackColor = System.Drawing.Color.Transparent;
            this.descriptionL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionL.ForeColor = System.Drawing.Color.Black;
            this.descriptionL.Location = new System.Drawing.Point(20, 57);
            this.descriptionL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.Size = new System.Drawing.Size(69, 15);
            this.descriptionL.TabIndex = 51;
            this.descriptionL.Text = "Description";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.startTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.startTimeLabel.Location = new System.Drawing.Point(101, 137);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(132, 15);
            this.startTimeLabel.TabIndex = 52;
            this.startTimeLabel.Text = "DD/MM/YYYY 00:00:00";
            // 
            // statusL
            // 
            this.statusL.AutoSize = true;
            this.statusL.BackColor = System.Drawing.Color.Transparent;
            this.statusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusL.ForeColor = System.Drawing.Color.Black;
            this.statusL.Location = new System.Drawing.Point(20, 109);
            this.statusL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(41, 15);
            this.statusL.TabIndex = 53;
            this.statusL.Text = "Status";
            // 
            // priorityL
            // 
            this.priorityL.AutoSize = true;
            this.priorityL.BackColor = System.Drawing.Color.Transparent;
            this.priorityL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityL.ForeColor = System.Drawing.Color.Black;
            this.priorityL.Location = new System.Drawing.Point(20, 85);
            this.priorityL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priorityL.Name = "priorityL";
            this.priorityL.Size = new System.Drawing.Size(44, 15);
            this.priorityL.TabIndex = 54;
            this.priorityL.Text = "Priority";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.BackColor = System.Drawing.Color.Transparent;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.ForeColor = System.Drawing.Color.Black;
            this.priorityLabel.Location = new System.Drawing.Point(101, 85);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(44, 15);
            this.priorityLabel.TabIndex = 55;
            this.priorityLabel.Text = "Priority";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(101, 57);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(147, 15);
            this.descriptionLabel.TabIndex = 56;
            this.descriptionLabel.Text = "Kind of a long Description";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(101, 109);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 15);
            this.statusLabel.TabIndex = 57;
            this.statusLabel.Text = "Status";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.endTimeLabel.Location = new System.Drawing.Point(101, 161);
            this.endTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(132, 15);
            this.endTimeLabel.TabIndex = 58;
            this.endTimeLabel.Text = "DD/MM/YYYY 00:00:00";
            // 
            // startL
            // 
            this.startL.AutoSize = true;
            this.startL.BackColor = System.Drawing.Color.Transparent;
            this.startL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startL.ForeColor = System.Drawing.Color.Black;
            this.startL.Location = new System.Drawing.Point(23, 137);
            this.startL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startL.Name = "startL";
            this.startL.Size = new System.Drawing.Size(63, 15);
            this.startL.TabIndex = 59;
            this.startL.Text = "Start Time";
            // 
            // endL
            // 
            this.endL.AutoSize = true;
            this.endL.BackColor = System.Drawing.Color.Transparent;
            this.endL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endL.ForeColor = System.Drawing.Color.Black;
            this.endL.Location = new System.Drawing.Point(23, 161);
            this.endL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endL.Name = "endL";
            this.endL.Size = new System.Drawing.Size(60, 15);
            this.endL.TabIndex = 60;
            this.endL.Text = "End Time";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(264, 85);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(28, 15);
            this.label.TabIndex = 62;
            this.label.Text = "Fun";
            // 
            // labelL
            // 
            this.labelL.AutoSize = true;
            this.labelL.BackColor = System.Drawing.Color.Transparent;
            this.labelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelL.ForeColor = System.Drawing.Color.Black;
            this.labelL.Location = new System.Drawing.Point(183, 85);
            this.labelL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelL.Name = "labelL";
            this.labelL.Size = new System.Drawing.Size(38, 15);
            this.labelL.TabIndex = 61;
            this.labelL.Text = "Label";
            // 
            // taskPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelL);
            this.Controls.Add(this.endL);
            this.Controls.Add(this.startL);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.priorityL);
            this.Controls.Add(this.statusL);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.descriptionL);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Name = "taskPanel";
            this.Size = new System.Drawing.Size(356, 244);
            this.Load += new System.EventHandler(this.taskPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button editButton;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Button completeButton;
        public System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionL;
        public System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label statusL;
        private System.Windows.Forms.Label priorityL;
        public System.Windows.Forms.Label priorityLabel;
        public System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label startL;
        private System.Windows.Forms.Label endL;
        public System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelL;
    }
}
