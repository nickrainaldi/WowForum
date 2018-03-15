using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WowForum.Controllers
{
    public class BaseController : Controller
    {
        /// A session object that can/will be shared between all controllers that inherit from
        /// this base.

        public System.Web.SessionState.HttpSessionState SharedSession
        {
            get
            {
                return System.Web.HttpContext.Current.Session;
            }
        }

    }
}