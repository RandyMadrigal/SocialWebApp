using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialApp.Core.Application.Interfaces.Repositories;
using SocialApp.Infrastructure.Persistence.Contexts;
using SocialApp.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Infrastructure.Persistence
{
    //Se registran todas las inyecciones de dependencias que corresponden a los repositorios y Contexts
    public static class ServiceRegistration
    {

        //Extension Method ** Decorator
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            if (config.GetValue<bool>("UseInMemoryDatabase"))
            {
                //Database en memoria
                services.AddDbContext<ApplicationContext>(options => options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                //Configuraciones del startup
                services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            }

            /*Inyeccion de dependencia al startup
                  Inteface - quien la implementa*/
            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<IPublicationRepository, PublicationRepository>();

            services.AddTransient<IFriendRepository, FriendRepository>();

            services.AddTransient<ICommentaryRepository, CommentaryRepository>();




            #endregion


        }

    }
}
