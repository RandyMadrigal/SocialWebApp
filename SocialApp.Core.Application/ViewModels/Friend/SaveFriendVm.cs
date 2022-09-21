using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.ViewModels.Friend
{
    public class SaveFriendVm
    {
        public int Id { get; set; }
        public int UserId { get; set; } //Yo
        public string UserName { get; set; } //yo
        public int FriendId { get; set; } //friend- //Foreign key

        [Required(ErrorMessage = "Debe colocar Nombre de Usuario")]
        [DataType(DataType.Text)]
        public string FriendName { get; set; } //Friend

        public string Name { get; set; } //Friend
        public string Apellido { get; set; } //Friend

        public string UserImg { get; set; }
    }
}
