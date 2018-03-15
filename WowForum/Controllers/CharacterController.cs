using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WowForum.Models;
using WowForum.Models.APIReturnModels;

namespace WowForum.Controllers
{
    public class CharacterController : BaseController
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

            SharedSession["WoWCharacterInfo"] = model;

            return View("CharacterDisplay", model);

        }
    }
}