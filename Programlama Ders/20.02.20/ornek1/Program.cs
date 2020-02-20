using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    class Program
    {
        static int EnBuyuk2(int a, int b)
        {

            if (a > b) return a;
            else return b;
        
        }
        static int EnBuyuk3(int a, int b, int c)
        {

            return EnBuyuk2(a, EnBuyuk2(b,c));

        }
        static void Main(string[] args)
        {

            int sayi1, sayi2, sayi3;
            Console.WriteLine("Sayıları Girin: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("En Büyük Sayı: {0}",EnBuyuk3(sayi1,sayi2,sayi3));


        }
    }
}
