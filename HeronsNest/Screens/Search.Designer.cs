namespace HeronsNest.Screens
{
    partial class Search
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
            leftNavBar1 = new Components.LeftNavBar();
            SuspendLayout();
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(194, 600);
            leftNavBar1.TabIndex = 0;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(leftNavBar1);
            Name = "Search";
            Size = new Size(1000, 600);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.LeftNavBar leftNavBar1;
    }
}
