using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._03._20
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("x²'nin katsayısını giriniz.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x'in katsayısını giriniz.");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tam sayı katsayısını giriniz.");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Denklem={0}x²+{1}x+{2}",a,b,c);
            if (a == 0)
            {
                Console.WriteLine("x²'nin katsayısı 0 olamaz.");
                Console.Clear();
                Main();
            }
            double delta = Math.Pow(b,2)-(4*a*c);
            if (delta<0)
            {
                Console.WriteLine("Denklemin reel kökü yoktur.");
                return;
            }
            else if (delta==0)
            {
                Console.WriteLine("Denklemin iki eşit kökü vardır.");
            }
            else
            {
                Console.WriteLine("Denklemin iki farklı kökü vardır.");
            }
            double kokbir = (-b - Math.Sqrt(delta)) / (2 * a);
            double kokiki = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Birinci Kökü: "+kokbir+"\nİkinci Kökü: "+kokiki);

        }
    }
}
