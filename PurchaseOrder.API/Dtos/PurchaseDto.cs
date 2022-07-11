using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseOrder.API.Dtos
{
    public class PurchaseDto

    {
        public long Id { get; set; }
        [Required]
        public  DateTime PO_Date { get;  set; }
        [Required]
        public  string Qty { get;  set; }
        public virtual  ProductDto ProductDtos { get; set; }
        public virtual SupplierDto SupplierDtos { get; set; }
    }
}
