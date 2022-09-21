using Microsoft.EntityFrameworkCore;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.Interfaces.Repositories;
using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Domain.Entities;
using SocialApp.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationContext _dbContext;

        public UserRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<User> AddAsync(User entity)
        {
            entity.Password = PasswordEncyption.ComputeSha256Hash(entity.Password);

            return await base.AddAsync(entity);
        }

        public async Task<User> LoginAsyn(LoginVm vm)
        {
            string passwordEncrypty = PasswordEncyption.ComputeSha256Hash(vm.Password);

            User user = await _dbContext.Set<User>()
                .FirstOrDefaultAsync(user => user.UserName == vm.UserName && user.Password == passwordEncrypty);

            return user;
        }

        //Obtener por UserName
        public  async Task<User> GetByNameAsync(PasswordVm vm)
        {

            return await _dbContext.Set<User>()                
                .FirstOrDefaultAsync(x => x.UserName.Equals(vm.UserName));

        }

    }
}
