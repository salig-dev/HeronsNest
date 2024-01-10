using HeronsNest.Components;
using HeronsNest.Models;
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

namespace HeronsNest.Screens
{
    public partial class MyShelf : UserControl
    {

        Landing mainForm;

        public MyShelf(Landing mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            leftNavBar1.MainForm = mainForm;
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var BorrowedBooksUser = await mainForm.BorrowBook.GetAllBorrows(UserSession.Instance.User);
            var ReservedBooksUser = await mainForm.ReserveBook.GetAllReservations(UserSession.Instance.User);
            
            foreach (BookBorrow r in BorrowedBooksUser)
            {
                BookCard card = new(r, mainForm.BookTrie.Search(r.BookId!)[0]);
                cardListView.Controls.Add(card);
            }

            foreach (BookReserve r in ReservedBooksUser)
            {
                BookCard card = new(r, mainForm.BookTrie.Search(r.Book!)[0]);
                cardListView.Controls.Add(card);
            }
        }

        private void MyShelf_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.SwitchView(new Home(mainForm));
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void bookCard2_Load(object sender, EventArgs e)
        {

        }

        private void bookCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
