using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WowForum.Models;
using WowForum.Models.APIReturnModels;

namespace WowForum.Controllers
{
    public class CharacterController : Controller
    {
        public ActionResult CharacterForm()
        {
            CharacterInformationModel model = new CharacterInformationModel();

            return View("CharacterForm", model);
        }

        public ActionResult GetCharacter(CharacterInformationModel characterInfo)
        {
            APIController API = new APIController();
            CharacterInfoAPIModel model = new CharacterInfoAPIModel();
            model = API.GetCharacter(characterInfo);
            if(model == null)
            {
                TempData["Error"] = "Character not found";
                return RedirectToAction("CharacterForm");
            }
            model.GetCharacterRecode();

            Session["name"] = model.name;
            Session["realm"] = model.realm;
            Session["faction"] = model.recodedFaction;
            Session["race"] = model.recodedRace;
            Session["gender"] = model.recodedGender;
            Session["class"] = model.recodedClass;
            Session["thumbnail"] = model.recodedThumbnail;


            return View("CharacterDisplay", model);

        }
    }
}