using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface  IContentService
    {
        List<Content> GetList();
        List<Content> GetListByHeadingId(int id);
        void ContentAddBl(Content content);
        Content GetByID(int id);
        void DeleteContent(Content content);
        void ContentUpdate(Content content);

    }
}
