namespace HeronsNest.Screens
{
    partial class MyShelf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyShelf));
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            shelfCard = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            pictureBox19 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox24 = new PictureBox();
            label10 = new Label();
            button6 = new Button();
            button7 = new Button();
            label11 = new Label();
            label12 = new Label();
            pictureBox25 = new PictureBox();
            label13 = new Label();
            button8 = new Button();
            button9 = new Button();
            sideNavigation1 = new Components.Navigation.SideNavigation();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shelfCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(259, 57);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("PP Hatton", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 149, 168);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(248, 116);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(174, 40);
            label2.TabIndex = 2;
            label2.Text = "My Shelf";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("PP Hatton", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(248, 179);
            label1.Name = "label1";
            label1.Size = new Size(115, 24);
            label1.TabIndex = 3;
            label1.Text = "All Books";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("PP Hatton", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(369, 179);
            label3.Name = "label3";
            label3.Size = new Size(181, 24);
            label3.TabIndex = 4;
            label3.Text = "Pending Books";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("PP Hatton", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(556, 179);
            label4.Name = "label4";
            label4.Size = new Size(200, 24);
            label4.TabIndex = 5;
            label4.Text = "Borrowed Books";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(0, 0, 15, 255);
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(732, 258);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(218, 258);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 17;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(0, 0, 15, 255);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(490, 258);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(218, 258);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // shelfCard
            // 
            shelfCard.BackColor = Color.FromArgb(0, 0, 15, 255);
            shelfCard.Image = (Image)resources.GetObject("shelfCard.Image");
            shelfCard.Location = new Point(248, 258);
            shelfCard.Name = "shelfCard";
            shelfCard.Size = new Size(218, 258);
            shelfCard.SizeMode = PictureBoxSizeMode.AutoSize;
            shelfCard.TabIndex = 15;
            shelfCard.TabStop = false;
            shelfCard.Click += pictureBox7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(82, 167, 91);
            button4.Font = new Font("PP Hatton Medium", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(246, 246, 246);
            button4.Location = new Point(353, 463);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 24;
            button4.Text = "Return";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 149, 168);
            button5.Font = new Font("PP Hatton Medium", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(246, 246, 246);
            button5.Location = new Point(259, 463);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 27;
            button5.Text = "Borrowed";
            button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(262, 266);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 29;
            label5.Text = "Book Title, Author Name";
            label5.Click += label5_Click;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = SystemColors.ControlDarkDark;
            pictureBox19.Location = new Point(259, 302);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(188, 125);
            pictureBox19.TabIndex = 30;
            pictureBox19.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(259, 430);
            label6.Name = "label6";
            label6.Size = new Size(140, 15);
            label6.TabIndex = 31;
            label6.Text = "Borrowed On: {DATE}";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(259, 445);
            label7.Name = "label7";
            label7.Size = new Size(154, 15);
            label7.TabIndex = 32;
            label7.Text = "Submission Due: {DATE}";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(501, 445);
            label8.Name = "label8";
            label8.Size = new Size(154, 15);
            label8.TabIndex = 42;
            label8.Text = "Submission Due: {DATE}";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(501, 430);
            label9.Name = "label9";
            label9.Size = new Size(140, 15);
            label9.TabIndex = 41;
            label9.Text = "Borrowed On: {DATE}";
            // 
            // pictureBox24
            // 
            pictureBox24.BackColor = SystemColors.ControlDarkDark;
            pictureBox24.Location = new Point(501, 302);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(188, 125);
            pictureBox24.TabIndex = 40;
            pictureBox24.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(501, 266);
            label10.Name = "label10";
            label10.Size = new Size(160, 15);
            label10.TabIndex = 39;
            label10.Text = "Book Title, Author Name";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 149, 168);
            button6.Font = new Font("PP Hatton Medium", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(246, 246, 246);
            button6.Location = new Point(501, 463);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 38;
            button6.Text = "Borrowed";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(82, 167, 91);
            button7.Font = new Font("PP Hatton Medium", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(246, 246, 246);
            button7.Location = new Point(595, 463);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 37;
            button7.Text = "Return";
            button7.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(743, 445);
            label11.Name = "label11";
            label11.Size = new Size(154, 15);
            label11.TabIndex = 48;
            label11.Text = "Submission Due: {DATE}";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(743, 430);
            label12.Name = "label12";
            label12.Size = new Size(140, 15);
            label12.TabIndex = 47;
            label12.Text = "Borrowed On: {DATE}";
            // 
            // pictureBox25
            // 
            pictureBox25.BackColor = SystemColors.ControlDarkDark;
            pictureBox25.Location = new Point(743, 302);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(188, 125);
            pictureBox25.TabIndex = 46;
            pictureBox25.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Nourd-SemiBold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(743, 266);
            label13.Name = "label13";
            label13.Size = new Size(160, 15);
            label13.TabIndex = 45;
            label13.Text = "Book Title, Author Name";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 149, 168);
            button8.Font = new Font("PP Hatton Medium", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(246, 246, 246);
            button8.Location = new Point(743, 463);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 44;
            button8.Text = "Borrowed";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(82, 167, 91);
            button9.Font = new Font("PP Hatton Medium", 7.79999971F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(246, 246, 246);
            button9.Location = new Point(837, 463);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 43;
            button9.Text = "Return";
            button9.UseVisualStyleBackColor = false;
            // 
            // sideNavigation1
            // 
            sideNavigation1.BackColor = Color.Transparent;
            sideNavigation1.Location = new Point(0, 0);
            sideNavigation1.Margin = new Padding(3, 5, 3, 5);
            sideNavigation1.Name = "sideNavigation1";
            sideNavigation1.Size = new Size(200, 800);
            sideNavigation1.TabIndex = 49;
            // 
            // MyShelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(243, 243, 247);
            Controls.Add(sideNavigation1);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(pictureBox25);
            Controls.Add(label13);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(pictureBox24);
            Controls.Add(label10);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox19);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(shelfCard);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "MyShelf";
            Size = new Size(1000, 600);
            Load += MyShelf_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)shelfCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox8;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox shelfCard;
        private Button button4;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private Button button5;
        private PictureBox pictureBox18;
        private Label label5;
        private PictureBox pictureBox19;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox24;
        private Label label10;
        private Button button6;
        private Button button7;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox25;
        private Label label13;
        private Button button8;
        private Button button9;
        private Components.Navigation.SideNavigation sideNavigation1;
    }
}
