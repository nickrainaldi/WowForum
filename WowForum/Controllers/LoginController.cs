using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WowForum.Models;

namespace WowForum.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult LoginForm()
        {
            LoginViewModel model = new LoginViewModel();

            return View("LoginForm", model);
        }

        //public ActionResult GetUser(LoginViewModel userInfo)
        //{
        //    APIController API = new APIController();
        //    CharacterInfoAPIModel model = new CharacterInfoAPIModel();
        //    model = API.GetCharacter(characterInfo);
        //    model.GetCharacterRecode();

        //    Session["name"] = model.name;
        //    Session["realm"] = model.realm;
        //    Session["faction"] = model.recodedFaction;
        //    Session["race"] = model.recodedRace;
        //    Session["gender"] = model.recodedGender;
        //    Session["class"] = model.recodedClass;
        //    Session["thumbnail"] = model.recodedThumbnail;


        //    return View("CharacterDisplay", model);

        //}

        public ActionResult NewUserForm()
        {
            NewUserModel model = new NewUserModel();

            return View("NewUserForm", model);
        }
    }
}