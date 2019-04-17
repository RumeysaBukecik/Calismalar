using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCproje.Models;

namespace MVCproje.Controllers
{
    public class DefaultController : Controller
    {
        private BLOGEntities vt = new BLOGEntities();

        public ActionResult Index()
        {
            return View();
        }
    }
}