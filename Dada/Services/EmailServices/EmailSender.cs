using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Dada.Services.EmailServices
{
    public class EmailSender : IEmailSender
    {
        public void Send(string emailAddress, string userFullname, SendGridMessage message)
        {
            var client = new SendGridClient("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");
            var from = new EmailAddress("dada.no-reply@yandex.com", "Dada");
            var subject = message.Subject;
            var to = new EmailAddress(emailAddress, userFullname);
            var plainTextContent = message.PlainTextContent;
            var htmlContent = message.HtmlContent;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response =  client.SendEmailAsync(msg).ConfigureAwait(false);
        }
    }
}
