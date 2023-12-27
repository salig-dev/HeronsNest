namespace HeronsNest.Components.Modal
{
    partial class SuccessModal
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
            pictureBox1 = new PictureBox();
            proceedButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(68, 28);
            label1.Name = "label1";
            label1.Size = new Size(228, 37);
            label1.TabIndex = 0;
            label1.Text = "Process Complete";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.success_icon;
            pictureBox1.Location = new Point(80, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.FromArgb(0, 149, 168);
            proceedButton.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);
            proceedButton.ForeColor = Color.White;
            proceedButton.Location = new Point(103, 340);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(149, 43);
            proceedButton.TabIndex = 2;
            proceedButton.Text = "CONTINUE";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += OnModalClose;
            // 
            // SuccessModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(proceedButton);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "SuccessModal";
            Size = new Size(360, 420);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button proceedButton;
    }
}
