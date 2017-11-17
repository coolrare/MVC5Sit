using MVC5Course.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            throw new ArgumentException("No Argument!");

            return View();
        }

        public ActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test(string id)
        {
            return View((object)id);
        }

        public ActionResult Test2(string id)
        {
            return PartialView("Test", (object)id);
        }

        public ActionResult ContentDemo()
        {
            // SaveChange();

            return Content("<script>alert('新增成功');location.href='/';</script>");
        }

        public ActionResult Succeed()
        {
            return View("JSAlertRedirect", (object)"新增成功");
        }

        public ActionResult File1()
        {
            return File(
                @"G:\甘特圖.xlsx",
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "客戶資料輸出.xlsx");
        }
        public ActionResult File2(int dl = 0)
        {
            if (dl == 1)
            {
                return File(Server.MapPath("~/Content/1377946249-1584189015.jpg"), "image/jpeg", "兄弟加油.jpg");
            }
            else
            {
                return File(Server.MapPath("~/Content/1377946249-1584189015.jpg"), "image/jpeg");
            }
        }

        public ActionResult ViewTest()
        {
            return View();
        }

        public ActionResult MetroIndex()
        {
            return View();
        }
    }
}