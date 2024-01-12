namespace HeronsNest.Screens
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            backBtn = new PictureBox();
            saligAbout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saligAbout).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(113, 60);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(31, 27);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 32;
            backBtn.TabStop = false;
            // 
            // saligAbout
            // 
            saligAbout.Image = (Image)resources.GetObject("saligAbout.Image");
            saligAbout.Location = new Point(0, -27);
            saligAbout.Name = "saligAbout";
            saligAbout.Size = new Size(1050, 620);
            saligAbout.TabIndex = 33;
            saligAbout.TabStop = false;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backBtn);
            Controls.Add(saligAbout);
            Name = "AboutUs";
            Size = new Size(1050, 575);
            Load += AboutUs_Load;
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)saligAbout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backBtn;
        private PictureBox pictureBox1;
        private PictureBox saligAbout;
    }
}
