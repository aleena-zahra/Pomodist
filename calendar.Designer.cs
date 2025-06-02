namespace pomodist
{
    partial class calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calendar));
            this.nextButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.prevButton = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.saturday = new Guna.UI2.WinForms.Guna2TextBox();
            this.sunday = new Guna.UI2.WinForms.Guna2TextBox();
            this.tuesday = new Guna.UI2.WinForms.Guna2TextBox();
            this.thursday = new Guna.UI2.WinForms.Guna2TextBox();
            this.friday = new Guna.UI2.WinForms.Guna2TextBox();
            this.monday = new Guna.UI2.WinForms.Guna2TextBox();
            this.wednesday = new Guna.UI2.WinForms.Guna2TextBox();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nextButton.CheckedState.BorderThickness = 0;
            this.nextButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nextButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(52, 28);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(31, 36);
            this.nextButton.TabIndex = 26;
            this.nextButton.Text = "guna2CustomRadioButton2";
            this.nextButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nextButton.UncheckedState.BorderThickness = 2;
            this.nextButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.nextButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.nextButton.CheckedChanged += new System.EventHandler(this.nextButton_CheckedChanged);
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.Transparent;
            this.prevButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevButton.BackgroundImage")));
            this.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevButton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prevButton.CheckedState.BorderThickness = 0;
            this.prevButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prevButton.CheckedState.InnerColor = System.Drawing.Color.White;
            this.prevButton.Location = new System.Drawing.Point(17, 28);
            this.prevButton.Margin = new System.Windows.Forms.Padding(2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(31, 36);
            this.prevButton.TabIndex = 25;
            this.prevButton.Text = "guna2CustomRadioButton4";
            this.prevButton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.prevButton.UncheckedState.BorderThickness = 2;
            this.prevButton.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.prevButton.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.prevButton.CheckedChanged += new System.EventHandler(this.prevButton_CheckedChanged);
            // 
            // saturday
            // 
            this.saturday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saturday.DefaultText = "Saturday";
            this.saturday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.saturday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.saturday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saturday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.saturday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saturday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saturday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.saturday.Location = new System.Drawing.Point(682, 25);
            this.saturday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saturday.Name = "saturday";
            this.saturday.PlaceholderText = "";
            this.saturday.SelectedText = "";
            this.saturday.Size = new System.Drawing.Size(75, 34);
            this.saturday.TabIndex = 22;
            // 
            // sunday
            // 
            this.sunday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sunday.DefaultText = "Sunday";
            this.sunday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sunday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sunday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sunday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sunday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sunday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sunday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sunday.Location = new System.Drawing.Point(799, 25);
            this.sunday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sunday.Name = "sunday";
            this.sunday.PlaceholderText = "";
            this.sunday.SelectedText = "";
            this.sunday.Size = new System.Drawing.Size(75, 34);
            this.sunday.TabIndex = 21;
            // 
            // tuesday
            // 
            this.tuesday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tuesday.DefaultText = "Tuesday";
            this.tuesday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tuesday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tuesday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tuesday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tuesday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tuesday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tuesday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tuesday.Location = new System.Drawing.Point(213, 25);
            this.tuesday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tuesday.Name = "tuesday";
            this.tuesday.PlaceholderText = "";
            this.tuesday.SelectedText = "";
            this.tuesday.Size = new System.Drawing.Size(75, 34);
            this.tuesday.TabIndex = 20;
            // 
            // thursday
            // 
            this.thursday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thursday.DefaultText = "Thursday";
            this.thursday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thursday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thursday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thursday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thursday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thursday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thursday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thursday.Location = new System.Drawing.Point(447, 25);
            this.thursday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thursday.Name = "thursday";
            this.thursday.PlaceholderText = "";
            this.thursday.SelectedText = "";
            this.thursday.Size = new System.Drawing.Size(75, 34);
            this.thursday.TabIndex = 18;
            // 
            // friday
            // 
            this.friday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.friday.DefaultText = "Friday";
            this.friday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.friday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.friday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.friday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.friday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.friday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.friday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.friday.Location = new System.Drawing.Point(570, 25);
            this.friday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friday.Name = "friday";
            this.friday.PlaceholderText = "";
            this.friday.SelectedText = "";
            this.friday.Size = new System.Drawing.Size(75, 34);
            this.friday.TabIndex = 17;
            // 
            // monday
            // 
            this.monday.BackColor = System.Drawing.Color.Transparent;
            this.monday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.monday.DefaultText = "Monday";
            this.monday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.monday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.monday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.monday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.monday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.monday.Location = new System.Drawing.Point(108, 28);
            this.monday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monday.Name = "monday";
            this.monday.PlaceholderText = "";
            this.monday.SelectedText = "";
            this.monday.Size = new System.Drawing.Size(75, 34);
            this.monday.TabIndex = 27;
            this.monday.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // wednesday
            // 
            this.wednesday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wednesday.DefaultText = "Wednesday";
            this.wednesday.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.wednesday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.wednesday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.wednesday.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.wednesday.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wednesday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wednesday.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.wednesday.Location = new System.Drawing.Point(326, 25);
            this.wednesday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wednesday.Name = "wednesday";
            this.wednesday.PlaceholderText = "";
            this.wednesday.SelectedText = "";
            this.wednesday.Size = new System.Drawing.Size(83, 34);
            this.wednesday.TabIndex = 28;
            // 
            // dayContainer
            // 
            this.dayContainer.BackColor = System.Drawing.Color.Transparent;
            this.dayContainer.Location = new System.Drawing.Point(83, 67);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(821, 398);
            this.dayContainer.TabIndex = 29;
            this.dayContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.dayContainer_Paint);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.monthLabel.ForeColor = System.Drawing.Color.White;
            this.monthLabel.Location = new System.Drawing.Point(104, 2);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(59, 21);
            this.monthLabel.TabIndex = 25;
            this.monthLabel.Text = "Month";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.BackColor = System.Drawing.Color.Transparent;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.yearLabel.ForeColor = System.Drawing.Color.White;
            this.yearLabel.Location = new System.Drawing.Point(200, 2);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(41, 21);
            this.yearLabel.TabIndex = 30;
            this.yearLabel.Text = "Year";
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayContainer);
            this.Controls.Add(this.wednesday);
            this.Controls.Add(this.monday);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.sunday);
            this.Controls.Add(this.tuesday);
            this.Controls.Add(this.thursday);
            this.Controls.Add(this.friday);
            this.DoubleBuffered = true;
            this.Name = "calendar";
            this.Size = new System.Drawing.Size(930, 468);
            this.Load += new System.EventHandler(this.calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomRadioButton nextButton;
        private Guna.UI2.WinForms.Guna2CustomRadioButton prevButton;
        private Guna.UI2.WinForms.Guna2TextBox saturday;
        private Guna.UI2.WinForms.Guna2TextBox sunday;
        private Guna.UI2.WinForms.Guna2TextBox tuesday;
        private Guna.UI2.WinForms.Guna2TextBox thursday;
        private Guna.UI2.WinForms.Guna2TextBox friday;
        private Guna.UI2.WinForms.Guna2TextBox monday;
        private Guna.UI2.WinForms.Guna2TextBox wednesday;
        private System.Windows.Forms.FlowLayoutPanel dayContainer;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
    }
}
