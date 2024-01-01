using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public byte[]? IsAdmin { get; set; }

    public string Password { get; set; } = null!;

    public virtual ICollection<BookReservation> BookReservations { get; set; } = new List<BookReservation>();

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
