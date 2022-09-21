using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }        
        public string Name { get; set; }        
        public string Apellido { get; set; }        
        public string Email { get; set; }       
        public string Phone { get; set; }        
        public string UserName { get; set; }      
        public string Password { get; set; }
        public string UserImg { get; set; }
        public string IsInactive { get; set; }
               

        //Navigation Property
        public ICollection<Publication> Publication { get; set; }
        public ICollection<Friend> Friend { get; set; }

    }
}
