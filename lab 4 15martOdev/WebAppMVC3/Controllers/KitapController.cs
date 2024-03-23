using Microsoft.AspNetCore.Mvc;
using WebAppMVC3.Models;

namespace WebAppMVC3.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {

            var kitaplar = KitapDb.KitapListesi();

            return View(kitaplar);

        }
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kitap kitap)
        {

            return Content("Kitap basariyla eklendi");
        }

        public IActionResult Güncelle()
        {
            return View();
        }

        public IActionResult Sil()
        {
            return View();
        }

    }
}
