using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WowForum.Models;

namespace WowForum.SQLDAL
{
    public interface IUserDAL
    {
        void CreateUser(NewUserModel newUser);

    }
}