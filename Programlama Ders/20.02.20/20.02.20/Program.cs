using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._20
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program nesne = new Program();
            int a = nesne.Topla(2, 5);
            Console.WriteLine(a);
            

        }
        int Topla(int a, int b)
        {
            return a + b;
        }
    }

}
