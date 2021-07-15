using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void HeadingAdd(Heading Heading);
        Heading GetByID(int id);
        void HeadingDelete(Heading Heading);
        void HeadingUpdate(Heading Heading);
    }
}
