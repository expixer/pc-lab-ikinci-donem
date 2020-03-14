using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifOrnek
{
    class SinifIsmi
    {
        public int ozellik1=55;
        public string ozellik2="deneme";
        public float ozellik3=123.78f;
        public int metot1(int a, int b)
        { return a +b; }
        public void metot2(string a)
        { Console.WriteLine(a); }
    }
    class EsasSinif
    {
        static void Main()
        {
            SinifIsmi nesne = new SinifIsmi(); Console.WriteLine(nesne.ozellik1);
            Console.WriteLine(nesne.ozellik2); Console.WriteLine(nesne.ozellik3);
            Console.WriteLine(nesne.metot1(2, 5)); nesne.metot2("deneme");
        }
    }
}
