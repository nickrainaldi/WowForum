﻿using System;
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

        public ActionResult GetUser(NewUserModel userInfo)
        {

            IUserDAL userDAL = new UserDAL();
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