using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class TinhToanController : Controller
    {
        // GET: TinhToan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tinh()
        {
            double a = Convert.ToDouble(Request["soA"]);
            double b = Convert.ToDouble(Request["soB"]);
            if (Request["cong"] != null) 
                ViewBag.kq = a + b;
            else if (Request["tru"] != null)
                ViewBag.kq = a - b;
            else if (Request["nhan"] != null)
                ViewBag.kq = a * b;
            else if (Request["chia"] != null)
                ViewBag.kq = a / b;
            return View();
        }
    }
}