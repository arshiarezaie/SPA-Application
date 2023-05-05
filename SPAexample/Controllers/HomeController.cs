using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;

namespace SPAexample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult list()
        {
            return PartialView();
        }

        public ActionResult Add()
        {
            return PartialView();
        }

        public ActionResult Edit(int Id)
        {
            return PartialView(Id);
        }

        public ActionResult Information()
        {
            return PartialView();
        }

        public  ActionResult AboutMe()
        {
            return PartialView();
        }

        public ActionResult ConnectMe()
        {
            return PartialView();
        }
    }
}