using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai4_ViDu_HKH.Models;

namespace Bai4_ViDu_HKH.Controllers
{
    public class EmployeeManagementController : Controller
    {
        // GET: EmployeeManagement
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalSalaryV1()
        {
            string id = Request["id"];
            string name = Request["name"];
            int amount = int.Parse(Request["amount"]);
            double salary = double.Parse(Request["salary"]);
            Employee e = new Employee(id, name, amount, salary);
            return View(e);
        }
        [HttpPost]
        public ActionResult CalSalaryV2(Employee e)
        {
            return View("CalSalaryV1", e);
        }
        [HttpPost]
        public ActionResult CalSalaryv4(FormCollection form)
        {
            Employee e = new Employee();
            e.id = form["id"];
            e.name = form["name"];
            e.amount = int.Parse(form["amount"]);
            e.salary = double.Parse(form["salary"]);
            return View("CalSalaryV1", e);
        }
    }
}