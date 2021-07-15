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
   public class MessageManager : IMessageService
    {
        IMessageDal _MessageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _MessageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _MessageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox()
        {
            return _MessageDal.list(x=>x.RecevierMail=="admin@gmail.com");
        }

        public List<Message> GetListSendBox()
        {
            return _MessageDal.list(x=>x.SenderMail== "admin@gmail.com");
        }

        public void MessageAdd(Message CMessage)
        {
            _MessageDal.insert(CMessage);
        }

        public void MessageDelete(Message Message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message Message)
        {
            throw new NotImplementedException();
        }
    }
}
