using Project04_Views.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project04_Views.Controllers
{
    public class AppController : Controller
    {
        
        [Route("~/")]
        [Route("homepage/{i:int:min(1):max(100)}")]
        [Route("company/about")]
        public ActionResult Index(int? i)
        {
            Person p = new Person() { Id = 1, Name = "God", IsGod = true };
            return View(p);
        }

        [Route("~/test")]
        public ActionResult Test()
        {
            return View();
        }

        [Route("{*q}")]
        public ActionResult ca(string q)
        {
            // gør noget ved q
            return View();
        }
        [Route("~/lp")]
        public ActionResult lp(string q)
        {
            return View();
        }



    }

}