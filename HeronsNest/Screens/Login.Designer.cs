namespace HeronsNest.Screens
{
    partial class Login
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            tipTextLabel = new Label();
            loginFormBackground = new PictureBox();
            pictureBox1 = new PictureBox();
            loginBackground = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginFormBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginBackground).BeginInit();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Nourd-Regular", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.Location = new Point(583, 310);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(360, 20);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Nourd-Regular", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(583, 350);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(360, 20);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(82, 167, 133);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("PP Hatton", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(583, 395);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(360, 35);
            loginButton.TabIndex = 4;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += OnUserLogin;
            // 
            // tipTextLabel
            // 
            tipTextLabel.BackColor = Color.FromArgb(246, 246, 246);
            tipTextLabel.Font = new Font("Nourd-Regular", 12F);
            tipTextLabel.Location = new Point(583, 449);
            tipTextLabel.Name = "tipTextLabel";
            tipTextLabel.Size = new Size(360, 23);
            tipTextLabel.TabIndex = 5;
            tipTextLabel.Text = " ";
            tipTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginFormBackground
            // 
            loginFormBackground.BackColor = Color.FromArgb(246, 246, 246);
            loginFormBackground.Location = new Point(510, 0);
            loginFormBackground.Name = "loginFormBackground";
            loginFormBackground.Size = new Size(490, 600);
            loginFormBackground.TabIndex = 6;
            loginFormBackground.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_header;
            pictureBox1.Location = new Point(583, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginBackground
            // 
            loginBackground.Image = Properties.Resources.hero_bg_dark;
            loginBackground.Location = new Point(0, 0);
            loginBackground.Name = "loginBackground";
            loginBackground.Size = new Size(1000, 600);
            loginBackground.SizeMode = PictureBoxSizeMode.AutoSize;
            loginBackground.TabIndex = 8;
            loginBackground.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(tipTextLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(loginFormBackground);
            Controls.Add(loginBackground);
            Name = "Login";
            Size = new Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)loginFormBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginBackground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label tipTextLabel;
        private PictureBox loginFormBackground;
        private PictureBox pictureBox1;
        private PictureBox loginBackground;
    }
}
