using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOREACH_DONGUSU
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[] { 43, 756, 1223, 765 };

            foreach (int item in sayılar)
            {
                Console.WriteLine("Koleksiyondaki Sayılar : " + item);
            }

            Console.ReadKey();
        }
    }
}
