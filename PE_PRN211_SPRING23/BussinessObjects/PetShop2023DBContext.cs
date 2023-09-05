using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BussinessObjects
{
    public partial class PetShop2023DBContext : DbContext
    {
        public PetShop2023DBContext()
        {
        }

        public PetShop2023DBContext(DbContextOptions<PetShop2023DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pet> Pets { get; set; }
        public virtual DbSet<PetGroup> PetGroups { get; set; }
        public virtual DbSet<PetShopMember> PetShopMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            //                optionsBuilder.UseSqlServer("Server=LAPTOP-HP6ERQBA\\SQLEXPRESS; Database=PetShop2023DB; Uid=sa; Pwd=12345");
            //            }
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionString"];
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.ToTable("Pet");

                entity.Property(e => e.PetId).ValueGeneratedNever();

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.PetDescription).HasMaxLength(220);

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.PetName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.PetGroup)
                    .WithMany(p => p.Pets)
                    .HasForeignKey(d => d.PetGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Pet__PetGroupId__3B75D760");
            });

            modelBuilder.Entity<PetGroup>(entity =>
            {
                entity.ToTable("PetGroup");

                entity.Property(e => e.PetGroupId).HasMaxLength(20);

                entity.Property(e => e.GroupDescription).HasMaxLength(150);

                entity.Property(e => e.OriginalSource).HasMaxLength(60);

                entity.Property(e => e.PetGroupName)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<PetShopMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("PK__PetShopM__0CF04B38FE049733");

                entity.ToTable("PetShopMember");

                entity.HasIndex(e => e.EmailAddress, "UQ__PetShopM__49A14740A321F6F6")
                    .IsUnique();

                entity.Property(e => e.MemberId)
                    .HasMaxLength(20)
                    .HasColumnName("MemberID");

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MemberPassword)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
