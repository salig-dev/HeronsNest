using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class BookReserve
{
    public string ReservationId { get; set; } = null!;

    public string Book { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? DateReserved { get; set; }

    public virtual Book BookNavigation { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
