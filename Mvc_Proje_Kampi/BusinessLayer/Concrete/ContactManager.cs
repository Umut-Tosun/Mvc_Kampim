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
   public class ContactManager : IContactService
    {
        IContactDal _ContactDal;

        public ContactManager(IContactDal contactDal)
        {
            _ContactDal = contactDal;
        }

        public void ContactAdd(Contact Contact)
        {
            _ContactDal.insert(Contact);
        }

        public void ContactDelete(Contact Contact)
        {
            _ContactDal.delete(Contact);
        }

        public void ContactUpdate(Contact Contact)
        {
            _ContactDal.update(Contact);
        }

        public Contact GetByID(int id)
        {
            return _ContactDal.Get(x=>x.ContractID==id);
        }

        public List<Contact> GetList()
        {
            return _ContactDal.list();
        }
    }
}
