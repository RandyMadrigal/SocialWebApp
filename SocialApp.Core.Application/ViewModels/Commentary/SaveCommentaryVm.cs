using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.ViewModels.Commentary
{
   public class SaveCommentaryVm
    {
        public int Id { get; set; }
        public int PublicationId { get; set; } //fk
        public string Comentario { get; set; }
        public string UserImg { get; set; }
    }
}
