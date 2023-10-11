using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Đây là phương thức Index() phương thức mặc định của controller hello";
        //}
        //public string ChaoMung(string ten, int id=1)
        //{
        //    return "Xin chào "+ten+", số lần là: "+id;
        //}
    }
}