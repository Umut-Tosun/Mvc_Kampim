using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        Context c = new Context();
        public ActionResult Index()
        {
            var ContactValues = cm.GetList();
            return View(ContactValues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalue = cm.GetByID(id);
            return View(contactvalue);
        }
        public PartialViewResult ContactPartial()
        {
            string p = (string)Session["WriterMail"];
            ViewBag.value = c.Messages.Where(x=>x.RecevierMail==p).Count();
            ViewBag.value2 = c.Contacts.Count();
            return PartialView();
        }
    }
}