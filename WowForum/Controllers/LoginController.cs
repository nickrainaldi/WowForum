using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WowForum.Models;
using WowForum.Models.APIReturnModels;
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

        public ActionResult LoginUser(LoginViewModel loginViewModel)
        {
            IUserDAL userDAL = new UserDAL();
            userDAL.GetUser(loginViewModel.username, loginViewModel.password);

            Session["username"] = loginViewModel.username;

            return View("TempPage");
        }

        public ActionResult CreateUser(NewUserModel userInfo)
        {

            IUserDAL userDAL = new UserDAL();
            var currentUser = userDAL.GetUser(userInfo.Username, userInfo.Password);

            if(currentUser != null)
            {
                return View("TempPage");
            }

            if(Session["WoWCharacterInfo"] != null)
            {
                CharacterInfoAPIModel characterInfo = (CharacterInfoAPIModel)Session["CharacterModelReturn"];
                userDAL.CreateUserWithChar(userInfo, characterInfo);
            }
            else
            {
                userDAL.CreateUserNoChar(userInfo);
            }

            Session["username"] = userInfo.Username;

            return View("TempPage");

        }

        public ActionResult NewUserForm()
        {
            NewUserModel model = new NewUserModel();

            return View("NewUserForm", model);
        }
    }
}