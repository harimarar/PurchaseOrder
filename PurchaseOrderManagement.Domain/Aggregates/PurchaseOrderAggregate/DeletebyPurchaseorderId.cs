using PurchaseOrder.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate
{
    public class DeletebyPurchaseorderId : SpecificationBase<Purchase>
    {
        private readonly long purchaseId;
        public DeletebyPurchaseorderId(long purchaseid)
        {
            this.purchaseId = purchaseid;            
        }

        public override Expression<Func<Purchase, bool>> ToExpression()
        {
            return obj => obj.Id == purchaseId;
        }
    }
}