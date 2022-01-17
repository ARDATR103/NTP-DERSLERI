using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;//ARRAY LİSTİ KOLEKSİYONLAR NAMESPACESİNİ EKLEMEDEN KULLANAMAYIZ

namespace DIZILER_04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dinamikList = new ArrayList(); //KULLANIMI ARRAYLİST-İSİM = NEW ARRAYLİST()
            dinamikList.Add(5);// EKLEME
            dinamikList.Add(10);
            dinamikList.Add("arda");
            dinamikList.Add("celal");

            foreach (var item in dinamikList)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("----------");
            int sonuc;
            sonuc = (int)dinamikList[0] * 2;
            Console.WriteLine("Sonuç : "+sonuc);
            Console.ReadKey();
        }
    }

}
