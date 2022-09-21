using SocialApp.Core.Application.ViewModels.Friend;
using SocialApp.Core.Application.ViewModels.Publication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.ViewModels.User
{
    public class UserVm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar un Nombre")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe colocar un Apellido")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Debe colocar un Email")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe colocar un No. de telefono")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Debe colocar Nombre de Usuario")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Debe colocar una Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string UserImg { get; set; }
        public string IsInactive { get; set; }





        #region Publicaciones
        public string Titulo { get; set; }
        public string PostImg { get; set; }        
        public DateTime Created { get; set; }
        #endregion

        #region Amigos
        public string FriendName { get; set; } //Friend
        #endregion


        //////
       public ICollection<PublicationVm> Publication { get; set; }
        public ICollection<FriendVm> Friend { get; set; }


    }
}
