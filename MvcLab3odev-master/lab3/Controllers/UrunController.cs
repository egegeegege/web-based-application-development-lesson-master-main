using lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
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



        public IActionResult UrunListesi()
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Isım = "Lenovo Ultrabook V4";
            urun1.Aciklama = "Bu ürünün ağırlığı yaklasşık 2400 gramdır";
            urun1.Kategori = "Elektronik";
            urun1.Fiyat = 13999;

            Urun urun2 = new Urun();
            urun2.Id = 1;
            urun2.Isım = "Lenovo Ultrabook V4";
            urun2.Aciklama = "Bu ürünün ağırlığı yaklasşık 2400 gramdır";
            urun2.Kategori = "Elektronik";
            urun2.Fiyat = 13999;

            Urun urun3 = new Urun();
            urun3.Id = 1;
            urun3.Isım = "Lenovo Ultrabook V4";
            urun3.Aciklama = "Bu ürünün ağırlığı yaklasşık 2400 gramdır";
            urun3.Kategori = "Elektronik";
            urun3.Fiyat = 13999;

            List<Urun> urunler = new List<Urun>();

            urunler.Add(urun1);
            urunler.Add(urun2);
            urunler.Add(urun3);

            return View(urunler);
        }
    }
}
    


