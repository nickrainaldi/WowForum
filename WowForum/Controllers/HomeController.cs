using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WowForum.Models;
using WowForum.Models.APIReturnModels;

namespace WowForum.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            return View("Index");
        }

        [HttpGet]
        public ActionResult RegisterType()
        {
            return View("RegisterType");
        }

    }
}