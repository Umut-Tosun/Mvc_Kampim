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
    public class WriterManager : IWriterService
    {
        IWriterDal _WriterDal;

        public WriterManager(IWriterDal writerDal)
        {
            _WriterDal = writerDal;
        }

        public Writer GetByID(int id)
        {
            return _WriterDal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _WriterDal.list();
        }

        public void WriterAdd(Writer writer)
        {
            _WriterDal.insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _WriterDal.delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _WriterDal.update(writer);
        }
    }
}
