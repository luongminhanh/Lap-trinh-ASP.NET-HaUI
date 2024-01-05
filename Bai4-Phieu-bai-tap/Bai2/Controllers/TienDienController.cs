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
            ViewBag.tieuthu = int.Parse(Request["chisomoi"]) - int.Parse(Request["chisocu"]);
            int a = ViewBag.tieuthu;
            double money = 0;
            if (a <= 100) money = a * 2000;
            else if (100 < a && a <= 150) money = 200000 + (a - 100) * 2500;
            else if (150 < a && a <= 200) money = 200000 + 2500 * 50 + (a - 150) * 3000;
            else if (a > 200) money = 200000 + 2500 * 50 + 3000 * 50 + (a - 200) * 4000;
            if (Convert.ToBoolean(Request["uutien"].Split(',')[0]) == true)
                money *= 90/100;
            ViewBag.tiendien = money;
            return View();
        }
    }
}