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

            foreach (object item in dinamikList)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("----------");
            int sonuc;
            sonuc = (int)dinamikList[0] * 2; //(int) diyerek unbox ediyoruz işlem yapmak için gerekli
            Console.WriteLine("Sonuç : "+sonuc);
            

            Console.WriteLine("----------");
            dinamikList[2] = "UTKU"; //var olan elemanı değiştirme
            foreach (object item in dinamikList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            dinamikList.Insert(3, "emirhan"); // 3 numaralı indise eleman ekler yani araya 3 numaralı elemanı silmeden eleman ekler
            foreach (object item in dinamikList)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine("----------");
            dinamikList.Remove("UTKU"); // girilen değerdeki  elemanı siler, diğer elemanlar aynı kalır
            foreach (object item in dinamikList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------");
            dinamikList.RemoveAt(3); // girilen indisteki elemanı siler,diğer elemanlar aynı kalır
            foreach (object item in dinamikList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
        }
    }

}
