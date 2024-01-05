using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Web;
using System.Web.Mvc;
using OnTX2_6.Models;

namespace OnTX2_6.Controllers
{
    public class NhanViensController : Controller
    {
        private QLNhanVienDB db = new QLNhanVienDB();

        // GET: NhanViens
        public ActionResult Index(string sort)
        {
            var query = db.NhanViens.Select(p => p);
            ViewBag.sort = (String.IsNullOrEmpty(sort)) ? "ten_desc" : "";
            switch (sort)
            {
                case "ten_desc":
                    query = db.NhanViens.OrderByDescending(p => p.Hoten);
                    break;
                default:
                    query = db.NhanViens.OrderBy(p => p.Hoten);
                    break;
            }
            if (Request["first"] != null)
            {
                var first = Convert.ToDouble(Request["first"]);
                var last = Convert.ToDouble(Request["last"]);
                query = db.NhanViens.Where(p => p.Luong >= first && p.Luong <= last);
                var tong = db.NhanViens.Where(p => p.Luong >= first && p.Luong <= last).Sum(p=>p.Luong);
                ViewBag.tong = tong;
            }
            return View(query.ToList());
        }

        // GET: NhanViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // GET: NhanViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Manv,Hoten,Maphong,Luong")] NhanVien nhanVien)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (db.NhanViens.Any(p => p.Manv == nhanVien.Manv))
                    {
                        ViewBag.Error = "Mã nhân viên bị trùng";
                        return View(nhanVien);
                    }
                    db.NhanViens.Add(nhanVien);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(nhanVien);
            }
            catch (Exception e)
            {
                ViewBag.Error = "Có lỗi xảy ra " + e.Message; return View(nhanVien);
            }
        }

        // GET: NhanViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Manv,Hoten,Maphong,Luong")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhanVien);
        }

        // GET: NhanViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = db.NhanViens.Find(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NhanVien nhanVien = db.NhanViens.Find(id);
            db.NhanViens.Remove(nhanVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
