using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WowForum.Models;
using WowForum.Models.APIReturnModels;

namespace WowForum.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CharacterInformationModel model = new CharacterInformationModel();

            return View("Index", model);
        }


        public ActionResult GetCharacter(CharacterInformationModel characterInfo)
        {
            APIController API = new APIController();
            CharacterInfoAPIModel model = new CharacterInfoAPIModel();
            model = API.GetCharacter(characterInfo);
            model.GetCharacterRecode();

            Session["name"] = model.name;
            Session["realm"] = model.realm;
            Session["faction"] = model.recodedFaction;
            Session["race"] = model.recodedRace;
            Session["gender"] = model.recodedGender;
            Session["class"] = model.recodedClass;


            return View("CharacterDisplay", model);

        }

        [HttpGet]
        public ActionResult NewUser()
        {
            return View("NewUser");
        }

        [HttpPost]
        //[Route("users/new")]
        public ActionResult NewUser(RegisterViewModel model)
        {


        }
    }

}