using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai3_GuiSV.Models;

namespace Bai3_GuiSV.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(SinhVien sv)
        {
            sv.Id = "SV001";
            sv.Name = "Nguyễn Anh Tuấn";
            sv.Marks = 10;
            return View(sv);
        }
        //Request
        //public ActionResult XuLy()
        //{
        //    ViewBag.id = Request["Id"];
        //    ViewBag.name = Request["Name"];
        //    ViewBag.marks = Request["Marks"];
        //    return View();
        //}

        //FormCollection
        //public ActionResult XuLy(FormCollection data)
        //{
        //    ViewBag.id = data["Id"];
        //    ViewBag.name = data["Name"];
        //    ViewBag.marks = data["Marks"];
        //    return View();
        //}

        //Tham số của Action
        //public ActionResult XuLy(string Id="", string Name="", string Marks="")
        //{
        //    ViewBag.id = Id;
        //    ViewBag.name = Name;
        //    ViewBag.marks = Marks;
        //    return View();
        //}

        //Models
        public ActionResult XuLy(SinhVien sv, SinhVien k)
        {
            k.Id = sv.Id;
            k.Name = sv.Name;
            k.Marks = sv.Marks;
            return View(k);
        }
    }
}