using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Ajax._02.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetHello(string name)
        {
            List<string> data = new List<string>();
            data.Add((string.Format("{0} Xin chào {1} ", DateTime.Now.ToString(), name)));
            foreach (var item in name)
            {
                data.Add(item + " = " + ((int)item).ToString());
            }
            return Json(data);
        }

        [HttpPost]
        public ActionResult GetHtml()
        {
            return Json("<p>This is result <b>HTML</b></p>");
        }
    }
}