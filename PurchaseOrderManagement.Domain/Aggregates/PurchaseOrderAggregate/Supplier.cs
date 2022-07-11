using PurchaseOrder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate
{
    public class Supplier : EntityBase 
    {
        
        public  string SupplierName
        {
            get;
            private set;
        }
        public  string Address
        {
            get;
            private set;
        }
        public  string PhoneNo
        {
            get;
            private set;
        }
        public  string Email
        {
            get;
            private set;
        }
        public  string ZipCode
        {
            get;
            private set;
        }
        public Supplier(string supplierName, string address,string phoneNo,string email,string zipCode)
        {
            this.SupplierName = supplierName;
            this.Address = address;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.ZipCode = zipCode;
        }
        private Supplier() { }
        public void ChangeSupplierName(string newSupplierName)
        {
            if (string.IsNullOrEmpty(newSupplierName))
                throw new ArgumentException("Invalid Name");

            if (this.SupplierName == newSupplierName)
                return;
            this.SupplierName = newSupplierName;
        }
        public void ChangePhoneNumber(string newPhoneNumber)
        {
            if (string.IsNullOrEmpty(newPhoneNumber) || !(newPhoneNumber.Length == 10))
                throw new ArgumentException("Invalid newPhoneNumber");

            if (this.PhoneNo == newPhoneNumber)
                return;
            this.PhoneNo = newPhoneNumber;
        }
        public void ChangeEmail(string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail) || !newEmail.Contains("@"))
                throw new ArgumentException("Invalid email");

            if (this.Email == newEmail)
                return;
            this.Email = newEmail;
        }
    }
}
