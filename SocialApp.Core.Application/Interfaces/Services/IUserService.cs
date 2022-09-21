using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<SaveUserVm, UserVm, User>
    {
        Task<UserVm> Login(LoginVm vm);
        Task ChangePass(PasswordVm vm);
        Task ActiveUser(PasswordVm vm);
        Task<List<UserVm>> GetAllVmWithInclude();

    }
}
