using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._20
{
    class Program
    {
        static void Metot1(int x, int y) { Console.WriteLine("Metot 1 Çağırıldı"); }
        static void Metot1(float x, float y) { Console.WriteLine("Metot 2 Çağırıldı"); }
        static void Metot1(string x, string y) { Console.WriteLine("Metot 3 Çağırıldı"); }
        static void Main(string[] args)
        {
            string deneme = "deneme"; 
            Metot1("deneme", "deneme");
            Metot1(5, 6);
            Metot1(10f, 56f);
            char a = deneme[1];
        }
    }
}
