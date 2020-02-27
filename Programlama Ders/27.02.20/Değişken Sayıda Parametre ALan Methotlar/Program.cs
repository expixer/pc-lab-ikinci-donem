using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Değişken_Sayıda_Parametre_ALan_Methotlar
{
    class Program
    {
        static int Toplam(params int[] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            int toplam = 0;
            foreach (int sayi in sayilar)
                toplam += sayi;
            return toplam;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(5));
            Console.WriteLine(Toplam(5,10));
            Console.WriteLine(Toplam(5,10,15));
            Console.WriteLine(Toplam(5,10,15,20));
        }
    }
}
