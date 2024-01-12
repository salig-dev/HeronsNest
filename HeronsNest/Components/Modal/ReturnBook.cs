using HeronsNest.Models;
using HeronsNest.Screens;
using HeronsNest.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HeronsNest.Components.Modal
{
    public partial class ReturnBook : UserControl
    {
        Landing MainForm;
        BookBorrow BorrowDetails;
        int PayPenalty = 20;

        int DaysPassed = 0;
        public ReturnBook(Landing mainForm, BookBorrow borrow)
        {
            InitializeComponent();

            MainForm = mainForm;
            BorrowDetails = borrow;

            Dateborrow.Value = DateTime.Parse(borrow.DateBorrowed);
            DateReturn.Value = DateTime.Parse(borrow.DateDue);

            TimeSpan span = DateTime.Parse(borrow.DateDue) - DateTime.Parse(borrow.DateBorrowed);
            DaysPassed = span.Days;
            if (span.Days <= 3 || Convert.ToBoolean(UserSession.Instance.User.IsTeacher))
            {
                penaltyLabel.Text = "No penalty!";
                DaysPenalty.Visible = false;
                DaysPenalty.Enabled = false;
                PayPenalty = 0;
                return;
            }

            PayPenalty = 20 * (span.Days - 3);

            penaltyLabel.Text = $"Penalty: ₱{PayPenalty}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }

        private void OnBookReturn(object sender, EventArgs e)
        {
            if (DaysPassed <= 3 || Convert.ToBoolean(UserSession.Instance.User.IsTeacher))
            {
                BorrowDetails.DateReturned = DateTime.Now.ToString();
                MainForm.RemovePopup();
                MainForm.ShowPopup(new SuccessModal(MainForm, new MyShelf(MainForm), "You have returned the book!"));
                MainForm.BorrowBook.Return(BorrowDetails.Id, UserSession.Instance.User);
                return;
            }

            int paid = Convert.ToInt32(DaysPenalty.Text);

            if (paid >= PayPenalty)
            {
                BorrowDetails.DateReturned = DateTime.Now.ToString();
                MainForm.RemovePopup();
                MainForm.ShowPopup(new SuccessModal(MainForm, new MyShelf(MainForm), $"You have returned the book! {(paid > PayPenalty ? $"You have a change of {PayPenalty - paid}" : "")}"));
                MainForm.BorrowBook.Return(BorrowDetails.Id, UserSession.Instance.User);
                return;
            }

            errorText.Text = $"You need to pay {PayPenalty - paid} more.";
        }
    }
}
