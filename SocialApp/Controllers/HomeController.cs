using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.ViewModels.Commentary;
using SocialApp.Core.Application.ViewModels.Publication;
using SocialApp.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.SocialApp.Middlewares;

namespace WebApp.SocialApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserVm _userVm;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICommentaryService _commentaryService;
        private readonly IPublicationService _publicationService;
        private readonly ValidateUserSession _validateUserSession;        

        public HomeController(IPublicationService publicationService, ValidateUserSession validateUserSession, 
            IHttpContextAccessor httpContextAccessor,
            ICommentaryService commentaryService)
        {
            _commentaryService = commentaryService;
            _publicationService = publicationService;
            _validateUserSession = validateUserSession;
            _httpContextAccessor = httpContextAccessor;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
        }

        public async Task<IActionResult> Index()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            ViewBag.PublicationList = await _publicationService.GetAllVmWithInclude();

            ViewBag.CommentaryList = await _commentaryService.GetAllVmWithInclude();

            return View();                       
        }

        #region CREAR POST
        [HttpPost]
        public async Task <IActionResult> Create(SavePublicationVm vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            /*validaciones
            if (!ModelState.IsValid)
            {

                ViewBag.PublicationList = await _publicationService.GetAllVmWithInclude();

                ViewBag.CommentaryList = await _commentaryService.GetAllVmWithInclude();

                return View("Index", vm);
            }  
            */
            //validaciones
      

            SavePublicationVm savePublication = await _publicationService.Add(vm);

                if (savePublication.Id != 0 && savePublication != null)
                {
                    savePublication.PostImg = ImgManage.UploadFile(vm.File, savePublication.Id);

                    await _publicationService.Update(savePublication, savePublication.Id);
                }

          return RedirectToRoute(new { controller = "Home", action = "Index" }  );
        }

        #endregion

        #region Editar
        public async Task<IActionResult> Edit(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            
            SavePublicationVm vm = await _publicationService.GetByIdSaveVm(Id);

            return View("SavePublication", vm);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SavePublicationVm vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }           

            //validaciones
            if (!ModelState.IsValid)
            {               
                return View("SavePublication", vm);
            }

            SavePublicationVm SaveVm = await _publicationService.GetByIdSaveVm(vm.Id);

            vm.PostImg = ImgManage.UploadFile(vm.File, vm.Id, true, SaveVm.PostImg);

            await _publicationService.Update(vm, vm.Id);

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
        #endregion

        #region DELETE
        public async Task<IActionResult> Delete(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }            

            return View(await _publicationService.GetByIdSaveVm(Id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            
            await _publicationService.Delete(Id);

            //Get Directory path
            string basePath = $"/Img/ProfileImg/{Id}";

            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            //Create folder if not exist
            if (!Directory.Exists(path))
            {
                DirectoryInfo _directoryInfo = new DirectoryInfo(path);

                foreach (FileInfo archivo in _directoryInfo.GetFiles())
                {
                    archivo.Delete();
                }
                foreach (DirectoryInfo folder in _directoryInfo.GetDirectories())
                {
                    folder.Delete(true);
                }

                Directory.Delete(path);
            }

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }
        #endregion
    }
}
