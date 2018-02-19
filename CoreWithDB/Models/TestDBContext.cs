using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreWithDB.Models
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {  }


        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<ParkingLot> ParkingLot { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=(local)\sqlexpress;Database=TestDB;Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParkingLotId).HasColumnName("ParkingLotID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParkingLot)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.ParkingLotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_ParkingLot");
            });

            modelBuilder.Entity<ParkingLot>(entity =>
            {
                entity.Property(e => e.ParkingLotId).HasColumnName("ParkingLotID");

                entity.Property(e => e.LotName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
