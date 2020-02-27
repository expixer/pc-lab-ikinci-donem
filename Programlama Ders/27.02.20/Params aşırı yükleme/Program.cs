using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params_aşırı_yükleme
{
    class Program
    {
        static void Yaz(int a, params object[] o)
        {
            Console.WriteLine("1. Metot");
        }
        static void Yaz(int a, object b)
        {
            Console.WriteLine("2. Metot");
        }
        static void Main(string[] args)
        {

            Yaz(0, 5);
            Yaz(0, 5, 10);
        }
    }
}
