using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WowForum.Models.LoginModels
{
    public class StoredUser
    {

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Faction { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }

        public string Class { get; set; }

    }
}