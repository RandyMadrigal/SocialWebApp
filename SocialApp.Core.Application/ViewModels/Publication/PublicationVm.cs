using SocialApp.Core.Application.ViewModels.Commentary;
using SocialApp.Core.Application.ViewModels.Friend;
using SocialApp.Core.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SocialApp.Core.Application.ViewModels.Publication
{
    public class PublicationVm
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe colocar un titulo para esta publicacion.")]
        [DataType(DataType.Text)]
        public string Titulo { get; set; }
        public string PostImg { get; set; }
        public int QuantityPost { get; set; }
        public DateTime Created { get; set; }
                
        public string Comentario { get; set; }

        public string UserName { get; set; }
        public string UserImg { get; set; }

        public int UserId { get; set; } //Fk

        public UserVm User { get; set; }
        public ICollection<CommentaryVm> commentaries { get; set; }
    }
}
