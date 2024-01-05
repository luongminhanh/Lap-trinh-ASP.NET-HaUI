using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai1.Models;

namespace Bai1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Result(Tinh a)
        {
            if (a.pt == "+")
            {
                ViewBag.kq = a.soA + a.soB;
            }
            else if (a.pt == "-")
            {
                ViewBag.kq = a.soA - a.soB;
            }
            else if (a.pt == "*")
            {
                ViewBag.kq = a.soA * a.soB;
            }
            else if (a.pt == "/")
            {
                ViewBag.kq = a.soA / a.soB;
            }
            return View();
        }

        public ActionResult Result2(FormCollection data)
        {
            float a = float.Parse(data["soA"]);
            float b = float.Parse(data["soB"]);
            string pt = data["pt"];
            switch (pt)
            {
                case "+":
                    ViewBag.kq = a + b;
                    break;
                case "-":
                    ViewBag.kq = a - b;
                    break;
                case "*":
                    ViewBag.kq = a * b;
                    break;
                case "/":
                    ViewBag.kq = a / b;
                    break;
            }
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
    }
}