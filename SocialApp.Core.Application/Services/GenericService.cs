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
    public class GenericService<SaveViewModel, ViewModel, Entity> : IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class

    {
        private readonly IGenericRepository<Entity> _Repository;
        private readonly IMapper _mapper;


        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _mapper = mapper;
            _Repository = repository;
        }

        //Actualizar / editar
        public virtual async Task Update(SaveViewModel vm, int Id)
        {
            Entity entity = _mapper.Map<Entity>(vm);

            await _Repository.UpdateAsync(entity, Id);

        }

        //Agregar
        public virtual async Task<SaveViewModel> Add(SaveViewModel vm)
        {

            Entity entity = _mapper.Map<Entity>(vm);

            entity = await _Repository.AddAsync(entity);

            SaveViewModel SaveVm = _mapper.Map<SaveViewModel>(entity);

            return SaveVm;
        }

        //Borrar
        public virtual async Task Delete(int Id)
        {
            Entity entity = await _Repository.GetByIdAsync(Id);

            await _Repository.DeleteAsync(entity);
        }

        //Obtener POR ID
        public virtual async Task<SaveViewModel> GetByIdSaveVm(int Id)
        {
            Entity entity = await _Repository.GetByIdAsync(Id);

            SaveViewModel vm = _mapper.Map<SaveViewModel>(entity);

            return vm;
        }

        //Obtener todas mis publicaciones
        public virtual async Task<List<ViewModel>> GetAllVm()
        {
            var entityList = await _Repository.GetAllAsync();

            return _mapper.Map<List<ViewModel>>(entityList);

        }
    }
}

