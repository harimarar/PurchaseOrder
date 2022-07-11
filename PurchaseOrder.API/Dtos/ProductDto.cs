using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseOrder.API.Dtos
{
    public class ProductDto
    {
        public long Id { get; set; }
        [Required, StringLength(30)]
        public  string ProductName
        {
            get;
             set;
        }
        [Required]
        public  string Price
        {
            get; set;
        }
        [Required]
        public  string Rating
        {
            get;
            set;
        }
        
    }
}
