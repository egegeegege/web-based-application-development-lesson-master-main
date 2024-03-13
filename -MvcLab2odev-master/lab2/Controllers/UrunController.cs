using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            Urun urun = new Urun();
            urun.Id = 1;
            urun.Isım = "Lenova Ultrabook V4";
            urun.Aciklama = "Bu ürünün ağırlığı yaklaşık 2400 gramdır.";
            urun.Kategori = "Elektronik";
            urun.Fiyat = 13999;
            return View(urun);
        }
    }
}
