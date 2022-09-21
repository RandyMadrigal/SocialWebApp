using AutoMapper;
using SocialApp.Core.Application.ViewModels.Commentary;
using SocialApp.Core.Application.ViewModels.Friend;
using SocialApp.Core.Application.ViewModels.Publication;
using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Domain.Entities;


namespace SocialApp.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Publication, PublicationVm>()
                .ForMember(dest => dest.QuantityPost, opt => opt.Ignore())
                .ForMember(dest => dest.Comentario, opt => opt.Ignore())
                .ForMember(dest => dest.UserName, opt => opt.Ignore())
                .ForMember(dest => dest.UserImg, opt => opt.Ignore())
                .ForMember(dest => dest.Comentario, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore());

            CreateMap<Publication, SavePublicationVm>()
                .ForMember(dest => dest.Comentario, opt => opt.Ignore())
                .ForMember(dest => dest.File, opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
                .ForMember(dest => dest.User, opt => opt.Ignore())
                .ForMember(dest => dest.commentaries, opt => opt.Ignore());

            CreateMap<Friend, FriendVm>()
               .ForMember(dest => dest.Name, opt => opt.Ignore())
               .ForMember(dest => dest.Apellido, opt => opt.Ignore())
               .ForMember(dest => dest.UserImg, opt => opt.Ignore());


            CreateMap<Friend, SaveFriendVm>()
              .ForMember(dest => dest.Name, opt => opt.Ignore())
              .ForMember(dest => dest.Apellido, opt => opt.Ignore())
              .ForMember(dest => dest.UserImg, opt => opt.Ignore())
              .ReverseMap()
              .ForMember(dest => dest.User, opt => opt.Ignore());

            CreateMap<User, UserVm>()
              .ForMember(dest => dest.Titulo, opt => opt.Ignore())
              .ForMember(dest => dest.PostImg, opt => opt.Ignore())
              .ForMember(dest => dest.Created, opt => opt.Ignore())
              .ForMember(dest => dest.FriendName, opt => opt.Ignore());

            CreateMap<User, SaveUserVm>()
              .ForMember(dest => dest.ConfirnmPassword, opt => opt.Ignore())
              .ForMember(dest => dest.File, opt => opt.Ignore())
              .ReverseMap()
              .ForMember(dest => dest.Publication, opt => opt.Ignore())
              .ForMember(dest => dest.Friend, opt => opt.Ignore());

            CreateMap<User, PasswordVm>()
             .ForMember(dest => dest.ConfirnmPassword, opt => opt.Ignore())
             .ReverseMap()
             .ForMember(dest => dest.Publication, opt => opt.Ignore())
             .ForMember(dest => dest.Friend, opt => opt.Ignore())
             .ForMember(dest => dest.UserImg, opt => opt.Ignore())
             .ForMember(dest => dest.Phone, opt => opt.Ignore())
             .ForMember(dest => dest.Email, opt => opt.Ignore())
             .ForMember(dest => dest.Apellido, opt => opt.Ignore())
             .ForMember(dest => dest.Name, opt => opt.Ignore());

            CreateMap<User, LoginVm>()
             .ReverseMap()
             .ForMember(dest => dest.Id, opt => opt.Ignore())
             .ForMember(dest => dest.Publication, opt => opt.Ignore())
             .ForMember(dest => dest.Friend, opt => opt.Ignore())
             .ForMember(dest => dest.UserImg, opt => opt.Ignore())
             .ForMember(dest => dest.Phone, opt => opt.Ignore())
             .ForMember(dest => dest.Email, opt => opt.Ignore())
             .ForMember(dest => dest.Apellido, opt => opt.Ignore())
             .ForMember(dest => dest.Name, opt => opt.Ignore());

            CreateMap<Commentary, CommentaryVm>()
               .ReverseMap()
               .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
               .ForMember(dest => dest.Created, opt => opt.Ignore());

            CreateMap<Commentary, SaveCommentaryVm>()
              .ReverseMap()
              .ForMember(dest => dest.Id, opt => opt.Ignore())
              .ForMember(dest => dest.CreateBy, opt => opt.Ignore())
              .ForMember(dest => dest.Created, opt => opt.Ignore());


        }

    }
}
