using System;
using System.Collections.Generic;
using System.Text;

namespace PurchaseOrder.Domain.DomainEvents
{
    public class PurchasedEvent: EventBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
