using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator messageValidate = new MessageValidator();
        DraftManager dm = new DraftManager(new EfDraftDal());
        

       // [Authorize(Roles ="A")]
        public ActionResult Inbox()
        {
            var messageList = mm.GetListInbox();
            return View(messageList);
        }
        public ActionResult SendBox()
        {
            var messageList = mm.GetListSendBox();
            return View(messageList);
        }
        public ActionResult DraftList()
        {
            var draftList = mm.GetListSendBoxIsDraft();
            return View(draftList);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            values.ReadReceipt = true;
            mm.MessageUpdate(values);
            return View(values);
        }
        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }
        public ActionResult DraftDetails(int id)
        {
            var values = mm.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message,string parameter)
        {
            ValidationResult results = messageValidate.Validate(message);
            if (results.IsValid)
            {
                if (parameter=="send")
                {
                    message.SenderMail = "admin@gmail.com";
                    message.Draft = false;
                    message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    mm.MessageAddBl(message);
                    return RedirectToAction("SendBox");
                }
                else if (parameter== "draft")
                {
                    message.SenderMail = "admin@gmail.com";
                    message.Draft = true;
                    message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    mm.MessageAddBl(message);
                    return RedirectToAction("SendBox");
                }
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
        public ActionResult ReadReceipt(int id) 
        {
            var value = mm.GetByID(id);
            if (value.ReadReceipt==false)
            {
                value.ReadReceipt = true;
            }
            else
            {
                return RedirectToAction("Index");
            }
            mm.MessageUpdate(value);
            return RedirectToAction("Index");
        }
    }
}