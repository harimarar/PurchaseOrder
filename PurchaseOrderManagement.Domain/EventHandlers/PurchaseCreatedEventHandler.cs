using MediatR;
using PurchaseOrder.Domain.DomainEvents;
using PurchaseOrder.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PurchaseOrder.Domain.EventHandlers
{
    public class PurchaseCreatedEventHandler : INotificationHandler<PurchasedEvent>
    {
        private readonly IEmailService emailService;
        public PurchaseCreatedEventHandler(IEmailService email)
        {
            this.emailService = email;
        }
        public Task Handle(PurchasedEvent notification, CancellationToken cancellationToken)
        {
            var body = $"<h1>Welcome {notification.Name}</h1><br/>" +
                $"<p>Your Purchse is Created</p>";
            emailService.SendEmail(notification.Email, "Welcome", body);
            return Task.CompletedTask;
        }
    }
}