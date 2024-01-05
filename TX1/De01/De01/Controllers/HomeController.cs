using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using De01.Models;

namespace De01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cau1()
        {
            return View();
        }
        public ActionResult Cau2()
        {
            return View();
        }
        public ActionResult KetQua(Hang s)
        {
            return View(s);
        }
    }
}