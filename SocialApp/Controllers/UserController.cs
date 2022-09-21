using Microsoft.AspNetCore.Mvc;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.ViewModels.User;
using System;
using System.Threading.Tasks;
using WebApp.SocialApp.Middlewares;
using SocialApp.Core.Application.Helpers;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace WebApp.SocialApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ValidateUserSession _validateUserSession;
        private readonly UserVm _userVm;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(IUserService userService, ValidateUserSession validateUserSession,
            IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _validateUserSession = validateUserSession;
            _httpContextAccessor = httpContextAccessor;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
        }

        public IActionResult Index()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginVm vm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }


            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            UserVm userVM = await _userService.Login(vm);

            if (userVM != null)
            {
                HttpContext.Session.Set<UserVm>("user", userVM); //Objeto guardado en la seccion
                return RedirectToRoute(new { controller = "Home", action = "Index" });

            }
            else
            {
                ModelState.AddModelError("userValidation", "Datos incorrectos");
            }


            return View(vm);
        }


        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { controller = "User", action = "Index" });

        }

        public IActionResult RegisterUser()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View(new SaveUserVm());
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(SaveUserVm vm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            try
            {
                SaveUserVm saveUser = await _userService.Add(vm);

                if (saveUser.Id != 0 && saveUser != null)
                {
                    saveUser.UserImg = ImgManage.UploadFile(vm.File, saveUser.Id);

                    await _userService.Update(saveUser, saveUser.Id);
                }

                ModelState.AddModelError("userValidation", "Datos incorrectos");

                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("UserName", "Nombre de usuario ya esta en uso");
            }

            return View(vm);
        }


        //CHANGE PASSWORD
        public IActionResult SavePass()
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SavePass(PasswordVm vm)
        {
            if (_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            try
            {
                await _userService.ChangePass(vm);
                
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("UserName", "Este usuario no existe");
                return View(vm);
            }

            return RedirectToRoute(new { controller = "User", action = "Index" });

        }

        //Active user
        public IActionResult ActiveUser()
        {
            if (_validateUserSession.HasUser() )
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ActiveUser(PasswordVm vm)
        {
            if (_validateUserSession.HasUser() )
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            try
            {
                await _userService.ActiveUser(vm);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("UserName", "Este usuario no existe");
                return View(vm);
            }

            return RedirectToRoute(new { controller = "User", action = "Index" });

        }
    }
}
