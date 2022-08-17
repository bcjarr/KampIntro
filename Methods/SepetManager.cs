using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class SepetManager
    {
        //Naming convention
        //Encapsulation ayrı ayrı yazıcağın bir parametreyi mesela bir kapsülün içine sokuyorsun mesela Urun paremetresi gibi.  
        public void Ekle(Urun urun)//Biz ürün ekliycez o yüzden veri tipimizde Urun.
            //Neyi Eklemek istediğimizi metoda vermemiz lazım. Bunada "PARAMETRE DENİR".
            //Bu metodun yapacağı kod süslü parantezler içerisine yazılır.//Bu Ekleyi çağırırsan bloğun içi defalarca çağrılır.
        {
            Console.WriteLine("Sepete eklendi " + " " + urun.Adi + " " + urun.Aciklama + " " + urun.Id + " " + urun.Fiyati);
        }

        public void Ekle2()
        {


        }
    }
}
