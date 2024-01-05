using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test2.Models;

namespace Test2.Controllers
{
    public class Cau6Controller : Controller
    {
        ModelDB db = new ModelDB();
        // GET: Cau6
        public ActionResult Index(string sortOrder)
        {
            ViewBag.BacluongSortParam = sortOrder;

            var workers = db.CongNhans.ToList();

            switch (sortOrder)
            {
                case "asc":
                    workers = workers.OrderBy(w => w.Bacluong, StringComparer.OrdinalIgnoreCase).ToList();
                    ViewBag.BacluongSortParam = "desc";
                    break;
                case "desc":
                    workers = workers.OrderByDescending(w => w.Bacluong, StringComparer.OrdinalIgnoreCase).ToList();
                    ViewBag.BacluongSortParam = "asc";
                    break;
                default:
                    workers = workers.OrderByDescending(w => w.Bacluong, StringComparer.OrdinalIgnoreCase).ToList();
                    ViewBag.BacluongSortParam = "asc";
                    break;
            }
            return View(workers);
        }
        public ActionResult Them()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Them(FormCollection f, CongNhan nv, string sortOrder)
        {
            try
            {
                var ma = f["Macn"];
                var ten = f["Hoten"];
                var bac = f["BacLuong"];
                var donvi = f["Donvi"];
                var existingWorker = db.CongNhans.FirstOrDefault(w => w.Macn == ma);
                if (existingWorker != null)
                {
                    ViewData["Loi5"] = "Mã công nhân đã tồn tại.";
                }
                if (String.IsNullOrEmpty(ma))
                {
                    ViewData["Loi1"] = "mã công nhân không đc trống";
                }
                else if (String.IsNullOrEmpty(ten))
                {
                    ViewData["Loi2"] = "tên công nhân không đc trống";
                }
                else if (String.IsNullOrEmpty(bac))
                {
                    ViewData["Loi3"] = "lương công nhân không đc trống";
                }
                else if (String.IsNullOrEmpty(donvi))
                {
                    ViewData["Loi4"] = "đơn vị công nhân không đc trống";
                }
                else
                {
                    nv.Macn = ma;
                    nv.Hoten = ten;
                    nv.Donvi = donvi;
                    nv.Bacluong = bac;
                    db.CongNhans.Add(nv);
                    db.SaveChanges();
                    return RedirectToAction("Index", new { sortOrder });
                }
                return this.Them();
            }
            catch (Exception e)
            {
                ViewData["Loi5"] = "Thêm ko thành công trùng mã";

                // Log or handle the error messages as needed.
                // You can also add the error messages to ViewData or ModelState to display them in the view.

                return this.Them();
            }
        }
    }
}