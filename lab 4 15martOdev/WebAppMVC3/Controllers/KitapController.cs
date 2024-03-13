using Microsoft.AspNetCore.Mvc;
using WebAppMVC3.Models;

namespace WebAppMVC3.Controllers
{
    public class KitapController : Controller
    {
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
                kitap1.Id = 1;
                kitap1.Ad = " A'dan Z'ye Siber Guvenlik";
                kitap1.Yazar = " A. Can POLAT";
                kitap1.YayinEvi = "Kodlab";
                kitap1.Kategori = "Bigisayar";
            }

            Kitap kitap2 = new Kitap();
            {
                kitap2.Id = 1;
                kitap2.Ad = " A'dan Z'ye Siber Guvenlik";
                kitap2.Yazar = " A. Can POLAT";
                kitap2.YayinEvi = "Kodlab";
                kitap2.Kategori = "Bigisayar";
            }

            Kitap kitap3 = new Kitap();
            {
                kitap3.Id = 1;
                kitap3.Ad = " A'dan Z'ye Siber Guvenlik";
                kitap3.Yazar = " A. Can POLAT";
                kitap3.YayinEvi = "Kodlab";
                kitap3.Kategori = "Bigisayar";
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


            //HttpPostAttribute eksiik ve kategori listesini bir liste içinde değil view data ve tempdata ile tanımladım nasıl listeleyeceğimi anlamadım ve son olarak butonlar çalışmıyor nedenini bilmiyorum

        }
    }
}
