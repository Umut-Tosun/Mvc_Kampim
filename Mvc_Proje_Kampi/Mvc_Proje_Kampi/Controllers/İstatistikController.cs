using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Proje_Kampi.Controllers
{
    public class İstatistikController : Controller
    {
        // GET: İstatistik
        Context c = new Context();
        public ActionResult Index()
        {
            //Toplam Kategori Sayısı
            ViewBag.deger = c.Categories.Count();

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark     
            ViewBag.deger1 = c.Categories.Where(x => x.CategoryStatus == true).Count();
            ViewBag.deger2 = c.Categories.Where(x => x.CategoryStatus == false).Count();    
            ViewBag.deger3 = ViewBag.deger1 - ViewBag.deger2;

            // Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            ViewBag.deger4 = c.Headings.Where(x => x.CategoryID == 7).Count();

            // Yazar adında 'a' harfi geçen yazar sayısı
            ViewBag.deger5 = c.Writers.Where(x => x.WriterName.Contains("A")).Count();


            // En fazla başlığa sahip kategori adı
            var EnFazlaBaşlık = c.Headings.Where(u => u.CategoryID == c.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count())
                  .Select(x => x.Key).FirstOrDefault()).Select(x => x.Category.CategoryName).FirstOrDefault(); 
            ViewBag.deger6 = EnFazlaBaşlık;
            return View();
        }
    }
}