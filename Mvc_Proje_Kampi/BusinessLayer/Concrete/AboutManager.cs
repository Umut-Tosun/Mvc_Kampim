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
    public class AboutManager : IAboutService
    {
        IAboutDal _AboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _AboutDal = aboutDal;
        }

        public void AboutAdd(About About)
        {
            _AboutDal.insert(About);
        }

        public void AboutDelete(About About)
        {
            _AboutDal.delete(About);
        }

        public void AboutUpdate(About About)
        {
            _AboutDal.update(About);
        }

        public About GetByID(int id)
        {
            return _AboutDal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _AboutDal.list();
        }
    }
}
