using HeronsNest.Context;
using HeronsNest.Enums;
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
        
        public ReservationActionResult CreateReservation(Book book, DateTime From, DateTime? To = null)
        {
            if (Session.User == null) return ReservationActionResult.Failed;
            if (HasUserMaxReservations(Session.User)) return ReservationActionResult.MaxReservation;

            Context.BookReservations.Add(new()
            {
                BookReserved = book.Isbn,
                ReservedBy = Session.User.Id,
                DateReserved = From.ToString(),
                PenaltyCost = 0,
                DateReturn = (To ?? DateTime.Now.AddDays(3)).ToString()
            });
            SaveChanges();

            return ReservationActionResult.Success;
        }

        public ReservationActionResult UpdateReservation(BookReservation Reservation) 
        {
            try
            {
                Context.BookReservations.Update(Reservation);
                SaveChanges();
            } catch
            {
                return ReservationActionResult.Failed;
            }
            return ReservationActionResult.Success;
        }

        public ReservationActionResult ResolveReservation(Book book)
        {
            var BookReserved = Context.BookReservations.First(reservedBook => reservedBook.BookReserved == book.Isbn);

            if (BookReserved == null) return ReservationActionResult.Failed;

            BookReserved.DateReturned = DateTime.Now.ToString();
            BookReserved.PenaltyCost = 0;

            UpdateReservation(BookReserved);
            SaveChanges();

            return ReservationActionResult.Success;
        }

        public void DeleteReservation(Book book)
        {
            var BookReserved = Context.BookReservations.First(reservedBook => reservedBook.BookReserved == book.Isbn);
            if (BookReserved == null) return;

            Context.BookReservations.Remove(BookReserved); 
            SaveChanges();
        }

        public bool HasUserMaxReservations(User user)
        {
            var userReservations = UserReservations(user).Select(x => x.DateReturned == null).ToList();

            return userReservations.Count >= (user.IsAdmin == 1 ? 999 : 5);
        }

        public List<BookReservation> UserReservations(User user)
        {
            return [.. Context.BookReservations.Where(reservation => reservation.ReservedBy == user.Id)];
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
