using Microsoft.AspNetCore.Http;
using SocialApp.Core.Application.ViewModels.Commentary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.ViewModels.Publication
{
    public class SavePublicationVm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar un titulo para esta publicacion.")]
        [DataType(DataType.Text)]
        public string Titulo { get; set; }
        public string PostImg { get; set; }
        public DateTime Created { get; set; }

        public int UserId { get; set; }

        //Subida de archivos -IFormFile
        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }

        public string Comentario { get; set; }



    }

}
