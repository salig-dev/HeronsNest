using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public int? IsTeacher { get; set; }

    public string Password { get; set; } = null!;

    public int? YearLevel { get; set;} = null!;

    public string? Department { get;set; } = null!;

    public string? Section { get; set; }

    public virtual ICollection<BookReservation> BookReservations { get; set; } = new List<BookReservation>();
}
