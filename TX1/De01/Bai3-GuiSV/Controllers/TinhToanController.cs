using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3_GuiSV.Models;

namespace Bai3_GuiSV.Controllers
{
    public class TinhToanController : Controller
    {
        // GET: TinhToan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XuLy(string ptinh="", int soA = 0, int soB = 0)
        {
            switch (ptinh)
            {
                case "cong":
                    ViewBag.kq = soA + soB;
                    break;
                case "tru":
                    ViewBag.kq = soA - soB;
                    break;
                case "nhan":
                    ViewBag.kq = soA * soB;
                    break;
                case "chia":
                    ViewBag.kq = soA / soB;
                    break;
            }
            return View();
        }
    }
}