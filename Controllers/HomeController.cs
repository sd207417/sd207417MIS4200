using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sd207417MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A Little About Me";

            return View("");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here are a few ways to get ahold of me.";

            return View();
        }
    }
}