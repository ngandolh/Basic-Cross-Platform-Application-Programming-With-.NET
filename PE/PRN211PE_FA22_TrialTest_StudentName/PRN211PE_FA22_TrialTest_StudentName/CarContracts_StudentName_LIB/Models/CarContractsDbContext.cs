using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarContracts_StudentName_LIB.Models;

public partial class CarContractsDbContext : DbContext
{
    public CarContractsDbContext()
    {
    }

    public CarContractsDbContext(DbContextOptions<CarContractsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
        var strConn = config["ConnectionStrings:CarContractsDB"];

        return strConn;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration config = new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
        var strConn = config["ConnectionStrings:CarContractsDB"];
        optionsBuilder.UseSqlServer(strConn);
    }
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.CarId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasOne(d => d.Car).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contracts_Cars");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
