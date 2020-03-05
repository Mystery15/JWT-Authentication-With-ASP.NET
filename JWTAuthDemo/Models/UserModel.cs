using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthDemo.Models
{
    public class UserModel
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string EmailAddress { set; get; }
    }
}
