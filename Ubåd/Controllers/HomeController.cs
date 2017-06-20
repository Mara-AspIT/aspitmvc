using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ubåd.Controllers
{
    public class HomeController : Controller
    {
        Ubåd.Models.IUbådRepository r;


        public HomeController()
        {
            r = Ubåd.Models.UbådUnitOfWork.GetRepo();
        }

        public HomeController(Ubåd.Models.IUbådRepository rep)
        {
            r = rep;
        }


        public ActionResult Index(int? antal)
        {

            //var lst = r.HentAlle();
            List<Ubåd.Models.UBåd> lst;
            if (antal != null)
            {
                lst = r.HentNogle(antal.Value);
            }
            else
            {
                lst = r.HentAlle();
            }
            return View(lst);
        }

        public ActionResult Service()
        {

            var lst = r.HentAlle();
            return Json(lst, JsonRequestBehavior.AllowGet);


        }

    }

    class MockUnitTest {

        public void Test() {

            Ubåd.Controllers.HomeController c = 
                new HomeController(new Ubåd.Models.UBådRepositoryRandom());

            var r = c.Index(null);
            var v = r as ViewResult;
            var m = v.Model as List<Ubåd.Models.UBåd>;
            if (m.Count != 99) {
                // fejl....
            }
        }
    }

}