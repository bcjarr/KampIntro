using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class DortIslem
    {
        //Topla(2,3)
        public void Topla(int sayi1,int sayi2)//PARAMETRE KISMI METODUMUZUN IHTIYACI OLANLARDIR.
            //TOPLA Metodunu kullanabilmem için benim bunlara bi sayı vermem lazım çünkü metod "TOPLA".//Void yazdıgımız için böyle.
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
