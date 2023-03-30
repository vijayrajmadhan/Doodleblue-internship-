using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Using_Filters.Filter
{
    public class VijayAction : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("hello from action filter Executed");
            filterContext.Controller.ViewBag.Message = "vijay from Action filter";
          /*  ActionLog log = new ActionLog()
            {
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                Action = string.Concat(filterContext.ActionDescriptor.ActionName, "(Logged by : Custom Action Filter)"),
                IP = filterContext.HttpContext.Request.UserHostAddress,
                DateTime = filterContext.HttpContext.Timestamp
            };*/

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("hello from action filter Executing");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            Debug.WriteLine("hello from action filter result Executed");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            Debug.WriteLine("hello from action filter result Executing");
        }
       
    }
}