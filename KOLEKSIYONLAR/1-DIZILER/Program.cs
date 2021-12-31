using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DIZILER
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[5] { 30, 50, 75, 45, 90 };
            string[] isimler = new string[5] { "UTKU", "EMO", "FİKO", "CELO", "TUTKU" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("SAYILAR : " + sayılar[i]);
                Console.WriteLine("İSİMLER : " + isimler[i]);
            }

            Console.ReadKey();
        }
    }
}
