using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAddBl(Category category)
        {
            _categoryDal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }


      
    }
}
