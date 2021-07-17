using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IAdminService
    {
        List<Admin> GetList();
        void AdminAdd(Admin Admin);
        Admin GetByID(int id);
        void AdminDelete(Admin Admin);
        void AdminUpdate(Admin Admin);
    }
}
