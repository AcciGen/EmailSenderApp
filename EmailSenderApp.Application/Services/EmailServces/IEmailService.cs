using EmailSenderApp.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Application.Services.EmailServces
{
    public interface IEmailService
    {
        public Task SendEmailAsync(EmailModel model);
    }
}
