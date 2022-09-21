using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {

        Task<User> LoginAsyn(LoginVm vm);
        Task<User> GetByNameAsync(PasswordVm vm);
        

    }
}
