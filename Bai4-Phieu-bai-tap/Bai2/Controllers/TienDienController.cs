using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class TienDienController : Controller
    {
        // GET: TienDien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tinh()
        {
            ViewBag.name = Request["name"];
            
            return View();
        }
    }
}