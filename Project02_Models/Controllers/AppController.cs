using Project02_Models.Models.Domain.EF;
using Project02_Models.Models.Domain.EF.Repository;
using Project02_Models.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project02_Models.Controllers
{
    public class AppController : Controller
    {
        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("~/PeopleMan")]
        public ActionResult PeopleMan()
        {
            var res = new PeopleRepository().GetAll();
            return View("People", res);            
        }

        [HttpGet]
        [Route("~/Login")]
        public ActionResult Login()
        {
            LoginViewModel l = new LoginViewModel();
            l.Remember = true;
            return View(l);
        }

        [HttpPost]
        [Route("~/Login")]
        public ActionResult Login(LoginViewModel m)
        {
            if (ModelState.IsValid)
            {
                if (m.Username == "XXXX" && m.Password == "XXXX")
                {
                    return RedirectToAction("index");
                }
                else
                {
                    return View(m);
                }
            }
            else
            {
                return View(m);
            }

        }
    }
}