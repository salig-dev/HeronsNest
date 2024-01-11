namespace HeronsNest.Components.Modal
{
    partial class LogoutWindow
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
            confirmText = new Label();
            logout_No = new Button();
            logout_Yes = new Button();
            SuspendLayout();
            // 
            // confirmText
            // 
            confirmText.Font = new Font("PP Hatton", 16F);
            confirmText.ForeColor = Color.FromArgb(76, 76, 76);
            confirmText.Location = new Point(30, 103);
            confirmText.Name = "confirmText";
            confirmText.Size = new Size(300, 122);
            confirmText.TabIndex = 0;
            confirmText.Text = "Are you sure you want to logout?";
            confirmText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logout_No
            // 
            logout_No.BackColor = Color.FromArgb(82, 167, 133);
            logout_No.FlatAppearance.BorderSize = 0;
            logout_No.FlatStyle = FlatStyle.Flat;
            logout_No.Font = new Font("PP Hatton", 12F);
            logout_No.ForeColor = Color.White;
            logout_No.Location = new Point(30, 274);
            logout_No.Name = "logout_No";
            logout_No.Size = new Size(300, 40);
            logout_No.TabIndex = 1;
            logout_No.Text = "NO";
            logout_No.UseVisualStyleBackColor = false;
            logout_No.Click += logout_No_Click;
            // 
            // logout_Yes
            // 
            logout_Yes.BackColor = Color.FromArgb(0, 149, 168);
            logout_Yes.FlatAppearance.BorderSize = 0;
            logout_Yes.FlatStyle = FlatStyle.Flat;
            logout_Yes.Font = new Font("PP Hatton", 12F);
            logout_Yes.ForeColor = Color.White;
            logout_Yes.Location = new Point(30, 228);
            logout_Yes.Name = "logout_Yes";
            logout_Yes.Size = new Size(300, 40);
            logout_Yes.TabIndex = 2;
            logout_Yes.Text = "YES";
            logout_Yes.UseVisualStyleBackColor = false;
            logout_Yes.Click += logout_Yes_Click;
            // 
            // LogoutWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logout_Yes);
            Controls.Add(logout_No);
            Controls.Add(confirmText);
            Name = "LogoutWindow";
            Size = new Size(360, 420);
            ResumeLayout(false);
        }

        #endregion

        private Label confirmText;
        private Button logout_No;
        private Button logout_Yes;
    }
}
