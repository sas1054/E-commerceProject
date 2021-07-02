using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace RookieShop.Backend.Models
{
    public class User: IdentityUser
    {
        public User() : base()
        {
        }

        public User(string userName) : base(userName)
        {
        }

        [PersonalData]
        public string FullName { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();
    }
}
