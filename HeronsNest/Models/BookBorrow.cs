using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class BookBorrow
{
    public string Id { get; set; } = null!;

    public string? DateBorrowed { get; set; }

    public string? DateDue { get; set; }

    public string? DateReturned { get; set; }

    public decimal? Penalty { get; set; }

    public string? BookId { get; set; }

    public string? User { get; set; }

    public virtual Book? Book { get; set; }

    public virtual User? UserNavigation { get; set; }
}
