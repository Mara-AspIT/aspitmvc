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

            return View(lst);

        }

        [Route("Test/{year}/{month}")]
        [HttpGet]
        public ActionResult Test(TestViewModel v) {
        //public ActionResult Test(int year, int month, string test, MyColor c)
 
            //return Content("Test");
            return View();
        }

        [Route("~/CacheTest")]
        [OutputCache(Duration = 1)]
        [HttpGet]
        public ActionResult CacheTest() {
            return View();
        }

        [Route("~/list")]
        public ActionResult List()
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                lst.Add(Guid.NewGuid().ToString()); 
            }
            return PartialView(lst);
        }

        [Route("~/listtest")]
        public ActionResult Listtest()
        {
            return View();
        }

        [Route("~/ajax1")]
        public ActionResult Ajax1()
        {
            return View();
        }

    }


    public enum MyColor // : Byte
    {
        Red,
        Blue,
        Yellow
    }
    public class TestViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOf { get; set; }
        public bool IsAdmin { get; set; }
    }
}