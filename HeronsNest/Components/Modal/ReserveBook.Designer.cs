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
            bookReserve = new Button();
            Note = new Label();
            To = new Label();
            DateReserve = new DateTimePicker();
            toRerserve = new DateTimePicker();
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
            // 
            // reserveDetails
            // 
            reserveDetails.AutoSize = true;
            reserveDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reserveDetails.Location = new Point(129, 25);
            reserveDetails.Name = "reserveDetails";
            reserveDetails.Size = new Size(116, 21);
            reserveDetails.TabIndex = 1;
            reserveDetails.Text = "Fill Up Details";
            // 
            // fromReserve
            // 
            fromReserve.AutoSize = true;
            fromReserve.Location = new Point(41, 77);
            fromReserve.Name = "fromReserve";
            fromReserve.Size = new Size(35, 15);
            fromReserve.TabIndex = 4;
            fromReserve.Text = "From";
            // 
            // bookReserve
            // 
            bookReserve.Location = new Point(120, 258);
            bookReserve.Name = "bookReserve";
            bookReserve.Size = new Size(122, 34);
            bookReserve.TabIndex = 0;
            bookReserve.Text = "Reserve";
            bookReserve.UseVisualStyleBackColor = true;
            // 
            // Note
            // 
            Note.AutoSize = true;
            Note.Font = new Font("Segoe UI", 7F);
            Note.Location = new Point(47, 203);
            Note.Name = "Note";
            Note.Size = new Size(118, 12);
            Note.TabIndex = 6;
            Note.Text = "Note: 20 php per day due";
            // 
            // To
            // 
            To.AutoSize = true;
            To.Location = new Point(44, 148);
            To.Name = "To";
            To.Size = new Size(19, 15);
            To.TabIndex = 7;
            To.Text = "To";
            // 
            // DateReserve
            // 
            DateReserve.Location = new Point(44, 99);
            DateReserve.Name = "DateReserve";
            DateReserve.Size = new Size(245, 23);
            DateReserve.TabIndex = 5;
            // 
            // toRerserve
            // 
            toRerserve.Location = new Point(44, 168);
            toRerserve.Name = "toRerserve";
            toRerserve.Size = new Size(245, 23);
            toRerserve.TabIndex = 8;
            // 
            // ReserveBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(toRerserve);
            Controls.Add(To);
            Controls.Add(Note);
            Controls.Add(DateReserve);
            Controls.Add(returnButtonreserve);
            Controls.Add(reserveDetails);
            Controls.Add(fromReserve);
            Controls.Add(bookReserve);
            Name = "ReserveBook";
            Size = new Size(360, 420);
            Load += ReserveBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label returnButtonreserve;
        private Label reserveDetails;
        private Label fromReserve;
        private Label toReserve;
        private Button bookReserve;
        private Label Note;
        private Label To;
        private DateTimePicker DateReserve;
        private DateTimePicker toRerserve;
        private DateTimePicker dateTimePicker2;
    }
}
