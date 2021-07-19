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

        public void AdminAdd(Admin Admin)
        {
            _adminDal.insert(Admin);
        }

        public void AdminDelete(Admin Admin)
        {
            Admin.AdminStatus = false;
            _adminDal.update(Admin);
        }

        public void AdminUpdate(Admin Admin)
        {
            _adminDal.update(Admin);
        }

        public Admin GetByID(int id)
        {
            return _adminDal.Get(x => x.AdminID == id);
        }
      

        public List<Admin> GetList()
        {
            return _adminDal.list();
        }
    }
}
