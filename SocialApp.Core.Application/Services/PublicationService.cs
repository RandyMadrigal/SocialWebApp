using AutoMapper;
using Microsoft.AspNetCore.Http;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.Interfaces.Repositories;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.ViewModels.Friend;
using SocialApp.Core.Application.ViewModels.Publication;
using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Services
{
    public class PublicationService : GenericService<SavePublicationVm, PublicationVm, Publication>, IPublicationService
    {
        private readonly IPublicationRepository _PublicationRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserRepository _userRepository;
        private readonly UserVm _userVm;
        private readonly IFriendRepository _friendRepository;
        private readonly IMapper _mapper;

        public PublicationService(IPublicationRepository PublicationRepository, IHttpContextAccessor httpContextAccessor,
            IUserRepository userRepository, IFriendRepository friendRepository, IMapper mapper) : base (PublicationRepository, mapper)
        {
            _mapper = mapper;
            _friendRepository = friendRepository;
            _PublicationRepository = PublicationRepository;
            _httpContextAccessor = httpContextAccessor;
            _userRepository = userRepository;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");           
        }

        //Actualizar / editar
        public override async Task Update(SavePublicationVm vm , int Id)
        {
            vm.UserId = _userVm.Id;

            await base.Update(vm,Id);
        }

        //Agregar
        public override async Task<SavePublicationVm> Add(SavePublicationVm vm)
        {
            vm.UserId = _userVm.Id;            

            return await base.Add(vm);

        }



        //Obtener todas mis publicaciones
        public async Task<List<PublicationVm>> GetAllVmWithInclude()
        {
            var PublicationList = await _PublicationRepository.GetAllAsyncWithIncludes(new List<string> { "User" });

            return PublicationList.Where(publication => publication.UserId == _userVm.Id)
                .OrderByDescending(publication => publication.Id)
                .Select(publication => new PublicationVm
                {
                 Id = publication.Id,
                 Titulo = publication.Titulo,
                 PostImg = publication.PostImg,
                 QuantityPost = PublicationList.Where( x => x.UserId == _userVm.Id).Count(),
                 Created = publication.Created                

                }).ToList();
        }


         #region Funciona - NO TOCAR!!!!
        public async Task<List<PublicationVm>> GetAllVmFriends()
        {
            var PublicationList = await _PublicationRepository.GetAllAsyncWithIncludes(new List<string> { "User" });            

            //Publicaciones DE LOS DEMAS
            var result = PublicationList.Where(publication => publication.UserId != _userVm.Id)
                .OrderByDescending(publication => publication.Id)
                .Select(publication => new PublicationVm
                {

                    Id = publication.Id,
                    Titulo = publication.Titulo,
                    PostImg = publication.PostImg,
                    QuantityPost = PublicationList.Where(x => x.UserId == _userVm.Id).Count(),
                    Created = publication.Created,
                    UserImg = publication.User.UserImg,
                    UserId = publication.UserId
                    

                }).ToList();

            //ALL ID FRIEND
            var friendList = await _friendRepository.GetAllAsyncWithIncludes(new List<string> {"User"});

            var FriendId = friendList.Where(friend => friend.UserId == _userVm.Id && friend.UserId != friend.FriendId)
                 .Select(friend => new FriendVm
                 {
                     FriendId = friend.FriendId,

                 }).ToArray();


            //COMPARACION 
            return result.Where(x => FriendId.Any( i => i.FriendId == x.UserId) ).Select(publication => new PublicationVm {

                Id = publication.Id,
                Titulo = publication.Titulo,
                PostImg = publication.PostImg,
                QuantityPost = PublicationList.Where(x => x.UserId == _userVm.Id).Count(),
                Created = publication.Created,
                UserImg = publication.UserImg,               

            }).ToList();
        }
    }

        #endregion NO TOCAR!!!!
}
