using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.Services;
using SocialApp.Core.Domain.Settings;
using SocialApp.Infrastruture.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Infrastruture.Shared
{
    public static class ServiceRegistration
    {

        //Extension Method ** Decorator
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.AddTransient<IEmailService, EmailService>();

        }
    }
}
