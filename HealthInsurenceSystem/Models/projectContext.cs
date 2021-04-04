using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class projectContext : DbContext
    {
        public projectContext()
        {
        }

        public projectContext(DbContextOptions<projectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:projectser.database.windows.net,1433;Initial Catalog=project;Persist Security Info=False;User ID=adminlogin;Password=Mitpatel1248;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Admin");

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.Aemail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AEmail")
                    .IsFixedLength(true);

                entity.Property(e => e.Cemail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CEmail")
                    .IsFixedLength(true);

                entity.Property(e => e.Dop).HasColumnType("date");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Payment");

                entity.Property(e => e.ExpiredDate)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Person");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Policy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Policy");

                entity.Property(e => e.MaxAge).HasColumnName("maxAge");

                entity.Property(e => e.MinAge).HasColumnName("minAge");

                entity.Property(e => e.MonthPremium).HasColumnName("monthPremium");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
