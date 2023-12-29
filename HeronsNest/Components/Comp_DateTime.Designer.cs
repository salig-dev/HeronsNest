namespace HeronsNest.Components
{
    partial class Comp_DateTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comp_DateTime));
            timeFrame = new Panel();
            dateText = new Label();
            icon_Calendar = new PictureBox();
            timeText = new Label();
            icon_Clock = new PictureBox();
            timeFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon_Calendar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_Clock).BeginInit();
            SuspendLayout();
            // 
            // timeFrame
            // 
            timeFrame.BackColor = Color.Transparent;
            timeFrame.BackgroundImage = (Image)resources.GetObject("timeFrame.BackgroundImage");
            timeFrame.Controls.Add(dateText);
            timeFrame.Controls.Add(icon_Calendar);
            timeFrame.Controls.Add(timeText);
            timeFrame.Controls.Add(icon_Clock);
            timeFrame.Location = new Point(4, 4);
            timeFrame.MaximumSize = new Size(300, 48);
            timeFrame.Name = "timeFrame";
            timeFrame.Size = new Size(241, 35);
            timeFrame.TabIndex = 6;
            // 
            // dateText
            // 
            dateText.AutoSize = true;
            dateText.BackColor = Color.Transparent;
            dateText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateText.Location = new Point(137, 13);
            dateText.Name = "dateText";
            dateText.Size = new Size(80, 15);
            dateText.TabIndex = 3;
            dateText.Text = "27 - 11 - 2023";
            dateText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_Calendar
            // 
            icon_Calendar.BackgroundImageLayout = ImageLayout.None;
            icon_Calendar.Image = (Image)resources.GetObject("icon_Calendar.Image");
            icon_Calendar.Location = new Point(111, 10);
            icon_Calendar.Name = "icon_Calendar";
            icon_Calendar.Size = new Size(26, 20);
            icon_Calendar.TabIndex = 2;
            icon_Calendar.TabStop = false;
            // 
            // timeText
            // 
            timeText.AutoSize = true;
            timeText.BackColor = Color.Transparent;
            timeText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeText.Location = new Point(50, 12);
            timeText.Name = "timeText";
            timeText.Size = new Size(38, 15);
            timeText.TabIndex = 1;
            timeText.Text = "00:00";
            timeText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // icon_Clock
            // 
            icon_Clock.BackgroundImageLayout = ImageLayout.None;
            icon_Clock.Image = (Image)resources.GetObject("icon_Clock.Image");
            icon_Clock.Location = new Point(27, 10);
            icon_Clock.Name = "icon_Clock";
            icon_Clock.Size = new Size(20, 20);
            icon_Clock.TabIndex = 0;
            icon_Clock.TabStop = false;
            // 
            // Comp_DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeFrame);
            Name = "Comp_DateTime";
            Size = new Size(249, 44);
            timeFrame.ResumeLayout(false);
            timeFrame.PerformLayout();
            Load += Comp_DataTime_Load;
            ((System.ComponentModel.ISupportInitialize)icon_Calendar).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_Clock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel timeFrame;
        private Label dateText;
        private Label timeText;
        private PictureBox icon_Calendar;
        private PictureBox icon_Clock;
    }
}
