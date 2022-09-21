using SocialApp.Core.Application.Interfaces.Repositories;
using SocialApp.Core.Domain.Entities;
using SocialApp.Infrastructure.Persistence.Contexts;
using SocialApp.Core.Application.ViewModels.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SocialApp.Infrastructure.Persistence.Repositories
{
    public class FriendRepository : GenericRepository<Friend>, IFriendRepository
    {
            
        private readonly ApplicationContext _dbContext;

        public FriendRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        //Obtener por UserName
        public async Task<User> GetByNameAsync(SaveFriendVm vm)
        {

            return await _dbContext.Set<User>()
                .FirstOrDefaultAsync(x => x.UserName.Equals(vm.FriendName));

        }



    }
}
