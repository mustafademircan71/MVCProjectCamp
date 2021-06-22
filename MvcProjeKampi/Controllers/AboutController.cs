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
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutValues = abm.GetList();
            return View(aboutValues);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            abm.AboutAddBl(about);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        //[HttpGet]
        //public ActionResult AboutActive(int id)
        //{
        //    var AboutValue = abm.GetByID(id);
        //    return View();
        //}
     
        public ActionResult AboutActive(int id)
        {
            var aboutValue = abm.GetByID(id);
            if (aboutValue.AboutStatus==false)
            {
                aboutValue.AboutStatus = true;
            }
            else
            {
                return RedirectToAction("Index");
            }
            abm.AboutUpdate(aboutValue);
            return RedirectToAction("Index");
        }
       
        public ActionResult AboutPassive(int id)
        {
            var aboutValuePassive = abm.GetByID(id);
            if (aboutValuePassive.AboutStatus==true)
            {
                aboutValuePassive.AboutStatus = false;
            }
            else
            {
                return RedirectToAction("Index");
            }
            abm.AboutUpdate(aboutValuePassive);
            return RedirectToAction("Index");
        }
     
    }
}