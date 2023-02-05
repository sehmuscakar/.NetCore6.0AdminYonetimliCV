using AdminYonetimliCV.Models;
using AdminYonetimliCV.Models.Siniflar;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using NuGet.Versioning;

namespace AdminYonetimliCV.Controllers
{
    public class AnasayfaController : Controller
    {
        CVContext c = new CVContext();
        public IActionResult Index()
        {
           var deger=c.Anasayfas.ToList();
            return View(deger);
        }

       
       
    }
}
