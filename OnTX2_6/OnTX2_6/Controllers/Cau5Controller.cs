using System;
using System.Linq;
using System.Web.Mvc;
using OnTX2_6.Models;

namespace OnTX2_6.Controllers
{
    public class Cau5Controller : Controller
    {
        private QLNhanVienDB db = new QLNhanVienDB();

        public ActionResult Index()
        {
            IQueryable<NhanVien> query = db.NhanViens.Select((NhanVien p) => p);
            return View(query);
        }

        public ActionResult Them()
        {
            base.ViewData["Phong"] = new SelectList(db.Phongs, "Maphong", "Tenphong");
            return View();
        }

        [HttpPost]
        public ActionResult Them(FormCollection f, NhanVien nv)
        {
            string ma = f["Manv"];
            string ten = f["Hoten"];
            string phong = f["Phong"];
            string luong = f["Luong"];
            bool isExist = db.NhanViens.Any((NhanVien p) => p.Manv == ma);
            if (string.IsNullOrEmpty(ma))
            {
                base.ViewData["Loi1"] = "Thiếu mã nhân viên";
            }
            else if (string.IsNullOrEmpty(ten))
            {
                base.ViewData["Loi2"] = "Thiếu mã nhân viên";
            }
            else if (string.IsNullOrEmpty(phong))
            {
                base.ViewData["Loi3"] = "Thiếu mã nhân viên";
            }
            else if (string.IsNullOrEmpty(luong))
            {
                base.ViewData["Loi4"] = "Thiếu mã nhân viên";
            }
            else
            {
                if (!isExist)
                {
                    nv.Manv = ma;
                    nv.Maphong = phong;
                    nv.Luong = Convert.ToDouble(luong);
                    nv.Hoten = ten;
                    db.NhanViens.Add(nv);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                base.ViewData["Loi5"] = "Mã nhân viên trùng";
            }
            return Them();
        }

        public ActionResult Sua(string id)
        {
            base.ViewData["Phong"] = new SelectList(db.Phongs, "Maphong", "Tenphong");
            NhanVien query = db.NhanViens.First((NhanVien p) => p.Manv == id);
            return View(query);
        }

        [HttpPost]
        public ActionResult Sua(FormCollection f, string id)
        {
            string ten = f["Hoten"];
            string phong = f["Phong"];
            string luong = f["Luong"];
            if (string.IsNullOrEmpty(ten))
            {
                base.ViewData["Loi2"] = "Thiếu mã nhân viên";
            }
            else if (string.IsNullOrEmpty(phong))
            {
                base.ViewData["Loi3"] = "Thiếu mã nhân viên";
            }
            else
            {
                if (!string.IsNullOrEmpty(luong))
                {
                    NhanVien nv = db.NhanViens.First(p => p.Manv == id);
                    nv.Maphong = phong;
                    nv.Luong = Convert.ToDouble(luong);
                    nv.Hoten = ten;
                    UpdateModel(nv);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                base.ViewData["Loi4"] = "Thiếu mã nhân viên";
            }
            return Sua(id);
        }
        public ActionResult Xoa(string id)
        {
            NhanVien query = db.NhanViens.First((NhanVien p) => p.Manv == id);
            return View(query);
        }
        [HttpPost]
        public ActionResult Xoa(string id, NhanVien nv)
        {
            nv = db.NhanViens.First((NhanVien p) => p.Manv == id);
            db.NhanViens.Remove(nv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}