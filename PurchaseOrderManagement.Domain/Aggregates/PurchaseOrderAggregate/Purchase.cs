using PurchaseOrder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate
{
    public class Purchase : EntityBase, IAggregateRoot
    {
        private long id;

        public virtual DateTime PO_Date { get; private set; }
        public virtual string Qty { get; private set; }
       
        public Purchase(DateTime po_Date,string qty)
        {
            this.PO_Date = po_Date;
            this.Qty = qty;

        }
        private Purchase() { }

        public Purchase(long id)
        {
            this.id = id;
        }


        // public virtual long ProductId { get; set; }
        public virtual Product Product{ get; set; }

        //public virtual long SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public void ChangeQty(string newqty)
        {
            if (string.IsNullOrEmpty(newqty))
                throw new ArgumentException("Invalid Qty");

            if (this.Qty == newqty)
                return;
            this.Qty = newqty;
        }             
    }
}
