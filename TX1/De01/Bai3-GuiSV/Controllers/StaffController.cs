using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3_GuiSV.Models;
using System.IO;

namespace Bai3_GuiSV.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Save(Staff s)
        //{
        //    try
        //    {
        //        var file = Request.Files["file"];
        //        string fileName = Path.GetFileName(file.FileName);
        //        var path = Server.MapPath("~/Images/" + fileName);
        //        file.SaveAs(path);
        //        string pathInfo = Server.MapPath("~/Staff.txt");
        //        string[] info = { s.id.ToString(), s.name.ToString(), s.birth.ToString(), s.salary.ToString(), fileName };
        //        System.IO.File.WriteAllLines(pathInfo, info);
        //        return View("Index");
        //    }
        //    catch (Exception err)
        //    {
        //        string error = err.Message;
        //        ViewBag.error = error;
        //        return View("Index");
        //    }
        //}
        //public ActionResult Open(Staff s)
        //{
        //    string path = Server.MapPath("~/Staff.txt");
        //    string[] info = System.IO.File.ReadAllLines(path);
        //    ViewBag.id = int.Parse(info[0]);
        //    ViewBag.name = info[1];
        //    ViewBag.salary = float.Parse(info[3]);
        //    ViewBag.birth = DateTime.Parse(info[2]).ToString("yyyy-MM-dd");
        //    ViewBag.image = "../../Images/" + info[4];
        //    return View("Index");
        //}
        public ActionResult Save(FormCollection form)
        {
            try
            {
                var file = Request.Files["file"];
                string fileName = Path.GetFileName(file.FileName);
                var path = Server.MapPath("~/Images/" + fileName);
                file.SaveAs(path);
                string pathInfo = Server.MapPath("~/Staff.txt");
                string[] info = { form["id"].ToString(), form["name"].ToString(), form["salary"].ToString(), form["birth"].ToString(), fileName };
                System.IO.File.WriteAllLines(pathInfo, info);
                return View("Index");
            }
            catch (Exception err)
            {
                ViewBag.error = err.Message;
                return View("Index");
            }
        }
        public ActionResult Open(FormCollection form)
        {
            string path = Server.MapPath("~/Staff.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            ViewBag.id = info[0];
            ViewBag.name = info[1];
            ViewBag.salary = info[2];
            ViewBag.birth = info[3];
            ViewBag.image = "../../Images/" + info[4];
            return View("Index");
        }
    }
}