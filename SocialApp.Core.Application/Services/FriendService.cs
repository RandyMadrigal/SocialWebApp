using AutoMapper;
using Microsoft.AspNetCore.Http;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.Interfaces.Repositories;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.ViewModels.Friend;
using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Services
{
    public class FriendService : GenericService<SaveFriendVm, FriendVm, Friend>, IFriendService
    {
        private readonly IFriendRepository _friendRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserVm _userVm;
        private readonly IMapper _mapper;

        public FriendService(IFriendRepository friendRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper)
            : base(friendRepository, mapper)
        {
            _mapper = mapper;
            _friendRepository = friendRepository;
            _httpContextAccessor = httpContextAccessor;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
        }

        //Actualizar / editar
        public override async Task Update(SaveFriendVm vm, int Id)
        {
            Friend friend = await _friendRepository.GetByIdAsync(vm.Id);

            friend.Id = vm.Id;
            friend.UserId = _userVm.Id;
            friend.UserName = _userVm.UserName;
            friend.FriendId = vm.Id;
            friend.FriendName = vm.FriendName;            

            await _friendRepository.UpdateAsync(friend, Id);
        }

        //Agregar
        public override async Task<SaveFriendVm> Add(SaveFriendVm vm)
        {
            /*En este metodo se van a agregar los 2 amigos al mismo tiempo
            *
            * Un usuario agrega un amigo y automaticamente el amigo agrega ese usuario
            * 
            */

            User user = await _friendRepository.GetByNameAsync(vm);

            //Usuario activo agrega un amigo
            Friend friend = new();

            friend.UserId = _userVm.Id;
            friend.UserName = _userVm.UserName;
            friend.FriendId = user.Id;
            friend.FriendName = user.UserName;

            friend = await _friendRepository.AddAsync(friend);
            //Usuario activo agrega un amigo

            //El Amigo Agrega automaticamente al usuario activo
            Friend amigo = new();
            amigo.UserId = user.Id;
            amigo.UserName = user.UserName;
            amigo.FriendId = _userVm.Id;
            amigo.FriendName = _userVm.UserName;

            amigo = await _friendRepository.AddAsync(amigo);
            //El Amigo Agrega automaticamente al usuario activo

            SaveFriendVm friendVm = new();

            friendVm.Id = friend.Id;
            friendVm.UserId = friend.UserId;
            friendVm.UserName = friend.UserName;
            friendVm.FriendId = friend.FriendId;
            friendVm.FriendName = friend.FriendName;

            return friendVm;
        }

        //Obtener todas mis publicaciones
        public async Task<List<FriendVm>> GetAllVmWithInclude()
        {
            var friendList = await _friendRepository.GetAllAsyncWithIncludes(new List<string> {"User"});

            return friendList.Where(friend => friend.UserId == _userVm.Id && friend.UserId != friend.FriendId)
                 .Select(friend => new FriendVm
                 {
                     Id = friend.Id,
                     UserId = friend.UserId,
                     Name = friend.User.Name,
                     Apellido = friend.User.Apellido,
                     UserName = friend.UserName,
                     FriendId = friend.FriendId,
                     FriendName = friend.FriendName,
                     UserImg = friend.User.UserImg

                 }).ToList();
        }

    }
}
