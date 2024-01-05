using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnTX1.Models;

namespace OnTX1.Controllers
{
    public class EmpsController : Controller
    {
        List<Emps> li = new List<Emps>();
        List<Emps> li1 = new List<Emps>();
        List<Emps> li2 = new List<Emps>();

        public EmpsController() {
            li.Add(new Emps("Nguyễn", "A", "Nữ", "2002", "2", "Music", 300, 300));
            li.Add(new Emps("Nguyễn", "b", "Nữ", "2002", "2", "Music", 1290, 23));
            li.Add(new Emps("Nguyễn", "c", "Nam", "2002", "2", "Music", 1290, 23));
            li.Add(new Emps("Nguyễn", "d", "Nam", "2002", "2", "Music", 1290, 23));
            li.Add(new Emps("Nguyễn", "e", "Nữ", "2002", "2", "Music", 1290, 23));
            li.Add(new Emps("Nguyễn", "f", "Nam", "2002", "2", "Music", 1290, 23));
        }
        public ActionResult XuatList()
        {
            foreach(var item in li)
            {
                if (item.salary > 300)
                {
                    li1.Add(item);
                }
                if (item.gender == "Nam")
                {
                    li2.Add(item);
                }                
            }
            ViewBag.li1 = li1;
            ViewBag.li2 = li2;
            return View();
        }
        // GET: Emps
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Nhap(Emps nv)
        {
            ViewBag.firstname = nv.firstname;
            ViewBag.firstname = nv.firstname;
            ViewBag.gender = nv.gender; 
            ViewBag.year = nv.year; 
            ViewBag.month = nv.month; 
            ViewBag.hobby = nv.hobby;
            ViewBag.salary = nv.salary;
            ViewBag.number = nv.number;
            ViewBag.luongthuc = nv.luongthuc;
            return View();
        }
        public ActionResult Xuat(Emps nv)
        {
            ViewBag.firstname = nv.firstname;
            ViewBag.firstname = nv.firstname;
            ViewBag.gender = nv.gender;
            ViewBag.year = nv.year;
            ViewBag.month = nv.month;
            ViewBag.hobby = nv.hobby;
            ViewBag.salary = nv.salary;
            ViewBag.number = nv.number;
            ViewBag.luongthuc = nv.luongthuc;
            return View();
        }
    }
}