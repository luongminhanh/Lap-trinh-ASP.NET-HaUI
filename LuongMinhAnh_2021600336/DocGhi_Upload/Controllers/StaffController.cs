using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DocGhi_Upload.Models;
using System.IO;

namespace DocGhi_Upload.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Save(Staff a)
        //{
        //    try
        //    {
        //        var fhinh = Request.Files["myfileImage"];
        //        string _FileName = Path.GetFileName(fhinh.FileName);
        //        var pathhinh = Server.MapPath("~/Images" + _FileName);
        //        fhinh.SaveAs(pathhinh);
        //        string path = Server.MapPath("~/Staffinfo.txt");
        //        string[] info =
        //        {
        //        a.txtId.ToString(), a.txtName, a.txtDate.ToString(), a.txtSalary.ToString(), _FileName
        //    };
        //        System.IO.File.WriteAllLines(path, info);                
        //        ViewBag.message = "Đã lưu thành công!";
        //        return View("Index");
        //    }
        //    catch (Exception err)
        //    {
        //        ViewBag.message = "Đã lưu thất bại! Lỗi " + err.Message;
        //        return View("Index");
        //    }
        //}

        //public ActionResult Open(Staff a)
        //{
        //    string path = Server.MapPath("~/Staffinfo.txt");
        //    string[] info = System.IO.File.ReadAllLines(path);
        //    a.txtId = int.Parse(info[0]);
        //    a.txtName = info[1];
        //    a.txtDate = DateTime.Parse(info[2]);
        //    a.txtSalary = decimal.Parse(info[3]);
        //    a._FileName = info[4];
        //    ViewBag.id = a.txtId;
        //    ViewBag.name = a.txtName;
        //    ViewBag.salary = a.txtSalary;
        //    ViewBag.birthday = a.txtDate.ToString("yyyy-MM-dd");
        //    ViewBag.image = "../../Images/" + a._FileName;
        //    return View("Index");
        //}

        public ActionResult SaveV2(FormCollection data)
        {
            try {
                var fhinh = Request.Files["myfileImage"];
                string _FileName = Path.GetFileName(fhinh.FileName);
                var pathhinh = Server.MapPath("~/Images" + _FileName);
                fhinh.SaveAs(pathhinh);
                string path = Server.MapPath("~/Staffinfo.txt");
                string[] info = {
                data["txtId"], data["txtName"], data["txtDate"], data["txtSalary"], _FileName
            }; 
            System.IO.File.WriteAllLines(path, info);
            ViewBag.message = "Đã lưu thành công!";
            return View("Index");
            }
            catch (Exception err)
            {
                ViewBag.message = "Đã lưu thất bại! Lỗi " + err.Message;
                return View("Index");
            }
        }
        public ActionResult OpenV2()
        {
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);
            ViewBag.id = info[0];
            ViewBag.name = info[1];
            ViewBag.salary = info[3];
            ViewBag.birthday = info[2];
            ViewBag.image = "../../Images/" + info[4];
            return View("Index");
        }
    }
}