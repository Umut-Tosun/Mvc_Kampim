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

        public List<Message> GetListInbox(string p)
        {
            return _MessageDal.list(x=>x.RecevierMail== p);
        }

        public List<Message> GetListSendBox(string p)
        {
            return _MessageDal.list(x=>x.SenderMail== p);
        }

        public void IsRead(Message Message)
        {
            _MessageDal.update(Message);
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
