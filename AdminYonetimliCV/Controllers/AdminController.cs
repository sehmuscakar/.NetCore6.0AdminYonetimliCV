using AdminYonetimliCV.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;

namespace AdminYonetimliCV.Controllers
{
    public class AdminController : Controller
    {
       CVContext c=new CVContext();
        public IActionResult Index()
        {
            var deger=c.Anasayfas.ToList();
            return View(deger);
        }

        public IActionResult AnasayfaGetir(int id)
        {
            var ag = c.Anasayfas.Find(id);
            return View("AnasayfaGetir",ag);
        }

        public IActionResult AnasayfaGuncelle(Anasayfa x) 
        {
            var ag = c.Anasayfas.Find(x.id);
            ag.isim = x.isim;
            ag.unvan = x.unvan;
            ag.acıklama = x.acıklama;
            ag.iletisim = x.iletisim;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
