using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
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
        public ActionResult MyLink()
        {
            ViewBag.Message = "MyLink liên kết của tôi.";

            return View();
        }
        public ActionResult Display()
        {
            // return PartialView("_EmployeeDetail");
            // return new EmptyResult();
            // return Redirect("youtube.com");
            // return RedirectToAction("Welcome", "Haui");
            // return Json("HELLO", JsonRequestBehavior.AllowGet);
            // return Content("Hello world no view");
            // return new FilePathResult(@"e:\SLIDE-UNIT-3.HP5.pdf", "application/pdf");
            return File(@"e:\SLIDE-UNIT-3.HP5.pdf", "application/pdf");
        }
        public ActionResult EditEmployee(int id)
        {
            return Content("<h1>id=" + id + "</h1>");
        }
        public ActionResult EditEmployeeV2(int empid)
        {
            return Content("<h1>empid=" + empid + "</h1>");
        }
        public ActionResult DemoParameter(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content("pageIndex=" + pageIndex + "&sortBy=" + sortBy);
        }
    }
}