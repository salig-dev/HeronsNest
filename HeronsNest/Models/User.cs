using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? IsTeacher { get; set; }

    public string Password { get; set; } = null!;

    public string? YearLevel { get; set; }

    public string? Department { get; set; }

    public string? Section { get; set; }

    public virtual ICollection<BookBorrow> BookBorrows { get; set; } = new List<BookBorrow>();

    public virtual ICollection<BookReserve> BookReserves { get; set; } = new List<BookReserve>();
}
