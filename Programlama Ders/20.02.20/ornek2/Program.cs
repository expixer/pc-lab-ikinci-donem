using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void DiziYaz(int[] dizi)
        {
            foreach (int  i in dizi)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {

            int[] dizi1 = {1 ,2 ,3 ,4 ,5 };
            int[] dizi2 = {10 ,20 ,30 ,40 ,50 };
            Console.WriteLine("İlk Dizi: ");
            DiziYaz(dizi1);
            Console.WriteLine("İkinci Dizi: ");
            DiziYaz(dizi2);

        }
    }
}
