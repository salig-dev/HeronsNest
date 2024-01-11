﻿using HeronsNest.Screens;
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

namespace HeronsNest.Components.Modal
{
    public partial class ReserveBook : UserControl
    {
        Landing MainForm;
        string BookIsbn;
        public ReserveBook(Landing mainForm, string bookIsbn)
        {
            InitializeComponent();

            MainForm = mainForm;
            BookIsbn = bookIsbn;
        }

        private void ReserveBook_Load(object sender, EventArgs e)
        {
            var allReserves = MainForm.ReserveBook.GetAllReservations(null, bookIsbn: BookIsbn).Result;

            foreach (var reservation in allReserves)
            {
                Label l = new();
                DateTime dateBorrowed = DateTime.Parse(reservation.DateReserved);

                l.Text = $"{dateBorrowed}";

                reservedDatesList.Controls.Add(l);
            }
        }

        private void OnReserve(object sender, EventArgs e)
        {
            char[] x = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890#$^&*()".ToCharArray();
            string generatedId = "";
            Random r = new();
            for (int i = 0; i < 23; i++)
            {
                generatedId += x[r.Next(0, x.Length - 1)];
            }

            MainForm.ReserveBook.Reserve(new Models.BookReserve()
            {
                Book = BookIsbn,
                DateReserved = reserveDate.Value.ToString(),
                ReservationId = generatedId,
                UserId = UserSession.Instance.User.Id
            });

            MainForm.RemovePopup();
            MainForm.SwitchView(new MyShelf(MainForm));
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm.RemovePopup();
        }
    }
}
