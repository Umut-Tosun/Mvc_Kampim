using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutvalues = abm.GetList();
            return View(aboutvalues);
        }
        [HttpGet]
        public ActionResult AboutAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AboutAdd(About p)
        {
            abm.AboutAdd(p);
            return RedirectToAction("Index");
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
        public ActionResult DeleteAbout(int id)
        {
            var AboutValue = abm.GetByID(id);
            if (AboutValue.AboutStatus == true)
            {
                AboutValue.AboutStatus = false;
            }
            else
            {
                AboutValue.AboutStatus = true;
            }           
            abm.AboutDelete(AboutValue);
            return RedirectToAction("Index");
        }
    }
}