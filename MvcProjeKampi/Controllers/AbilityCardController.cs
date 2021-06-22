using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AbilityCardController : Controller
    {
        AbilityCardManager abm = new AbilityCardManager(new EfAbilityCardDal());
        public ActionResult Index()
        {
            var abilityCardList = abm.GetList();
            return View(abilityCardList);
        }
    }
}