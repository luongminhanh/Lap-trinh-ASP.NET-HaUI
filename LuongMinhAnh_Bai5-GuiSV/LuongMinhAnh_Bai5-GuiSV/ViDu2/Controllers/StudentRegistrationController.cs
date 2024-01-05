using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViDu2.Models;

namespace ViDu2.Controllers
{
    public class StudentRegistrationController : Controller
    {
        // GET: StudentRegistration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(Student s)
        {

            return View(s);
        }
        public ActionResult Regis2(FormCollection f)
        {
            Student s = new Student();
            s.name = f["name"];
            s.gender = f["gender"];
            s.addr = f["addr"];
            s.email = f["email"];
            string temp = "";
            if (f["Java Core"] == "true,false")
            {
                temp = "Java Core";
            }
            if (f["Sql Server"] == "true,false")
            {
                temp += " " + "Sql Server";
            }
            if (f["PHP"] == "true,false")
            {
                temp += " " + "PHP";
            }
            s.subject = temp;
            s.username = f["username"];
            s.password = f["password"];
            s.comment = f["comment"];
            return View("Regis", s);
        }
    }
}