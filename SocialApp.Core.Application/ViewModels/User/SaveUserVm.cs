using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.ViewModels.User
{
    public class SaveUserVm
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
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Debe colocar Nombre de Usuario")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Debe colocar una Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coinciden")]
        [Required(ErrorMessage = "Debe colocar una Contraseña")]
        [DataType(DataType.Password)]
        public string ConfirnmPassword { get; set; }

        public string UserImg { get; set; }

        public string IsInactive { get; set; }



        //Subida de archivos -IFormFile
        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }

    }
}
