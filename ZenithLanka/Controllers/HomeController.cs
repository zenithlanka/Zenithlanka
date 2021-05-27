//using System;
using System.Web.Mvc;

namespace ZenithLanka.Controllers
{

    public class HomeController : Controller
    {

       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Contact()
        {
         
            return View();
        }



        [OutputCache(Duration = 172800, VaryByParam = "none")]
        public ActionResult ThankYou()
        {

            return View();
        }

        [OutputCache(Duration = 172800, VaryByParam = "none")]
        public ActionResult Error()
        {

            return View();
        }
    }
        
}