using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_olmayan_metotu_başka_sınıfta_kullanma
{
    class Metotlar
    {
        public int Topla(int a, int b)
        { return a + b; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar nesne = new Metotlar();
            int a=nesne.Topla(3, 9);
            Console.WriteLine(a);
        }
    }
}
