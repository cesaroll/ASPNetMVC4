using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        
        [HttpGet]
        public ActionResult Search(string name = "Spanish")
        {
            var msg = Server.HtmlEncode(name);

            return Content(msg);
        }

        [HttpPost]
        public ActionResult Search(object cuisine)
        {

            return Json(new { name = "French", rank = "Top 10" });
        }
    }
}
