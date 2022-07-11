using PurchaseOrder.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;


namespace PurchaseOrder.Infrastructure.Servic
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string toAddress, string subject, string message)
        {
            var toEmail = new MailAddress(toAddress);
            var fromEmail = new MailAddress("admin@cognizant.com");
            var mail = new MailMessage() { Body = message, IsBodyHtml = true, Subject = subject };
            mail.To.Add(toEmail);
            mail.From = fromEmail;

            try
            {
                //var networkCredentials = new NetworkCredential(fromEmail.Address, "");
                var smtp = new SmtpClient() { Host = "localhost", Port = 25, };
                smtp.Send(mail);
            }
            catch (Exception )
            {

            }
        }
    }
}