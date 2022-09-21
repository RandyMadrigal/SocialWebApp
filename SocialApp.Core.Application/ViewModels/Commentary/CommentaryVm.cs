using SocialApp.Core.Application.ViewModels.Publication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.ViewModels.Commentary
{
    public class CommentaryVm
    {
        public int Id { get; set; }
        public int PublicationId { get; set; } //fk

        [Required(ErrorMessage = "Debe colocar Nombre de Usuario")]
        [DataType(DataType.Text)]
        public string Comentario { get; set; }
        public string UserImg { get; set; }

        public PublicationVm _publication { get; set; }
    }
}
