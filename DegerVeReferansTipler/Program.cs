namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);




            //int,decimal,float,bool,double = DEĞER TİP demek.
            //Array,Class,Interface vb. bunlar ise = Referans tip olarak karşımıza çıkar.
            //Interfacede instance yaratırken new kullanılmaz.

            //STACK VE HEAP OLAYLARI VARDIR.

            //Değer tiplerde şöyle okunur:: Sayi1'in değeri eşittir 10. Sayi2'Nin dğeri eşittir 30dur.Değer tiplerde stack kullanılır.
            //Referance tiplerde ise biz "new" komutunu kullanırsak Heap'te alan oluşur.
            //Belirli adreslerce tutulan değerler vardır bunlar referance alınır.(Bellekte)
            //New demek bellekte yeni bir adres, yeni bir yer oluştur demek.
            //Şöyle okunur:: Sayılar1'in referance numarası Sayılar2'nin referance numarasına eşittir. Referance tiplerde adres atanır.
            //Heapte boşalan kısmı .Net'in garbage collectoru siler bellekten.

        }
    }
}