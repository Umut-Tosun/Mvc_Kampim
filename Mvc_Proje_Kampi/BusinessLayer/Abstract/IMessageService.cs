using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IMessageService
    {
        List<Message> GetListInbox(string p);
        List<Message> GetListSendBox(string p);
        void MessageAdd(Message CMessage);
        Message GetByID(int id);
        void MessageDelete(Message Message);
        void IsRead(Message Message);
        void MessageUpdate(Message Message);
    }
}
