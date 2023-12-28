namespace HeronsNest.Components.Modal
{
    partial class ReserveBook
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
            returnButtonreserve = new Label();
            reserveDetails = new Label();
            fromReserve = new Label();
            FromMonthReserve = new ComboBox();
            FromDayReserve = new ComboBox();
            FromYearReserve = new ComboBox();
            toReserve = new Label();
            ToMonthReserve = new ComboBox();
            ToDayReserve = new ComboBox();
            ToYearReserve = new ComboBox();
            serialReserve = new Label();
            textBox1 = new TextBox();
            verificationReserve = new Label();
            bookReserve = new Button();
            SuspendLayout();
            // 
            // returnButtonreserve
            // 
            returnButtonreserve.AutoSize = true;
            returnButtonreserve.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnButtonreserve.Location = new Point(41, 25);
            returnButtonreserve.Name = "returnButtonreserve";
            returnButtonreserve.Size = new Size(27, 21);
            returnButtonreserve.TabIndex = 2;
            returnButtonreserve.Text = "<-";
            returnButtonreserve.Click += this.returnButtonborrow_Click;
            // 
            // reserveDetails
            // 
            reserveDetails.AutoSize = true;
            reserveDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reserveDetails.Location = new Point(159, 25);
            reserveDetails.Name = "reserveDetails";
            reserveDetails.Size = new Size(116, 21);
            reserveDetails.TabIndex = 1;
            reserveDetails.Text = "Fill Up Details";
            // 
            // fromReserve
            // 
            fromReserve.AutoSize = true;
            fromReserve.Location = new Point(63, 77);
            fromReserve.Name = "fromReserve";
            fromReserve.Size = new Size(35, 15);
            fromReserve.TabIndex = 4;
            fromReserve.Text = "From";
            fromReserve.Click += this.fromBorrow_Click;
            // 
            // FromMonthReserve
            // 
            FromMonthReserve.FormattingEnabled = true;
            FromMonthReserve.Location = new Point(63, 104);
            FromMonthReserve.Name = "FromMonthReserve";
            FromMonthReserve.Size = new Size(66, 23);
            FromMonthReserve.TabIndex = 3;
            FromMonthReserve.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // FromDayReserve
            // 
            FromDayReserve.FormattingEnabled = true;
            FromDayReserve.Location = new Point(159, 104);
            FromDayReserve.Name = "FromDayReserve";
            FromDayReserve.Size = new Size(66, 23);
            FromDayReserve.TabIndex = 3;
            FromDayReserve.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // FromYearReserve
            // 
            FromYearReserve.FormattingEnabled = true;
            FromYearReserve.Location = new Point(254, 104);
            FromYearReserve.Name = "FromYearReserve";
            FromYearReserve.Size = new Size(97, 23);
            FromYearReserve.TabIndex = 3;
            FromYearReserve.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // toReserve
            // 
            toReserve.AutoSize = true;
            toReserve.Location = new Point(63, 147);
            toReserve.Name = "toReserve";
            toReserve.Size = new Size(19, 15);
            toReserve.TabIndex = 4;
            toReserve.Text = "To";
            // 
            // ToMonthReserve
            // 
            ToMonthReserve.FormattingEnabled = true;
            ToMonthReserve.Location = new Point(63, 176);
            ToMonthReserve.Name = "ToMonthReserve";
            ToMonthReserve.Size = new Size(66, 23);
            ToMonthReserve.TabIndex = 3;
            ToMonthReserve.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // ToDayReserve
            // 
            ToDayReserve.FormattingEnabled = true;
            ToDayReserve.Location = new Point(159, 176);
            ToDayReserve.Name = "ToDayReserve";
            ToDayReserve.Size = new Size(66, 23);
            ToDayReserve.TabIndex = 3;
            ToDayReserve.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // ToYearReserve
            // 
            ToYearReserve.FormattingEnabled = true;
            ToYearReserve.Location = new Point(254, 176);
            ToYearReserve.Name = "ToYearReserve";
            ToYearReserve.Size = new Size(97, 23);
            ToYearReserve.TabIndex = 3;
            ToYearReserve.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // serialReserve
            // 
            serialReserve.AutoSize = true;
            serialReserve.Location = new Point(63, 217);
            serialReserve.Name = "serialReserve";
            serialReserve.Size = new Size(87, 15);
            serialReserve.TabIndex = 4;
            serialReserve.Text = "Book Serial No.";
            serialReserve.Click += this.serialBorrow_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 235);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 20);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // verificationReserve
            // 
            verificationReserve.AutoSize = true;
            verificationReserve.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verificationReserve.Location = new Point(63, 258);
            verificationReserve.Name = "verificationReserve";
            verificationReserve.Size = new Size(85, 13);
            verificationReserve.TabIndex = 4;
            verificationReserve.Text = "For Verification";
            verificationReserve.Click += this.verificationBorrow_Click;
            // 
            // bookReserve
            // 
            bookReserve.Location = new Point(153, 293);
            bookReserve.Name = "bookReserve";
            bookReserve.Size = new Size(122, 34);
            bookReserve.TabIndex = 0;
            bookReserve.Text = "Reserve";
            bookReserve.UseVisualStyleBackColor = true;
            // 
            // ReserveBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(verificationReserve);
            Controls.Add(returnButtonreserve);
            Controls.Add(reserveDetails);
            Controls.Add(serialReserve);
            Controls.Add(fromReserve);
            Controls.Add(toReserve);
            Controls.Add(FromDayReserve);
            Controls.Add(FromMonthReserve);
            Controls.Add(FromYearReserve);
            Controls.Add(ToYearReserve);
            Controls.Add(ToMonthReserve);
            Controls.Add(ToDayReserve);
            Controls.Add(bookReserve);
            Name = "ReserveBook";
            Size = new Size(420, 360);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label returnButtonreserve;
        private Label reserveDetails;
        private Label fromReserve;
        private ComboBox FromMonthReserve;
        private ComboBox FromDayReserve;
        private ComboBox FromYearReserve;
        private Label toReserve;
        private ComboBox ToMonthReserve;
        private ComboBox ToDayReserve;
        private ComboBox ToYearReserve;
        private Label serialReserve;
        private TextBox textBox1;
        private Label verificationReserve;
        private Button bookReserve;
    }
}
