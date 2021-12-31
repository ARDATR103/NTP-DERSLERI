using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOREACH_ORNEKLERI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek1

            //random oluşturulan 20 sayılık dizinin tek sayılarını yazdırın
            Random rnd = new Random();
            int rast, sayac = 0;
            int[] sayılar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                rast = rnd.Next(1, 100);
                Console.WriteLine("RASTGELE SAYILAR :" + rast);
                sayılar[i] = rast;
            }

            Console.WriteLine("---------------------------");

            foreach (var item in sayılar)
            {
                if (item % 2 == 1)
                {
                    sayac++;
                    Console.WriteLine("TEK SAYILAR : " + item);                                      
                }
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("TEK SAYI ADETİ : "+sayac);
            Console.ReadKey();

            #endregion
        }
    }
}
