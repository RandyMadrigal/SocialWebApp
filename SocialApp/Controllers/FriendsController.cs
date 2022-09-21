using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.Interfaces.Services;
using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Application.ViewModels.Friend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.SocialApp.Middlewares;

namespace WebApp.SocialApp.Controllers
{
    public class FriendsController : Controller
    {
        private readonly IPublicationService _publicationService;
        private readonly ValidateUserSession _validateUserSession;
        private readonly UserVm _userVm;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IFriendService _friendService;
        private readonly ICommentaryService _commentaryService;


        public FriendsController(IFriendService friendService, IUserService userService, 
            ValidateUserSession validateUserSession,IHttpContextAccessor httpContextAccessor,
            IPublicationService publicationService, ICommentaryService commentaryService)
        {
            _commentaryService = commentaryService;
            _publicationService = publicationService;
            _validateUserSession = validateUserSession;
            _httpContextAccessor = httpContextAccessor;
            _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
            _friendService = friendService;

        }

        public async Task<IActionResult> Index()
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            

           ViewBag.PublicationList = await _publicationService.GetAllVmFriends();

           ViewBag.FriendsList = await _friendService.GetAllVmWithInclude();

           ViewBag.CommentaryList = await _commentaryService.GetAllVmWithInclude();

            return View();
        }

        #region Agregar Amigo
        [HttpPost]
        public async Task<IActionResult> AddFriend(SaveFriendVm vm)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "Home", action = "Index" });
            }
           
            if (!ModelState.IsValid)
            {
                ViewBag.PublicationList = await _publicationService.GetAllVmFriends();
                ViewBag.FriendsList = await _friendService.GetAllVmWithInclude();
                ViewBag.CommentaryList = await _commentaryService.GetAllVmWithInclude();

                return View("Index",vm);
            }

            try
            {
                await _friendService.Add(vm);

            }
            catch (Exception ex)
            {
                
                ViewBag.PublicationList = await _publicationService.GetAllVmFriends();

                ViewBag.FriendsList = await _friendService.GetAllVmWithInclude();

                ViewBag.CommentaryList = await _commentaryService.GetAllVmWithInclude();


                ModelState.AddModelError("UserName", "Usuario no encontrado");

                return View("Index",vm);
            }

            ViewBag.FriendsList = await _friendService.GetAllVm();
            return RedirectToRoute(new { controller = "Friends", action = "Index" });

        }
        #endregion

        #region DELETE Friend

        public async Task<IActionResult> Delete(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            
            return View(await _friendService.GetByIdSaveVm(Id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int Id)
        {
            if (!_validateUserSession.HasUser())
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });
            }
            

            await _friendService.Delete(Id);


            return RedirectToRoute(new { controller = "Friends", action = "Index" });
        }
        #endregion
    }
}
