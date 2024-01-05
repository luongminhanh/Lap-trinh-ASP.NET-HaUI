using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai2.Models;
using System.IO;

namespace Bai2.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(Staff s) 
        {
            try
            {
                var image = Request.Files["myFileImage"];
                string FileName = Path.GetFileName(image.FileName);
                var imagePath = Server.MapPath("~/Images/" + FileName);
                image.SaveAs(imagePath);
                string path = Server.MapPath("~/Staffinfo.txt");
                string[] info = { s.txtID.ToString(), s.txtName, s.txtDate.ToString(), s.txtSalary.ToString(), FileName };
                System.IO.File.WriteAllLines(path, info);
                return View("Index");
            }
            catch(Exception err)
            {
                string error = err.Message;
                ViewBag.error = error;
                return View("Index");
            }
        }
        public ActionResult Open(Staff s)
        {
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            ViewBag.id = int.Parse(info[0]);
            ViewBag.name = info[1];
            ViewBag.birthday = DateTime.Parse(info[2]).ToString("yyyy-MM-dd");
            ViewBag.salary = decimal.Parse(info[3]);
            ViewBag.image = "../../Images/" + info[4];
            return View("Index");
        }
    }
}