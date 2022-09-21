using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {
        Task<List<ViewModel>> GetAllVm();
        Task<SaveViewModel> Add(SaveViewModel vm);
        Task<SaveViewModel> GetByIdSaveVm(int Id);
        Task Update(SaveViewModel vm, int Id);
        Task Delete(int Id);
    }
}
