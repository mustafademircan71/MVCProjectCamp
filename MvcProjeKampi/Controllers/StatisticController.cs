using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        Context ctx = new Context();
        public ActionResult Index()
        {
            var value1 = ctx.Categories.Count().ToString();
            ViewBag.v1 = value1;

            var value2 = ctx.Headings.Where(x=>x.CategoryID==9).Count().ToString();
            ViewBag.v2 = value2;

            var value3 = ctx.Writers.Count(x=>x.WriterName.Contains("a")).ToString();
            ViewBag.v3 = value3;

            var value4 = ctx.Headings.Max(x => x.Category.CategoryName).ToString();
            ViewBag.v4 = value4;

            var value5 = ctx.Categories.Count(x => x.CategoryStatus == true);
            var value6 = ctx.Categories.Count(x => x.CategoryStatus == false);

            ViewBag.v5 = (value5 - value6);
         

            return View();
        }
    }
}