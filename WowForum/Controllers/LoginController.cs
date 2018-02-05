using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WowForum.Models;
using WowForum.SQLDAL;

namespace WowForum.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult LoginForm()
        {
            LoginViewModel model = new LoginViewModel();

            return View("LoginForm", model);
        }

        public ActionResult CreateUser(NewUserModel userInfo)
        {

            IUserDAL userDAL = new UserDAL();
            var currentUser = userDAL.GetUser(userInfo.Username, userInfo.Password);

            if(currentUser != null)
            {
                return View("TempPage");
            }


            userDAL.CreateUser(userInfo);


            return View("TempPage");

        }

        public ActionResult NewUserForm()
        {
            NewUserModel model = new NewUserModel();

            return View("NewUserForm", model);
        }
    }
}