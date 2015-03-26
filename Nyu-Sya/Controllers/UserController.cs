using Nyu_Sya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nyu_Sya.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // GET: Enquete
        [HttpGet]
        public ActionResult Enquete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Enquete(EnqueteViewModel model)
        {
            return View("EnqueteResult", model);
        }

        public ActionResult Download()
        {
            return View();
        }

        public ActionResult Portal()
        {
            return View();
        }
    }
}