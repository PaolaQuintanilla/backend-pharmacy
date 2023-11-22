using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Context;

public partial class PharmacydbContext : DbContext
{
    public PharmacydbContext(DbContextOptions<PharmacydbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DbLaboratory> Laboratories { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseMySql("server=localhost;database=pharmacydb;user id=root;password=12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb3_general_ci")
            .HasCharSet("utf8mb3");

        modelBuilder.Entity<DbLaboratory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("laboratory");

            entity.Property(e => e.Name).HasMaxLength(45);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
