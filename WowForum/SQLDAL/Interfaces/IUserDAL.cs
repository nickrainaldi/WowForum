using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WowForum.Models;
using WowForum.Models.APIReturnModels;
using WowForum.Models.LoginModels;

namespace WowForum.SQLDAL
{
    public interface IUserDAL
    {
        void CreateUserNoChar(NewUserModel newUser);
        void CreateUserWithChar(NewUserModel newUser, CharacterInfoAPIModel characterInfo);
        StoredUser GetUser(string username, string password);
    }
}