using SocialApp.Core.Application.Dtos.Email;
using SocialApp.Core.Domain.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Interfaces.Services
{
   public interface IEmailService
    {
        public MailSettings _mailSettings { get; }
        Task SendAsync(EmailRequest request);
    }
}
