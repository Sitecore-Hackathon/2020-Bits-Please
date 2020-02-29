using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oshyn.BitsPls.Project.HackathonSite.Controllers
{
    public class HomeController : SitecoreController
    {
        public override ActionResult Index()
        {
            return View();
        }
    }
}