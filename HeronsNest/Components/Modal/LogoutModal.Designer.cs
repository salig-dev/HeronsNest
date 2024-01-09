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
            label1 = new Label();
            logout_No = new Button();
            logout_Yes = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 90);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to logout?";
            // 
            // logout_No
            // 
            logout_No.Location = new Point(141, 254);
            logout_No.Name = "logout_No";
            logout_No.Size = new Size(75, 23);
            logout_No.TabIndex = 1;
            logout_No.Text = "No";
            logout_No.UseVisualStyleBackColor = true;
            // 
            // logout_Yes
            // 
            logout_Yes.Location = new Point(141, 206);
            logout_Yes.Name = "logout_Yes";
            logout_Yes.Size = new Size(75, 23);
            logout_Yes.TabIndex = 2;
            logout_Yes.Text = "Yes";
            logout_Yes.UseVisualStyleBackColor = true;
            // 
            // LogoutWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(logout_Yes);
            Controls.Add(logout_No);
            Controls.Add(label1);
            Name = "LogoutWindow";
            Size = new Size(360, 420);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button logout_No;
        private Button logout_Yes;
    }
}
