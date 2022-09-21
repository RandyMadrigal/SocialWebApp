using SocialApp.Core.Domain.Common;
using System.Collections.Generic;

namespace SocialApp.Core.Domain.Entities
{
    public class Publication : AuditableBaseEntity
    {

        public string Titulo { get; set; }
        public string PostImg { get; set; }

        #region User
        
        public int UserId { get; set; } //Foreign key

        public User User { get; set; } //Navigation Property
        #endregion


        public ICollection<Commentary> commentaries { get; set; } 
    }
}
