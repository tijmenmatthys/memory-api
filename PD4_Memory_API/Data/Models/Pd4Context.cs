using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PD4_Memory_API.Data.Models;

public partial class Pd4Context : DbContext
{
    public Pd4Context()
    {
    }

    public Pd4Context(DbContextOptions<Pd4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<CombinationFound> CombinationFounds { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<MemoryReset> MemoryResets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
     //   => optionsBuilder.UseSqlServer("Server=LocalHost; Database=PD4; Trusted_Connection=True; TrustServerCertificate=True;");
        => optionsBuilder.UseSqlServer("Server=LocalHost; Database=PD4; User Id=api_user; Password=api_user; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.ToTable("Animal");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<CombinationFound>(entity =>
        {
            entity.ToTable("CombinationFound");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.ToTable("Image");

            entity.Property(e => e.Extention)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Image1).HasColumnName("Image");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Theme).HasMaxLength(50);
        });

        modelBuilder.Entity<MemoryReset>(entity =>
        {
            entity.ToTable("MemoryReset");

            entity.Property(e => e.Id);
            entity.Property(e => e.Timestamp)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
