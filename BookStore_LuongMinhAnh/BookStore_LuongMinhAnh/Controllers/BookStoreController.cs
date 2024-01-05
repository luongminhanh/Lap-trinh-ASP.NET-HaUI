using BookStore_LuongMinhAnh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore_LuongMinhAnh.Controllers
{
    public class BookStoreController : Controller
    {
        QLBanSachDB db = new QLBanSachDB(); 
        private List<SACH> Laysachmoi(int count)
        {
            return db.SACHes.OrderByDescending(a => a.Ngaycapnhat).Take(count).ToList();
        }
        // GET: BookStore
        public ActionResult Index()
        {
            var sachmoi = Laysachmoi(5);
            return View(sachmoi);
        }
        public ActionResult Details(int id)
        {
            var sach = from s in db.SACHes
                       where s.Masach == id
                       select s;
            return View(sach.Single());
        }
    }
}