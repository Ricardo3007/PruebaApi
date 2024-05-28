using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PruebaApi.Domain.Entities.Car;

namespace PruebaApi.DataAccess.Context;

public partial class CarContext : DbContext
{
    public CarContext()
    {
    }

    public CarContext(DbContextOptions<CarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carro> Carro { get; set; }

    public virtual DbSet<Marca> Marca { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carro>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion).HasMaxLength(100);
            entity.Property(e => e.Modelo).HasMaxLength(30);

            entity.HasOne(d => d.MarcaNavigation).WithMany(p => p.Carro)
                .HasForeignKey(d => d.Marca)
                .HasConstraintName("FK_Carro_Marca");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
