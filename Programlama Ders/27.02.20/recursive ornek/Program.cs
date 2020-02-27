using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_ornek
{
    class Program
    {
        static void BitYaz(int sayi)
        {
            if (sayi==0)
            {
                return;
            }
            BitYaz(sayi >> 1);
            Console.Write(sayi&1);
        }
        static void Main(string[] args)
        {
            BitYaz(11);
        }
    }
}
