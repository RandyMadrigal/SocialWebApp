using AutoMapper;
using Microsoft.AspNetCore.Http;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.Interfaces.Repositories;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.ViewModels.Commentary;
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
    public class CommentaryService : GenericService<SaveCommentaryVm, CommentaryVm, Commentary> ,
        ICommentaryService
    {

        private readonly IPublicationRepository _publicationRepository;
        private readonly ICommentaryRepository _commentaryRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserVm _userVm;
        private readonly IMapper _mapper;

        public CommentaryService(IFriendRepository friendRepository, IHttpContextAccessor httpContextAccessor,
           ICommentaryRepository commentaryRepository, IPublicationRepository publicationRepository, IMapper mapper) : base(commentaryRepository, mapper)
        {
            _mapper = mapper;
            _publicationRepository = publicationRepository;
            _commentaryRepository = commentaryRepository;
            _httpContextAccessor = httpContextAccessor;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
        }

        //Agregar
        public override async Task<SaveCommentaryVm> Add(SaveCommentaryVm vm)
        {
                        
            vm.PublicationId = vm.Id;
            vm.Comentario = vm.Comentario;
            vm.UserImg = _userVm.UserImg;

            return await base.Add(vm);

        }


        //Obtener todas mis publicaciones
        public async Task<List<CommentaryVm>> GetAllVmWithInclude()
        {
            var CommentaryList = await _commentaryRepository.GetAllAsyncWithIncludes(new List<string> { "_publication" });

            return CommentaryList.Where(x => x._publication.Id == x.PublicationId )
                 .Select(x => new CommentaryVm
                 {
                     Comentario = x.Comentario,
                     UserImg = x.UserImg,

                 }).ToList();


        }

    }
}
