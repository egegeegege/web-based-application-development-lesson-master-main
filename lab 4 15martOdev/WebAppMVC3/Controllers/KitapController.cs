using Microsoft.AspNetCore.Mvc;
using WebAppMVC3.Models;

namespace WebAppMVC3.Controllers
{
    public class KitapController : Controller
    {

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Kitap kitap)
        {

            return Content("urun basariyla eklendi");
        }

        public IActionResult Güncelle()
        {
            return View();
        }

        public IActionResult Sil()
        {
            return View();
        }

        public IActionResult Index()
        {

       

            Kitap kitap = new Kitap();
            {
                kitap.Id = 1;
                kitap.Ad = " A'dan Z'ye Siber Guvenlik";
                kitap.Yazar = " A. Can POLAT";
                kitap.YayinEvi = "Kodlab";
                kitap.Kategori = "Bigisayar";
            }

            Kitap kitap1 = new Kitap();
            {
                kitap1.Id = 2;
                kitap1.Ad = "Suç ve Ceza";
                kitap1.Yazar = "Fyodor Dostoyevski";
                kitap1.YayinEvi = "can yayınları";
                kitap1.Kategori = "Dünya klasikleri";
            }

            Kitap kitap2 = new Kitap();
            {
                kitap2.Id = 3;
                kitap2.Ad = "Sefiller ";
                kitap2.Yazar = "Victor Hugo";
                kitap2.YayinEvi = "İşbankası yayınları";
                kitap2.Kategori = "Dünya klasikleri";
            }

            Kitap kitap3 = new Kitap();
            {
                kitap3.Id = 4;
                kitap3.Ad = "Şeker Portakalı";
                kitap3.Yazar = "José Mauro de Vasconcelos";
                kitap3.YayinEvi = "Macmıllan";
                kitap3.Kategori = "Roman";
            }

            ViewData["Roman"] = "Roman";
            ViewData["Klasik"] = "Klasik";
            TempData["Bilgisayar"] = "Bilgisayar";

            List<Kitap> kitaplar = new List<Kitap>();
            kitaplar.Add(kitap);
            kitaplar.Add(kitap1);
            kitaplar.Add(kitap2);
            kitaplar.Add(kitap3);

            return View(kitaplar);


           



        }
    }
}
