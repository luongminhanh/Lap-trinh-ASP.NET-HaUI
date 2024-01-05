using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2.Models;

namespace Bai2.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(NhanVien s)
        {

            return View(s);
        }
        public ActionResult Regis2(FormCollection f)
        {
            NhanVien nv = new NhanVien();
        
            return View("Regis", nv);
        }
    }
}