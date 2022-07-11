using PurchaseOrder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate
{
   public class Product : EntityBase
    {
        public virtual string ProductName
        {
            get;
            private set;
        }
        public virtual string Price
        {
            get;
            private set;
        }
        public virtual string Rating
        {
            get;
            private set;
        }
        
        public Product(string productName, string price, string rating)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Rating = rating;
           
        }
        private Product() { }

        public void ChangeProductName(string newProductName)
        {
            if (string.IsNullOrEmpty(newProductName))
                throw new ArgumentException("Invalid Name");

            if (this.ProductName == newProductName)
                return;
            this.ProductName = newProductName;
        }

    }
}
