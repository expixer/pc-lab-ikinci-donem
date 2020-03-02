using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_yeni_ornek
{
    class Program
    {
        static int Main(string[] args)
        {
            int len = args.Length;
            if (len < 3)
            {
                Console.WriteLine("Eksik Parametre");
            }
            if (len > 3)
            {
                Console.WriteLine("Fazla Parametre");
                return 0;
            }
            string i = args[0];
            if (!(i=="t"||i=="ç"||i=="m"||i=="b"))
            {
                Console.WriteLine("Yanlış İşlem");
                return 0;
            }
            int sayi1 = Convert.ToInt32(args[1]);
            int sayi2 = Convert.ToInt32(args[2]);
            switch (i)
            {
                case "t":
                    Console.WriteLine("Sonuç: {0}", sayi1+sayi2);
                    break;
                case "ç":
                    Console.WriteLine("Sonuç: {0}", sayi1 - sayi2);
                    break;
                case "m":
                    Console.WriteLine("Sonuç: {0}", sayi1 * sayi2);
                    break;
                case "b":
                    switch (sayi2)
                    {
                        case 0:
                            Console.WriteLine("Bölen 0 olamaz.");
                            break;
                        default:
                            Console.WriteLine("Sonuç: {0}", sayi1 / sayi2);
                            break;
                    }
                    break;
                default:
                    break;
            }
            return 0;
        }
    }
}
