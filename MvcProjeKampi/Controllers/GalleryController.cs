using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class GalleryController : Controller
    {
        ImageFileManager imageFile = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var imageFiles = imageFile.GetList();
            return View(imageFiles);
        }
    }
}