using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Using_Filters.Models;
using System.Web.Security;

namespace Using_Filters.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User model)
        {
            if(model.Name=="user" && model.Password=="user")
            {
                FormsAuthentication.SetAuthCookie(model.Name, false);
                return RedirectToAction("Index", "Home");
            }
            return View();
          /*  else
            {
                return RedirectToAction("Missing","Home");
            }*/
            
            
        }
    }
}