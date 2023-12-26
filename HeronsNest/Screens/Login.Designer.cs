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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.WindowFrame;
            button1.Location = new Point(463, 384);
            button1.Name = "button1";
            button1.Size = new Size(217, 23);
            button1.TabIndex = 1;
            button1.Text = "Switch to Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sideNavigation1
            // 
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "Login";
            Size = new Size(1000, 600);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
    }
}
