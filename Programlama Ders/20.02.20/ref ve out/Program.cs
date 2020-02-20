using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_ve_out
{
    class Program
    {
        //ref ve out farkı: ref ile gönderilirse ilk değer bulunmalı ancak out ile gönderilirse değer verilmek zorunda değildir.
        /*static void Degistir(ref int sayi) { sayi = 10; }
        static void Yaz(int sayi) { Console.WriteLine(sayi); }
        static void Main(string[] args)
        {
            int sayi = 1; Degistir(ref sayi); Yaz(sayi);
        }*/

        static void DegerTipi(out int x)
        {

            x = 111;

        }
        static void Main()
        {

            int x;
            DegerTipi(out x);
            Console.WriteLine(x);

        }

    }
}
