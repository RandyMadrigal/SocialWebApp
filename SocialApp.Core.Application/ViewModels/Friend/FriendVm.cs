using SocialApp.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.ViewModels.Friend
{
    public class FriendVm
    {
        public int Id { get; set; }
        public int UserId { get; set; } //Yo
        public string UserName { get; set; } //yo
        public int FriendId { get; set; } //friend- //Foreign key
        public string FriendName { get; set; } //Friend
        
        public string Name { get; set; } //Friend
        public string Apellido { get; set; } //Friend
        public string UserImg { get; set; }

        public UserVm User { get; set; }

    }
}
