using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager vm = new WriterManager(new EfWriterDal());
        
        public ActionResult Index()
        {
            var headingValue = hm.GetList();
            return View(headingValue);
        }

        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value=x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;

            List<SelectListItem> valueWriter = (from x in vm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.WriterName+" "+x.WriterSurName,
                                                      Value = x.WriterID.ToString()
                                                  }).ToList();
            ViewBag.vlw = valueWriter;

            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate =DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAddBl(heading);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valueCategory;
            var headingValue = hm.GetByID(id);
            return View(headingValue);
        }
        public ActionResult EditHeading(Heading heading) 
        {
            hm.HeadingUpdate(heading);
            return RedirectToAction("Index");
        }

        public ActionResult HeadingDelete(int id)
        {
            var headingValue = hm.GetByID(id);
            headingValue.HeadingStatus = false;
            hm.DeleteHeading(headingValue);
            return RedirectToAction("Index");    
        }
    }
}