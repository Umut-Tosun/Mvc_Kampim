using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _catergoryDal;

        public CategoryManager(ICategoryDal catergoryDal)
        {
            _catergoryDal = catergoryDal;
        }

        public void CategoryAdd(Category Category)
        {
            _catergoryDal.insert(Category);
        }

        public void CategoryDelete(Category Category)
        {
            _catergoryDal.delete(Category);
        }

        public void CategoryUpdate(Category Category)
        {
            _catergoryDal.update(Category);
        }

        public Category GetByID(int id)
        {
            return _catergoryDal.Get(x=>x.CategoryID==id);
        }


        //  GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{
        //    return repo.list();

        //}
        //public void CategoryAddBL(Category P)
        //{

        //    if (P.CategoryName == "" || P.CategoryName.Length <= 3 || P.CategoryDescription == "" || P.CategoryName.Length >= 51)
        //    {
        //        //Hata mesajı
        //    }
        //    else
        //    {
        //        repo.insert(P);
        //    }

        //}
        public List<Category> GetList()
        {
            return _catergoryDal.list();
        }

        //public void CategoryAdd(Category p)
        //{
        //    if (p.CategoryName==""||p.CategoryName.Length<=3)
        //    {

        //    }
        //    else
        //    {
        //        _catergoryDal.insert(p);
        //    }
        //}
    }
}
