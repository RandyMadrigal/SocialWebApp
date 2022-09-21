using Microsoft.AspNetCore.Http;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.SocialApp.Middlewares
{
    public class ValidateUserSession
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ValidateUserSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool HasUser()
        {
            UserVm userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");

            if (userVm == null)
            {
                return false;
            }

            return true;
        }
    }
}
