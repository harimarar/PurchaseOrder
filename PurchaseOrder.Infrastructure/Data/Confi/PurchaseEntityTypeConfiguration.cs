using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurchaseOrder.Infrastructure.Data.Confi
{
    class PurchaseEntityTypeConfiguration : IEntityTypeConfiguration<Purchase>
    {

        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PO_Date).IsRequired(true);
            builder.Property(p => p.Qty).IsRequired(true);
           

        }
    }
}