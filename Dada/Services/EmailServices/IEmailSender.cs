using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dada.Services.EmailServices
{
    public interface IEmailSender
    {
        public Task Send(string emailAddress,string userFullname,string templateId,object data);
    }
}
