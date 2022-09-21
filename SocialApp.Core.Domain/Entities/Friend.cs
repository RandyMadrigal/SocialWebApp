using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Domain.Entities
{
    public class Friend
    {

        public int Id { get; set; }        
        public int UserId { get; set; } //Yo
        public string UserName { get; set; } //yo
        public int FriendId { get; set; } //friend- //Foreign key
        public string FriendName { get; set; } //Friend

        
        //Navigation Property
        public User User { get; set; }
        

    }
}