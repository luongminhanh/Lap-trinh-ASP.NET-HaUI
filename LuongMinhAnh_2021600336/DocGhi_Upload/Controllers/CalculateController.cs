using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocGhi_Upload.Models;

namespace DocGhi_Upload.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Result(Tinh a)
        {
            if (a.ptinh == "+")
            {
                ViewBag.kq = a.soA + a.soB;
            }
            else if (a.ptinh == "-")
            {
                ViewBag.kq = a.soA - a.soB;
            }
            else if (a.ptinh == "*")
            {
                ViewBag.kq = a.soA * a.soB;
            }
            else
            {
                if (a.soB == 0)
                {
                    ViewBag.kq = "Số b phải khác 0";
                }
                else ViewBag.kq = a.soA / a.soB;
            }
            return View();
        }
        public ActionResult ResultV2(FormCollection data)
        {
            double soA = Convert.ToDouble(data["soA"]);
            double soB = Convert.ToDouble(data["soB"]);
            string ptinh = data["ptinh"];
            if (ptinh == "+")
            {
                ViewBag.kq = soA + soB;
            }
            else if (ptinh == "-")
            {
                ViewBag.kq = soA - soB;
            }
            else if (ptinh == "*")
            {
                ViewBag.kq = soA * soB;
            }
            else
            {
                if (soB == 0)
                {
                    ViewBag.kq = "Số b phải khác 0";
                }
                else ViewBag.kq = soA / soB;
            }
            return View();
        }
    }
}