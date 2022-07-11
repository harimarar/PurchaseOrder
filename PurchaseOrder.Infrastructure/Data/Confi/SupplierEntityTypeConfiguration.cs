using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurchaseOrder.Infrastructure.Data.Confi
{
    class SupplierEntityTypeConfiguration : IEntityTypeConfiguration<Supplier>
    {

        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SupplierName).HasMaxLength(30).IsRequired(true);
            builder.Property(p => p.Address).HasMaxLength(30).IsRequired(true);
            builder.Property(p => p.PhoneNo).HasMaxLength(10).IsFixedLength(true).IsRequired(true);
            builder.Property(p => p.Email).HasMaxLength(50).IsRequired(true);
            builder.Property(p => p.ZipCode).HasMaxLength(50).IsRequired(true);

        }
        
    }
}
