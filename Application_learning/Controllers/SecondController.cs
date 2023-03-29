using Application_learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Mvc;

namespace Application_learning.Controllers
{
    public partial class SecondController : Controller
    {
        // GET: Second

        public ActionResult Duplicate()
        {
            ViewBag.Message = "vijay is hear";
            return View();
        }

       

        public ActionResult Course()
        {
            ViewBag.Message = "vijay is hear";
            Courselogic obj = new Courselogic();
            var courseDetailes = obj.CourseDetails();
            ViewBag.CourseDetails = courseDetailes;
            return View();

        }


    }
}