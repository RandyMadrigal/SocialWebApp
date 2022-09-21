using Microsoft.EntityFrameworkCore;
using SocialApp.Core.Application.Interfaces.Repositories;
using SocialApp.Core.Domain.Entities;
using SocialApp.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Infrastructure.Persistence.Repositories
{
    public class PublicationRepository : GenericRepository<Publication>, IPublicationRepository
    {

        private readonly ApplicationContext _dbContext;

        public PublicationRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

       

    }
}
