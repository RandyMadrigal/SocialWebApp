using AutoMapper;
using Microsoft.AspNetCore.Http;
using SocialApp.Core.Application.Dtos.Email;
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
    public class UserService : GenericService<SaveUserVm, UserVm, User>, IUserService
    {
        private readonly IUserRepository _UserRepository;
        private readonly IEmailService _emailService;
        private readonly UserVm _userVm;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public UserService(IUserRepository UserRepository, IEmailService emailService, IMapper mapper,
            IHttpContextAccessor httpContextAccessor ) : base(UserRepository, mapper)
        {
             _UserRepository = UserRepository;
            _emailService = emailService;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
        }

        //Agregar
        public override async Task<SaveUserVm> Add(SaveUserVm vm)
        {
            
            vm.IsInactive = "Inactivo";

            SaveUserVm userVm = await base.Add(vm);

           await _emailService.SendAsync(new EmailRequest { 
            
               To = userVm.Email,
               Subject = $"Notification SocialApp {userVm.Name} {userVm.Apellido}",
               Body = $"<h1> Welcome to SocialApp</h1> " +
               $"<p> Your Username: {userVm.UserName} </p>" +
               $"<p> Your password: {vm.Password} </p>" +
               $"<p> Su usuario esta inactivo para activarlo favor de seguir el siguiente enlace: </p>" +
               $"<p> <a href={"https://localhost:44376/User/ActiveUser"}>ActivateUser </a> </p>"
                          
           });

            return userVm;
        }


        //Change Password
        public async Task ChangePass(PasswordVm vm)
        {

            User user = await _UserRepository.GetByNameAsync(vm);

            vm.Password = PasswordEncyption.ComputeSha256Hash(vm.Password);
            
            user.Password = vm.Password;            

            await _UserRepository.UpdateAsync(user,user.Id);

            await _emailService.SendAsync(new EmailRequest
            {

                To = user.Email,
                Subject = $"Notification SocialApp: {user.UserName}",
                Body = $"<h1> Contraseña cambiada con exito - SocialApp </h1>"

            });

        }

        //Activar usuario
        public async Task ActiveUser(PasswordVm vm)
        {

            User user = await _UserRepository.GetByNameAsync(vm);

            user.IsInactive = "Activo";

            await _UserRepository.UpdateAsync(user, user.Id);

            await _emailService.SendAsync(new EmailRequest
            {

                To = user.Email,
                Subject = $"Notification SocialApp: {user.UserName}",
                Body = $"<h1> Usuario Activado con exito - SocialApp </h1>"

            });

        }

        public async Task<UserVm> Login(LoginVm vm)
        {
            User user = await _UserRepository.LoginAsyn(vm);

            if (user == null)
            {
                return null;
            }

            UserVm userVm = _mapper.Map<UserVm>(user);            

            return userVm;
        }

        //Obtener todo
        public async Task<List<UserVm>> GetAllVmWithInclude()
        {
            var UserList = await _UserRepository.GetAllAsyncWithIncludes(new List<string> { "User" });

            return UserList.Select(user => new UserVm
            {
                Name = user.Name,
                Apellido = user.Apellido,
                Email = user.Email,
                Phone = user.Phone,
                UserName = user.UserName,
                Password = user.Password,
                IsInactive = user.IsInactive

            }).ToList();
        }

       
    }
}
