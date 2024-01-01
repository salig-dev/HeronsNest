using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class BookReservation
{
    public string ReservationId { get; set; } = null!;

    public string BookReserved { get; set; } = null!;

    public string ReservedBy { get; set; } = null!;

    public string? DateReserved { get; set; }

    public string? DateReturn { get; set; }

    public string? DateReturned { get; set; }

    public decimal? PenaltyCost { get; set; }

    public virtual Book BookReservedNavigation { get; set; } = null!;

    public virtual User ReservedByNavigation { get; set; } = null!;
}
