﻿using HeronsNest.Models;
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
        private EventHandler OnClickHandler;
        public event EventHandler OnCardClick
        {
            add
            {
                OnClickHandler += value;
            }

            remove
            {
                OnClickHandler -= value;
            }
        }
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
            try
            {
                bookImage.LoadAsync(Book.CoverImg);
            } catch {
                Debug.WriteLine($"{Book.Isbn} does not have a proper image path!");
            }
        }

        private void authorInformationlabel_Click(object sender, EventArgs e)
        {

        }

        private void bookTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void OnCardClicked(object sender, EventArgs e)
        {
            OnClickHandler?.Invoke(this, e);
        }
    }
}
