using SocialApp.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Domain.Entities
{
    public class Commentary : AuditableBaseEntity
    {
        
        public int PublicationId { get; set; } //fk
        public string Comentario { get; set; }
        public string UserImg { get; set; }
        //Navigation Propertys
        public Publication _publication { get; set; } 

    }
}
