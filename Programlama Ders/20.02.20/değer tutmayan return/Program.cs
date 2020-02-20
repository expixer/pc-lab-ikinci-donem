using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace değer_tutmayan_return
{
    class Program
    {
        static void Yaz(object a, int b)
        {
            if (b > 10) return;
            for (; b>0; b--)
                Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Yaz("Merhaba", 10);
        }
    }
}
