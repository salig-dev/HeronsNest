namespace HeronsNest.Components.Modal
{
    partial class ModalControl
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
            modalBackground = new PictureBox();
            modalPlaceholder = new Panel();
            ((System.ComponentModel.ISupportInitialize)modalBackground).BeginInit();
            SuspendLayout();
            // 
            // modalBackground
            // 
            modalBackground.Dock = DockStyle.Fill;
            modalBackground.Image = Properties.Resources.hero_bg_dark;
            modalBackground.Location = new Point(0, 0);
            modalBackground.Name = "modalBackground";
            modalBackground.Size = new Size(1000, 600);
            modalBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            modalBackground.TabIndex = 0;
            modalBackground.TabStop = false;
            // 
            // modalPlaceholder
            // 
            modalPlaceholder.Location = new Point(333, 88);
            modalPlaceholder.Name = "modalPlaceholder";
            modalPlaceholder.Size = new Size(360, 420);
            modalPlaceholder.TabIndex = 1;
            // 
            // ModalControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(modalPlaceholder);
            Controls.Add(modalBackground);
            Name = "ModalControl";
            Size = new Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)modalBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox modalBackground;
        private Panel modalPlaceholder;
    }
}
