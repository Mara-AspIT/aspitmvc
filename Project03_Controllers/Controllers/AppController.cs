using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project03_Controllers.Controllers
{
    public class AppController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            //return View();

            //ContentResult c = new ContentResult();
            //c.Content = "<h1>Test</h1>";
            ////return Content("<h1>Test</h1>");
            //return c;

            //HttpStatusCodeResult h = new HttpStatusCodeResult(500, "FEJL FEJL");
            //return h;

            var lst = new PersonNuGetPackage.PersonRepositoryRandom().GetPeople(15);
            //return Json(lst, JsonRequestBehavior.AllowGet);

            //return Redirect("http://www.google.dk");


            ViewBag.time = DateTime.Now.ToLongTimeString();
            ViewBag.people = lst; 

            return View();

        }
    }
}