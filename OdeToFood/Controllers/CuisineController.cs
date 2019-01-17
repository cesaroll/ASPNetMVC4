using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{ 
    //[Authorize]
    public class CuisineController : Controller
    {
        
        public ActionResult Search(string name = "Spanish")
        { 
            throw new Exception("Something terrible has happened");

            var msg = Server.HtmlEncode(name);

            return Content(msg);
        }
        
    }
}
