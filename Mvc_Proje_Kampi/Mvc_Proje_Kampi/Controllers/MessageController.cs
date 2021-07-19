using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager mm = new MessageManager(new EfMessageDal());
        MessageValidator mvalidator = new MessageValidator();
       
        public ActionResult Inbox()
        {
           string  p = (string)Session["AdminUserName"];
            ViewBag.vl = mm.GetListInbox(p).Where(x => x.IsRead == false).LongCount();
            var messagelist = mm.GetListInbox(p);
            return View(messagelist);
        }
        public ActionResult SendBox()
        {
            string p = (string)Session["AdminUserName"];
            var messagelist = mm.GetListSendBox(p);
            return View(messagelist);
            
        }
        public ActionResult GetInboxMessageDetails(int id)
        {
            var value = mm.GetByID(id);
            return View(value);
        }
        public ActionResult GetSendboxMessageDetails(int id)
        {
            var value = mm.GetByID(id);
            return View(value);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            
            ValidationResult results = mvalidator.Validate(p);
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult IsRead(int id)
        {
            var HeadingValue = mm.GetByID(id);
            if (HeadingValue.IsRead == false)
            {
                HeadingValue.IsRead = true;
            }
           
            mm.IsRead(HeadingValue);
            return RedirectToAction("Inbox");
        }
    }
}