using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using Using_Filters.Filter;

namespace Using_Filters.Controllers
{
    
    public class HomeController : Controller
    {
        [VijayAuthentication]
        public ActionResult Index()
        {
             return View();
        }
       /* public ActionResult Missing()
        {
            ViewBag.Message = "Your Error page.";

            return View();
        }*/


        [VijayAction]
        [OutputCache(Duration =10)]
        public ActionResult About()
        {
           
            ViewBag.Message = "Your application description page.";

            return View();
        }


       /* [HandleError]
        public ActionResult Contact()
        {
            throw new Exception("this is a Exception");
           // ViewBag.Message = "Your contact page.";

           // return View();
        }*/
      

        [OutputCache(Duration =20,Location =System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Inbuiltfilter()
        {
            ViewBag.Message = "Only 20s the page will be working";

            return View();
        }

        public ActionResult UseExceptionMethod()
        {
            return View("vijay");
        }
    }
}