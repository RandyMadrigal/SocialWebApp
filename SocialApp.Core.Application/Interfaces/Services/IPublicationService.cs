using SocialApp.Core.Application.ViewModels.Publication;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Interfaces.Services
{
    public interface IPublicationService : IGenericService<SavePublicationVm, PublicationVm,Publication>
    {

        Task<List<PublicationVm>> GetAllVmFriends();
        Task<List<PublicationVm>> GetAllVmWithInclude();

    }
}
