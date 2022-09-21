using Microsoft.Extensions.DependencyInjection;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application
{
    public static class ServiceRegistration
    {

        //Extension Method ** Decorator
        public static void AddApplicationLayer(this IServiceCollection services)
        {

            /*Inyeccion de dependencia al startup
                  Inteface - quien la implementa*/
            #region Services

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IPublicationService, PublicationService>();

            services.AddTransient<IFriendService, FriendService>();

            services.AddTransient<ICommentaryService, CommentaryService>();



            #endregion


        }
    }
}
