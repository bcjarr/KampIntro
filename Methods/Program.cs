namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {



            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 19;
            urun1.Id = 1231;
            urun1.Aciklama = "Yeşil ve Kırmızı Elmalar, Orta boyutlu";

            Urun urun2= new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 12;
            urun2.Id = 1423123;
            urun2.Aciklama = "Armuttttt";

            Urun urun3 = new Urun();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 124;
            urun3.Id = 91283;
            urun3.Aciklama = "Diyarbakır Karpuzu";

            Urun urun4 = new Urun();
            urun4.Adi = "Şeftali";
            urun4.Fiyati = 5;
            urun4.Id = 9;
            urun4.Aciklama = "Tüylü ve Tüysüz Şeftaliler";

            Urun urun5 = new Urun();
            urun5.Adi = "Çilek";
            urun5.Fiyati = 5;
            urun5.Id = 746382;
            urun5.Aciklama = "Çilli Çilli Çileklerrr";

            Urun urun6 = new Urun();
            urun6.Adi = "Erik";
            urun6.Fiyati = 54;
            urun6.Id = 12245124;
            urun6.Aciklama = "Papaz eriği gel gel";


            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4, urun5, urun6, };
            foreach (Urun urunlisteleme in urunler)
            {
                Console.WriteLine(urunlisteleme.Id);
                Console.WriteLine(urunlisteleme.Aciklama);
                Console.WriteLine(urunlisteleme.Adi);
                Console.WriteLine(urunlisteleme.Fiyati);
                Console.WriteLine(Environment.NewLine);


            }
            // Burda yaptığımız sınıf çağırma işlemidir.Instance oluşturuyoruz. Class örneği oluşturmak.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//Methodumuzu çağırdık.  //Sepetmanager. deyince onun içindekiler gelir.
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);
            sepetManager.Ekle(urun5);
            sepetManager.Ekle(urun6);
        }
    }
}