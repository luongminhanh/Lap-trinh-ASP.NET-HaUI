using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3_GuiSV.Models;

namespace Bai3_GuiSV.Controllers
{
    public class TienDienController : Controller
    {
        // GET: TienDien
        public ActionResult Index()
        {
            return View();
        }
        public static double tien = 0;
        //public ActionResult XuLy(FormCollection data)
        //{
        //    string ten = data["name"];
        //    int cu = int.Parse(data["cu"]);
        //    int moi = int.Parse(data["moi"]);
        //    string loai = data["loai"];
        //    int sodien = moi - cu;
        //    if (sodien <= 100) tien = sodien * 2000;
        //    else if (sodien <= 150) tien = (sodien - 100) * 2500 + 200000;
        //    else if (sodien <= 200) tien = 200000 + 50 * 2500 + (sodien - 150) * 3000;
        //    else tien = (sodien - 200) * 4000 + 200000 + 50 * 2500 + 50 * 3000 * 50;
        //    switch(loai) {
        //        case "Kinh doanh":
        //            tien *= 1.2;
        //            break;
        //        case "Sản xuất":
        //            tien *= 1.3;
        //            break;
        //        default:
        //            break;
        //    }
        //    if (data.AllKeys.Contains("uutien")) tien *= 0.9;
        //    ViewBag.tien = tien;
        //    ViewBag.ten = ten;
        //    ViewBag.sodien = sodien;
        //    return View();
        //}

        public ActionResult XuLy(TienDien s)
        {
            ViewBag.ten = s.name;
            ViewBag.sodien = (s.moi - s.cu).ToString();
            return View();
        }
    }
}