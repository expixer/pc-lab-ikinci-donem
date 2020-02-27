using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_ozyineli__methot
{
    class Program
    {
        static int faktoriyel(int a)
        {

            if (a==0)
            {
                return 1;
            }
            return a * faktoriyel(a - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(faktoriyel(2));
            Console.WriteLine(faktoriyel(4));
            Console.WriteLine(faktoriyel(6));
        }
    }
}
