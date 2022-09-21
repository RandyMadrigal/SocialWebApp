using SocialApp.Core.Application.ViewModels.Commentary;
using SocialApp.Core.Application.ViewModels.Friend;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Interfaces.Services
{
    public interface ICommentaryService : IGenericService<SaveCommentaryVm,CommentaryVm, Commentary>
    {
        Task<List<CommentaryVm>> GetAllVmWithInclude();
    }
}
