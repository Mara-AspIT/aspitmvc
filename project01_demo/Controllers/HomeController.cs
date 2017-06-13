using project01_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project01_demo.Controllers
{
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("~/people/{antal:int}")]
        public ActionResult Index(int? antal, string id, Person p)
        {
            //Request.QueryString["antal"]
            PersonRepository r = new PersonRepository();
            var people = r.GetAll(antal);
            var vr = View(people);
            return vr;
        }

        [Route("~/test")]
        public ActionResult Test()
        {
            PersonRepository r = new PersonRepository();
            var people = r.GetAll(5);
            return View(people);
        }


        [Route("~/test2")]
        [HttpGet]
        public ActionResult Test2()
        {
            PersonRepository r = new PersonRepository();
            var people = r.GetAll(1);
            return View(people[0]);
        }

        [Route("~/test2")]
        [HttpPost]
        public ActionResult Test2(Person p)
        {
            return View(p);
        }


    }
}