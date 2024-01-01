using HeronsNest.Context;
using HeronsNest.Models;
using HeronsNest.Singleton;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeronsNest.Algorithms
{
    public class ReservationHandler(BookContext _context)
    {
        private readonly BookContext Context = _context;
        private readonly UserSession Session = UserSession.Instance;
        
        public void CreateReservation(Book book, DateTime From, DateTime To)
        {
            if (Session.User == null) return;

            Context.BookReservations.Add(new()
            {
                BookReserved = book.Isbn,
                ReservedBy = Session.User.Id,
                DateReserved = From.ToString(),
                PenaltyCost = 0,
                DateReturn = To.ToString()
            });
            SaveChanges();
        }

        public void UpdateReservation(BookReservation Reservation) 
        {
            Context.BookReservations.Update(Reservation);
            SaveChanges();
        }

        public void ResolveReservation(Book book)
        {
            var BookReserved = Context.BookReservations.First(reservedBook => reservedBook.BookReserved == book.Isbn);

            if (BookReserved == null) return;

            BookReserved.DateReturned = DateTime.Now.ToString();
            BookReserved.PenaltyCost = 0;

            UpdateReservation(BookReserved);
            SaveChanges();
        }

        public void DeleteReservation(Book book)
        {
            var BookReserved = Context.BookReservations.First(reservedBook => reservedBook.BookReserved == book.Isbn);
            if (BookReserved == null) return;

            Context.BookReservations.Remove(BookReserved); 
            SaveChanges();
        }

        public List<BookReservation> UserReservations(User user)
        {
            return Context.BookReservations.Where(reservation => reservation.ReservedBy == user.Id).ToList();
        }

        public List<BookReservation> UserDueReservation(User user)
        {
            return UserReservations(user)
                .Where(x => DateTime.Parse(x.DateReserved!) > DateTime.Parse(x.DateReturn!))
                .ToList();
        }

        public List<BookReservation> UserCompleteReservation(User user)
        {
            return UserReservations(user)
                .Where(x => x.DateReturned != null)
                .ToList();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
