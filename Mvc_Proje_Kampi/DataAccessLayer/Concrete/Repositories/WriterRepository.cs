using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public Writer Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> list()
        {
            throw new NotImplementedException();
        }

        public List<Writer> list(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
