namespace pomodist
{
    partial class SignupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPage));
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noAccountLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnTextBox = new System.Windows.Forms.TextBox();
            this.fnTextBox = new System.Windows.Forms.TextBox();
            this.signupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginPageBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.emailTextBox.Location = new System.Drawing.Point(43, 125);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(170, 22);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "Enter Username";
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.passwordTextBox.Location = new System.Drawing.Point(43, 160);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(170, 22);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckBox.Location = new System.Drawing.Point(44, 186);
            this.showPasswordCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(107, 17);
            this.showPasswordCheckBox.TabIndex = 8;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // noAccountLabel
            // 
            this.noAccountLabel.AutoSize = true;
            this.noAccountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.noAccountLabel.Location = new System.Drawing.Point(65, 262);
            this.noAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noAccountLabel.Name = "noAccountLabel";
            this.noAccountLabel.Size = new System.Drawing.Size(137, 13);
            this.noAccountLabel.TabIndex = 26;
            this.noAccountLabel.Text = "Already have an account?";
            this.noAccountLabel.Click += new System.EventHandler(this.noAccountLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(301, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 372);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lnTextBox
            // 
            this.lnTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lnTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lnTextBox.Location = new System.Drawing.Point(134, 91);
            this.lnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lnTextBox.Name = "lnTextBox";
            this.lnTextBox.Size = new System.Drawing.Size(79, 22);
            this.lnTextBox.TabIndex = 7;
            this.lnTextBox.Text = "Last Name";
            // 
            // fnTextBox
            // 
            this.fnTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fnTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.fnTextBox.Location = new System.Drawing.Point(43, 91);
            this.fnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(79, 22);
            this.fnTextBox.TabIndex = 6;
            this.fnTextBox.Text = "First Name";
            // 
            // signupBtn
            // 
            this.signupBtn.BorderRadius = 8;
            this.signupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signupBtn.FillColor = System.Drawing.Color.BurlyWood;
            this.signupBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(47, 213);
            this.signupBtn.Margin = new System.Windows.Forms.Padding(2);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(166, 37);
            this.signupBtn.TabIndex = 29;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // loginPageBtn
            // 
            this.loginPageBtn.BorderColor = System.Drawing.Color.BurlyWood;
            this.loginPageBtn.BorderRadius = 8;
            this.loginPageBtn.BorderThickness = 1;
            this.loginPageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginPageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginPageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginPageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginPageBtn.FillColor = System.Drawing.Color.White;
            this.loginPageBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loginPageBtn.ForeColor = System.Drawing.Color.Black;
            this.loginPageBtn.Location = new System.Drawing.Point(47, 277);
            this.loginPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginPageBtn.Name = "loginPageBtn";
            this.loginPageBtn.Size = new System.Drawing.Size(169, 32);
            this.loginPageBtn.TabIndex = 32;
            this.loginPageBtn.Text = "Login";
            this.loginPageBtn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // SignupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(688, 376);
            this.Controls.Add(this.loginPageBtn);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.noAccountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.lnTextBox);
            this.Controls.Add(this.fnTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignupPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.SignupPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noAccountLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lnTextBox;
        private System.Windows.Forms.TextBox fnTextBox;
        private Guna.UI2.WinForms.Guna2Button signupBtn;
        private Guna.UI2.WinForms.Guna2Button loginPageBtn;
    }
}

