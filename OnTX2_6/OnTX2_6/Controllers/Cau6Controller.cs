using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnTX2_6.Models;

namespace OnTX2_6.Controllers
{
    public class Cau6Controller : Controller
    {
        // GET: Cau6
        QLNhanVienDB db = new QLNhanVienDB();
        public ActionResult Index()
        {
            var query = db.NhanViens.Select(p => p);
            return View(query);
        }
        public ActionResult Them()
        {
            ViewData["Phong"] = new SelectList(db.Phongs, "Maphong", "Tenphong");
            return View();
        }
        [HttpPost]
        public ActionResult Them(FormCollection f, NhanVien nv)
        {
            var ma = f["Manv"];
            var ten = f["Hoten"];
            var phong = f["Phong"];
            var luong = f["Luong"];
            var isExist = db.NhanViens.Any(p => p.Manv == ma);
            if (String.IsNullOrEmpty(ma))
            {
                ViewData["Loi1"] = "Thiếu mã nhân viên";
            }
            else if (String.IsNullOrEmpty(ten))
            {
                ViewData["Loi2"] = "Thiếu mã nhân viên";
            }
            else if (String.IsNullOrEmpty(phong))
            {
                ViewData["Loi3"] = "Thiếu mã nhân viên";
            }
            else if (String.IsNullOrEmpty(luong))
            {
                ViewData["Loi4"] = "Thiếu mã nhân viên";
            }
            else if (isExist)
            {
                ViewData["Loi5"] = "Mã nhân viên trùng";
            } else
            {
                nv.Manv = ma;
                nv.Maphong = phong;
                nv.Luong = Convert.ToDouble(luong);
                nv.Hoten = ten;
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Them();
        }
        public ActionResult Sua(string id)
        {
            ViewData["Phong"] = new SelectList(db.Phongs, "Maphong", "Tenphong");
            var query = db.NhanViens.First(p => p.Manv == id);
            return View(query);
        }
        [HttpPost]
        public ActionResult Sua(FormCollection f, NhanVien nv)
        {
            var ma = f["Manv"];
            var ten = f["Hoten"];
            var phong = f["Phong"];
            var luong = f["Luong"];
            
            if (String.IsNullOrEmpty(ten))
            {
                ViewData["Loi2"] = "Thiếu mã nhân viên";
            }
            else if (String.IsNullOrEmpty(phong))
            {
                ViewData["Loi3"] = "Thiếu mã nhân viên";
            }
            else if (String.IsNullOrEmpty(luong))
            {
                ViewData["Loi4"] = "Thiếu mã nhân viên";
            }
            else
            {
                nv = db.NhanViens.First(p => p.Manv == ma);
                nv.Maphong = phong;
                nv.Luong = Convert.ToDouble(luong);
                nv.Hoten = ten;
                UpdateModel(nv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return this.Sua(ma);
        }
    }
}