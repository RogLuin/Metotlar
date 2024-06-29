using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //Naming Convention
        //Syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine(" Tebrikler. Sepete Eklendi : " + urun.Adi);
            
        }

        public void Ekle2(string urunadi, string aaciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunadi);
        }
    }
}
