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
            pictureBox1 = new PictureBox();
            proceedButton = new Button();
            processCompleteText = new Label();
            successDesc = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.success_icon;
            pictureBox1.Location = new Point(81, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // proceedButton
            // 
            proceedButton.BackColor = Color.FromArgb(0, 149, 168);
            proceedButton.FlatAppearance.BorderSize = 0;
            proceedButton.FlatStyle = FlatStyle.Flat;
            proceedButton.Font = new Font("PP Hatton", 10F);
            proceedButton.ForeColor = Color.White;
            proceedButton.Location = new Point(106, 345);
            proceedButton.Name = "proceedButton";
            proceedButton.Size = new Size(148, 40);
            proceedButton.TabIndex = 2;
            proceedButton.Text = "CONTINUE";
            proceedButton.UseVisualStyleBackColor = false;
            proceedButton.Click += OnModalClose;
            // 
            // processCompleteText
            // 
            processCompleteText.BackColor = Color.FromArgb(244, 244, 244);
            processCompleteText.Font = new Font("PP Hatton", 16F);
            processCompleteText.ForeColor = Color.FromArgb(0, 149, 168);
            processCompleteText.Location = new Point(0, 33);
            processCompleteText.Name = "processCompleteText";
            processCompleteText.Size = new Size(360, 30);
            processCompleteText.TabIndex = 9;
            processCompleteText.Text = "Process Completed!";
            processCompleteText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // successDesc
            // 
            successDesc.Font = new Font("PP Hatton", 9F);
            successDesc.ForeColor = Color.FromArgb(82, 167, 133);
            successDesc.Location = new Point(32, 292);
            successDesc.Name = "successDesc";
            successDesc.Size = new Size(296, 50);
            successDesc.TabIndex = 10;
            successDesc.Text = "The process you performed successfully ran!";
            successDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SuccessModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(successDesc);
            Controls.Add(proceedButton);
            Controls.Add(pictureBox1);
            Controls.Add(processCompleteText);
            Name = "SuccessModal";
            Size = new Size(360, 420);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button proceedButton;
        private Label processCompleteText;
        private Label successDesc;
    }
}
