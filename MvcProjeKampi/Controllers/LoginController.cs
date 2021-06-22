using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MvcProjeKampi.HashHelpers;
using MvcProjeKampi.MagicStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        AdminManager am = new AdminManager(new EfAdminDal());
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            
            string userName = admin.AdminUserName;
            string password = admin.AdminPassword;
             var adminUserInfo = am.AdminLogin(HashHelper.AESEncrypt(userName,MagicString.AES_HASH_USERNAME),HashHelper.AESEncrypt(password,MagicString.AES_HASH_KEY));
            if (adminUserInfo!=null)
            {
                FormsAuthentication.SetAuthCookie(adminUserInfo.AdminUserName,false);
                Session["AdminUserName"] = adminUserInfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}