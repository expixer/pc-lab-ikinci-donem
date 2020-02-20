using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farklı_sınıf
{
    // Topla metotuna public yazmazsak Program classından erişemezdik.
    class metotLar
    {
        public static int Topla(int a, int b) { return a + b; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = metotLar.Topla(2, 5);
            Console.WriteLine(a);

        }
    }
}
