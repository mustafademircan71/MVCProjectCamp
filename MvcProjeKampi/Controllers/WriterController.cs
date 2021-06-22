using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterController : Controller
    {
        WriterManager vm = new WriterManager(new EfWriterDal());
        WriterValidator validationRules = new WriterValidator();
        public ActionResult Index()
        {
            var writerValue = vm.GetList();
            return View(writerValue);
        }
        
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            
            ValidationResult results = validationRules.Validate(writer);

            if (results.IsValid)
            {
                vm.WriterAdd(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writerValue = vm.GetById(id);
            return View(writerValue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer writer)
        {
            ValidationResult results = validationRules.Validate(writer);

            if (results.IsValid)
            {
                vm.WriterUpdate(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(); 
           
        }
    }
}