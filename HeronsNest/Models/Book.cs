﻿using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class Book
{
    public string Isbn { get; set; } = null!;

    public string? BookId { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Series { get; set; }

    public string? Description { get; set; }

    public string? Genres { get; set; }

    public string? Awards { get; set; }

    public int? Ratings { get; set; }

    public string? BookForm { get; set; }

    public string? Publisher { get; set; }

    public string? FirstPublishDate { get; set; }

    public string? PublishDate { get; set; }

    public string? LikedPercentage { get; set; }

    public string? CoverImg { get; set; }

    public virtual ICollection<BookBorrow> BookBorrows { get; set; } = new List<BookBorrow>();

    public virtual ICollection<BookReserve> BookReserves { get; set; } = new List<BookReserve>();
}
