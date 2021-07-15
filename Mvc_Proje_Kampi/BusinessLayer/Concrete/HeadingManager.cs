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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingdal;

        public HeadingManager(IHeadingDal headingdal)
        {
            _headingdal = headingdal;
        }

        public Heading GetByID(int id)
        {
            return _headingdal.Get(x=>x.HeadingID==id);
        }

        public List<Heading> GetList()
        {
            return _headingdal.list();
        }

        public void HeadingAdd(Heading Heading)
        {
            _headingdal.insert(Heading);
        }

        public void HeadingDelete(Heading Heading)
        {            
            HeadingUpdate(Heading);
        }

        public void HeadingUpdate(Heading Heading)
        {
            _headingdal.update(Heading);
        }
    }
}
