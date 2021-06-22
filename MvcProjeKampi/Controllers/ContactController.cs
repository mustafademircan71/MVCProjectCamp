using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        MessageManager ctx = new MessageManager(new EfMessageDal());
       
        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetByID(id);
            return View(contactValues);
        }
        public PartialViewResult GetMessageMenuPartial()
        {
            var contactCount = cm.GetList().Count().ToString();
            ViewBag.contCou = contactCount;

            var reciverMail = ctx.GetListInbox().Where(y=>y.ReadReceipt==false).Count(x => x.ReceiverMail == "admin@gmail.com").ToString();
            ViewBag.reciMail = reciverMail;

            var senderMail = ctx.GetListSendBox().Count(x => x.SenderMail == "admin@gmail.com").ToString();
            ViewBag.senMail = senderMail;
            return PartialView();
        }
    }
}