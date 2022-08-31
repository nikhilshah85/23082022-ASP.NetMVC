using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DI_Demo.Models.EF
{
    public partial class shoppingAPPDBContext : DbContext
    {
        public shoppingAPPDBContext()
        {
        }

        public shoppingAPPDBContext(DbContextOptions<shoppingAPPDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<ProductsList> ProductsLists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=WIN8\\NIKHILINSTANCE;database=shoppingAPPDB; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("customerEmail");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("customerType");

                entity.Property(e => e.CustomerWalletBalance).HasColumnName("customerWalletBalance");
            });

            modelBuilder.Entity<ProductsList>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__Products__DD36D562C570BE1C");

                entity.ToTable("ProductsList");

                entity.Property(e => e.PId)
                    .ValueGeneratedNever()
                    .HasColumnName("pId");

                entity.Property(e => e.PCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pCategory");

                entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");

                entity.Property(e => e.PName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("pName");

                entity.Property(e => e.PPrice).HasColumnName("pPrice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
