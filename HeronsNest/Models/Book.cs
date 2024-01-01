using System;
using System.Collections.Generic;

namespace HeronsNest.Models;

public partial class Book
{
    public int? BookId { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Series { get; set; }

    public string? Description { get; set; }

    public string? Genres { get; set; }

    public string? Awards { get; set; }

    public string? Characters { get; set; }

    public string? Places { get; set; }

    public string Isbn { get; set; } = null!;

    public string? Isbn13 { get; set; }

    public string? Language { get; set; }

    public string? FirstPublishDate { get; set; }

    public string? PublishDate { get; set; }

    public string? NumPages { get; set; }

    public int? NumRatings { get; set; }

    public int? NumReviews { get; set; }

    public double? AvgRating { get; set; }

    public string? Rated1 { get; set; }

    public string? Rated2 { get; set; }

    public string? Rated3 { get; set; }

    public string? Rated4 { get; set; }

    public string? Rated5 { get; set; }
}
