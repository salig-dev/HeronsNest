using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    public virtual DbSet<BookBorrow> BookBorrows { get; set; }

    public virtual DbSet<BookReserve> BookReserves { get; set; }

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
            entity.Property(e => e.BookId).HasColumnType("INTEGER");
            entity.Property(e => e.LikedPercentage).HasColumnType("INTEGER");
        });

        modelBuilder.Entity<BookBorrow>(entity =>
        {
            entity.ToTable("BookBorrow");

            entity.Property(e => e.Id).HasColumnType("TEXT (0, 24)");
            entity.Property(e => e.Penalty)
                .HasDefaultValueSql("20")
                .HasColumnType("NUMERIC");

            entity.HasOne(d => d.Book).WithMany(p => p.BookBorrows).HasForeignKey(d => d.BookId);

            entity.HasOne(d => d.UserNavigation).WithMany(p => p.BookBorrows).HasForeignKey(d => d.User);
        });

        modelBuilder.Entity<BookReserve>(entity =>
        {
            entity.HasKey(e => e.ReservationId);

            entity.ToTable("BookReserve");

            entity.Property(e => e.ReservationId).HasColumnType("TEXT (0, 24)");

            entity.HasOne(d => d.BookNavigation).WithMany(p => p.BookReserves)
                .HasForeignKey(d => d.Book)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.BookReserves)
                .HasForeignKey(d => d.UserId)
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

            entity.Property(e => e.IsTeacher)
                .HasDefaultValueSql("0")
                .HasColumnType("NUMERIC (0, 1)");
            entity.Property(e => e.YearLevel).HasColumnType("INTEGER (1, 4)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
