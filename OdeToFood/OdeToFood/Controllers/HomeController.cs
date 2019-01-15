using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = $"{RouteData.Values["controller"]}::{RouteData.Values["action"]} {RouteData.Values["id"]}";

            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();

            model.Name = "Cesar";
            model.Location = "Texas, USA";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
