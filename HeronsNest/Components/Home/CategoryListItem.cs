using HeronsNest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Components.Home
{
    public partial class CategoryListItem : UserControl
    {
        private readonly Book Book;
        public CategoryListItem(Book book)
        {
            InitializeComponent();
            Book = book;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            authorInformationlabel.Text = Book.Author;
            bookTitleLabel.Text = Book.Title;
        }
    }
}
