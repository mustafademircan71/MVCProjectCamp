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
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAddBl(Content content)
        {
            _contentDal.Insert(content);
        }

        public void ContentUpdate(Content content)
        {
            _contentDal.Update(content);
        }

        public void DeleteContent(Content content)
        {
            _contentDal.Delete(content);
        }

        public Content GetByID(int id)
        {
            return _contentDal.Get(x=>x.ContentID==id);
        }

        public List<Content> GetList()
        {
           return _contentDal.List();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }
    }
}
