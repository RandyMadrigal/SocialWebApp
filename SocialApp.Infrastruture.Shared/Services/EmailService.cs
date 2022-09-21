﻿using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;
using MimeKit;
using SocialApp.Core.Application.Dtos.Email;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Domain.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Security;

namespace SocialApp.Infrastruture.Shared.Services
{
    public class EmailService : IEmailService
    {
        public MailSettings _mailSettings { get; }

        public EmailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task SendAsync(EmailRequest request)
        {
            try
            {
                MimeMessage email = new();
                email.Sender = MailboxAddress.Parse($"{_mailSettings.DisplayName} <{_mailSettings.EmailFrom}>"); //Quien envia el correo
                email.To.Add(MailboxAddress.Parse(request.To)); //A quien se le envia 
                email.Subject = request.Subject;

                BodyBuilder builder = new(); //Cuerpo del correo.
                builder.HtmlBody = request.Body;
                email.Body = builder.ToMessageBody();

                //Configurar SMTP

                using SmtpClient smtp = new();
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPass);
                await smtp.SendAsync(email);

                smtp.Disconnect(true);

            }
            catch (Exception ex)
            { 

                
            }


        }
    }
}
