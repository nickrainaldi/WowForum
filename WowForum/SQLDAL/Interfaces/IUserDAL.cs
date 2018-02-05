using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WowForum.Models;
using WowForum.Models.LoginModels;

namespace WowForum.SQLDAL
{
    public interface IUserDAL
    {
        void CreateUser(NewUserModel newUser);
        StoredUser GetUser(string username, string password);
    }
}