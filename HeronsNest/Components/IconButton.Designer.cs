namespace HeronsNest.Components
{
    partial class IconButton
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
            iconHolder = new PictureBox();
            buttonTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)iconHolder).BeginInit();
            SuspendLayout();
            // 
            // iconHolder
            // 
            iconHolder.Location = new Point(18, 10);
            iconHolder.Name = "iconHolder";
            iconHolder.Size = new Size(15, 15);
            iconHolder.SizeMode = PictureBoxSizeMode.StretchImage;
            iconHolder.TabIndex = 0;
            iconHolder.TabStop = false;
            // 
            // buttonTitle
            // 
            buttonTitle.AutoSize = true;
            buttonTitle.Font = new Font("Segoe UI", 8F);
            buttonTitle.Location = new Point(55, 12);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(65, 13);
            buttonTitle.TabIndex = 1;
            buttonTitle.Text = "Button Text";
            buttonTitle.TextAlign = ContentAlignment.MiddleCenter;
            buttonTitle.Click += label1_Click;
            // 
            // IconButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(buttonTitle);
            Controls.Add(iconHolder);
            Cursor = Cursors.Hand;
            Name = "IconButton";
            Size = new Size(167, 40);
            ((System.ComponentModel.ISupportInitialize)iconHolder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iconHolder;
        private Label buttonTitle;
    }
}
