using MVC5Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public abstract class BaseController : Controller
    {
        protected FabricsEntities db = new FabricsEntities();

        public string[] GetOptions()
        {
            return new string[] { };
        }

        //protected override void HandleUnknownAction(string actionName)
        //{
        //    this.Redirect("/").ExecuteResult(this.ControllerContext);
        //}
    }
}