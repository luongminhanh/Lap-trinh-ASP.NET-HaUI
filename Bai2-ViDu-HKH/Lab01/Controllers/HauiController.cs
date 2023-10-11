using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HauiController : Controller
    {
        // GET: Haui
        public ActionResult Welcome()
        {
            return View();
        }
    }
}