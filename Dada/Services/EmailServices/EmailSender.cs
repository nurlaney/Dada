using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Dada.Services.EmailServices
{
    public class EmailSender : IEmailSender
    {

        public async Task Send(string emailAddress, string userFullname, string templateId, object data)
        {
            var client = new SendGridClient("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");
            var SendGridMessage = new SendGridMessage();
            SendGridMessage.SetFrom("dada.no-reply@yandex.com","Dada");
            SendGridMessage.AddTo(emailAddress, userFullname);
            SendGridMessage.SetTemplateId(templateId);
            SendGridMessage.SetTemplateData(data);

           var response = await client.SendEmailAsync(SendGridMessage);

        }
    }
}
