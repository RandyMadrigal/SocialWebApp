using SocialApp.Core.Application.ViewModels.Friend;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Interfaces.Services
{
    public interface IFriendService : IGenericService<SaveFriendVm, FriendVm, Friend>
    {
        Task<List<FriendVm>> GetAllVmWithInclude();
    }
}
