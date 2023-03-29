using Application_learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Application_learning.Controllers
{
    public class DoodleController : Controller
    {
        // GET: Doodle
        public ActionResult Index()
        {
            Class1 obj = new Class1();
            var summa = obj.Summa();
            ViewBag.summa = summa;
            return View();
        }
        public ActionResult Random()
        {
            var movie = new Class1() { Name = "Mersal" };
            return View(movie);
        }
    }
}