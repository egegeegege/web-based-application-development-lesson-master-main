namespace WebAppMVC3.Models
{
    public static class KitapDb
    {
        public static List<Kitap> KitapListesi()
        {
            var kitaplar = new List<Kitap>() { 
            
            new Kitap() { Id = 1, Ad = " A'dan Z'ye Siber Guvenlik",Yazar = " A. Can POLAT", YayinEvi = "Kodlab", Kategori = "Bigisayar"},

            new Kitap() { Id = 2, Ad = "Suç ve Ceza",Yazar = "Fyodor Dostoyevski", YayinEvi = "can yayınları", Kategori = "Dünya klasikleri"},

            new Kitap() { Id = 3, Ad = "Sefiller",Yazar = "Victor Hugo", YayinEvi = "İşbankası yayınları", Kategori = "Dünya klasikleri"},

            new Kitap() { Id = 4, Ad = " Şeker Portakalı",Yazar = "José Mauro de Vasconcelos", YayinEvi = "Macmıllan", Kategori = "Roman"},

            };
            return kitaplar;
        }
    }
}
