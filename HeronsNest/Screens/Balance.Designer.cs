namespace HeronsNest.Screens
{
    partial class Balance
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // leftNavBar1
            // 
            leftNavBar1.AutoSize = true;
            leftNavBar1.BackColor = Color.White;
            leftNavBar1.Location = new Point(0, 0);
            leftNavBar1.MainForm = null;
            leftNavBar1.Name = "leftNavBar1";
            leftNavBar1.Size = new Size(200, 600);
            leftNavBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PP Hatton", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 156);
            label1.Name = "label1";
            label1.Size = new Size(284, 32);
            label1.TabIndex = 1;
            label1.Text = "Pending Payments";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Red;
            pictureBox1.Location = new Point(200, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 150);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Location = new Point(200, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 441);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.Location = new Point(972, 159);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 441);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Red;
            pictureBox4.Location = new Point(200, 191);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(800, 20);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(leftNavBar1);
            Name = "Balance";
            Size = new Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.LeftNavBar leftNavBar1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
