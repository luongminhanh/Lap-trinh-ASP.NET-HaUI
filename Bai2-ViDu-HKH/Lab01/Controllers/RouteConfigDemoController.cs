using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class RouteConfigDemoController : Controller
    {
        // GET: RouteConfigDemo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestParameter(string msg, int number)
        {
            string str = "";
            for (int i = 0; i<number; i++)
            {
                str = str + i + ". " + msg + "</br>";
            }
            return Content(str);
        }
        [Route("haui/testpara2/{msg}/{number}")]
        public ActionResult TestParameterV2(string msg, int number)
        {
            string str = "";
            for (int i = 0; i < number; i++)
            {
                str = str + i + ". " + msg + "</br>";
            }
            return Content(str);
        }
    }
}