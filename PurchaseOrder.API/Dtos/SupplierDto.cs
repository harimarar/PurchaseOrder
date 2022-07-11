using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseOrder.API.Dtos
{
    public class SupplierDto
    {
        public long Id { get; set; }
        [Required, StringLength(30)]
        public  string SupplierName{ get; set;}

        [Required, StringLength(30)]
        public  string Address
        {
            get;
            set;
        }
        [Required]
        public  string PhoneNo
        {
            get;
             set;
        }
        [Required, StringLength(50), EmailAddress]
        public  string Email
        {
            get;
             set;
        }
        [Required]
        public string ZipCode
        {
            get;
           set;
        }
        
    }
}
