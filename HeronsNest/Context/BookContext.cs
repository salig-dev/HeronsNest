using System;
using System.Collections.Generic;
using HeronsNest.Models;
using Microsoft.EntityFrameworkCore;

namespace HeronsNest.Context;

public partial class BookContext : DbContext
{
    public BookContext()
    {
    }

    public BookContext(DbContextOptions<BookContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=C:\\Users\\UZER\\source\\repos\\HeronsNest\\HeronsNest\\Context\\BookInformation.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn);

            entity.ToTable("Book");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.Isbn13).HasColumnName("ISBN13");
            entity.Property(e => e.NumPages).HasColumnType("INTEGER");
            entity.Property(e => e.Rated1).HasColumnType("INTEGER");
            entity.Property(e => e.Rated2).HasColumnType("INTEGER");
            entity.Property(e => e.Rated3).HasColumnType("INTEGER");
            entity.Property(e => e.Rated4).HasColumnType("INTEGER");
            entity.Property(e => e.Rated5).HasColumnType("INTEGER");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("categoryId");
            entity.Property(e => e.CategoryName).HasColumnName("categoryName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
