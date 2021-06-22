using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void HeadingAddBl(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void HeadingUpdate(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public void DeleteHeading(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public Heading GetByID(int id)
        {
            return _headingDal.Get(x => x.HeadingID == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }
    }
}
