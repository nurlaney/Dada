using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Services.EmailServices
{
    public interface IEmailSender
    {
        public void Send(string emailAddress,string userFullname ,SendGridMessage message);
    }
}
