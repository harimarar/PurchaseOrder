using Microsoft.EntityFrameworkCore;
using PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurchaseOrder.Infrastructure.Data.Context
{
    public class PurchaseOrderContext : DbContext
    {
        public PurchaseOrderContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Purchase> PurchaseOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        base.OnModelCreating(modelBuilder);
           
                modelBuilder.ApplyConfigurationsFromAssembly(typeof(PurchaseOrderContext).Assembly);
        }

    }
}
