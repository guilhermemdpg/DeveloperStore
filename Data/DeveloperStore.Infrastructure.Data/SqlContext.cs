using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;
using DeveloperStore.Domain.Entities;

namespace DeveloperStore.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(SqlContextOptions<SqlContext> options)
            : base(options)
        {
        }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModuleBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SaleNumber).IsRequired();
                entity.Property(e => e.CustomerName).IsRequired();
                entity.Property(e => e.BranchName).IsRequired();
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18,2)");
                entity.HasMany(e => e.Items).WithOne().HasForeignKey(e => e.SaleId);
            });

            modelBuilder.Entity<SaleItem>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ProductName).IsRequired();
                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18,2)");
                entity.Property(e => e.Discount).HasColumnType("decimal(18,2)");
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Surname).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.RegisterDate).HasColumnType("decimal(18,2)");
            });
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegisterDate") != null))
            {
               if (entry.State == EntityState.Added)
               {
                   entry.Property("RegisterDate").CurrentValue = DateTime.Now;
               }
               if (entry.State == EntityState.Modified)
               {
                   entry.Property("RegisterDate").IsModified = false;
               }
            } 
            return base.SaveChanges();
        }
    }
}
