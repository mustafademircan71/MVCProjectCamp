using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin AdminLogin(string userName, string password)
        {
           return _adminDal.Get(x => x.AdminUserName == userName&&x.AdminPassword==password);
        }

        public Admin AdminRole(string username)
        {
            return _adminDal.Get(x => x.AdminUserName==username);
        }
    }
}
