using System;
using System.Collections.Generic;
using HeronsNest;
using Microsoft.EntityFrameworkCore;
using HeronsNest.Models;
using System.Diagnostics;
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

    public virtual DbSet<BookReservation> BookReservations { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var databasePath = Environment.GetEnvironmentVariable("BOOK_INFORMATION_DB_PATH");
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        databasePath ??= Path.Combine(projectDirectory + "\\Context\\BookInformation.db");
        Debug.WriteLine(databasePath);
        optionsBuilder.UseSqlite($"DataSource={databasePath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Isbn);

            entity.ToTable("Book");

            entity.Property(e => e.Isbn).HasColumnName("ISBN");
            entity.Property(e => e.FkReservedBy).HasColumnName("FK_ReservedBy");
            entity.Property(e => e.Isbn13).HasColumnName("ISBN13");
            entity.Property(e => e.NumPages).HasColumnType("INTEGER");

            entity.HasOne(d => d.FkReservedByNavigation).WithMany(p => p.Books).HasForeignKey(d => d.FkReservedBy);
        });

        modelBuilder.Entity<BookReservation>(entity =>
        {
            entity.HasKey(e => e.ReservationId);

            entity.ToTable("BookReservation");

            entity.Property(e => e.ReservationId).HasColumnType("TEXT (0, 24)");
            entity.Property(e => e.PenaltyCost)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMERIC");

            entity.HasOne(d => d.BookReservedNavigation).WithMany(p => p.BookReservations)
                .HasForeignKey(d => d.BookReserved)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.ReservedByNavigation).WithMany(p => p.BookReservations)
                .HasForeignKey(d => d.ReservedBy)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("categoryId");
            entity.Property(e => e.CategoryName).HasColumnName("categoryName");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.Password, "IX_User_Password").IsUnique();

            entity.Property(e => e.IsAdmin)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMERIC (0, 1)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
