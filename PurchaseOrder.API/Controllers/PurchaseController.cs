using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PurchaseOrder.API.Dtos;
using PurchaseOrder.Domain.Aggregates.PurchaseOrderAggregate;
using PurchaseOrder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseOrder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IRepository<Purchase> purchaseRepository;

        public PurchaseController(IRepository<Purchase> purchaseRepository)
        {
            this.purchaseRepository = purchaseRepository;
        }
        [HttpPost]
        public async Task<IActionResult> AddPurchase(PurchaseDto purchasedto)
        {
            var purchase = new Purchase(purchasedto.PO_Date, purchasedto.Qty);
            // Product product= new Product(purchasedto.ProductDtos.ProductName, purchasedto.ProductDtos.Price, purchasedto.ProductDtos.Rating);
            //Supplier supplier= new Supplier(purchasedto.SupplierDtos.SupplierName, purchasedto.SupplierDtos.Address, purchasedto.SupplierDtos.PhoneNo, purchasedto.SupplierDtos.Email, purchasedto.SupplierDtos.ZipCode);
            purchaseRepository.Add(purchase);
            await purchaseRepository.SaveAsync();
            return StatusCode(201);
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<PurchaseDto>))]
        public IActionResult GetPurchaseorder()
        {
            var purchases = purchaseRepository.Get();
            var dtos = from purchase in purchases
                       select new PurchaseDto
                       {
                           Id = purchase.Id,
                           PO_Date = purchase.PO_Date,
                           Qty = purchase.Qty,
                       };

            return Ok(dtos);

        }
        [HttpDelete]
       
        public async Task<IActionResult> DeletePurchase(PurchaseDto purchasedto)
        {
            var purchase = new Purchase(purchasedto.Id);
            purchaseRepository.Remove(purchase);
            await purchaseRepository.SaveAsync();
            return StatusCode(201);
        }

    }
}
