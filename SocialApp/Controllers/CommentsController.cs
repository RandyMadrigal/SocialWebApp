using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Application.ViewModels.Commentary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.SocialApp.Middlewares;
using SocialApp.Core.Application.ViewModels.Publication;

namespace WebApp.SocialApp.Controllers
{
    public class CommentsController : Controller
    {

        private readonly UserVm _userVm;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ICommentaryService _commentaryService;
        private readonly IPublicationService _publicationService;
        private readonly ValidateUserSession _validateUserSession;

        public CommentsController( ValidateUserSession validateUserSession, IPublicationService publicationService,
            IHttpContextAccessor httpContextAccessor,
            ICommentaryService commentaryService)
        {
            _publicationService = publicationService;
            _commentaryService = commentaryService;
            _validateUserSession = validateUserSession;
            _httpContextAccessor = httpContextAccessor;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
        }

        public async Task<IActionResult> Index(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            try
            {
                var vm = await _publicationService.GetByIdSaveVm(Id);

            }
            catch (Exception)
            {

                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddComment(SaveCommentaryVm vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }

            //validaciones
            if (!ModelState.IsValid)
            {
                return View("Index",vm);
            }
           
            await _commentaryService.Add(vm);

            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }





    }
}
