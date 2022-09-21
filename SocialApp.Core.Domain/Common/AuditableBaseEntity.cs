using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Domain.Common
{
    public class AuditableBaseEntity
    {
        public virtual int Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime Created { get; set; }
 
    }
}
