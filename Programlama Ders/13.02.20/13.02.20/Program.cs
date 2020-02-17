using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._20
{

    //klavyeden girilen iki sayıyı hesapla isimli methoda gönder. Methodda iki sayı arasındaki 3 ile bölünne sayıların ortalamasını bul
    //toplam sayı adedi
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[] rast = new int[20];
            for (int i = 0; i < rast.Length; i++)
            {
                rast[i] = rnd.Next(0, 50);
            }
            for (int i = 0; i < rast.Length; i++)
            {
                Console.WriteLine(rast[i]);
            }
            int[] yenidizi = Hesapla(rast);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("0 ile 50 arasında oluşturulan " +
                "20 tane rastgele oluşturulan sayılardan 3e bölünenlerin;" +
                " \nAdedi= {0} \nToplamı= {1}", yenidizi[1], yenidizi[0]);
            Console.ForegroundColor = ConsoleColor.DarkBlue;


        }
        static int[] Hesapla(int[] rastgelesayi)
        {
            int sayac = 0;
            int toplam = 0;
            for (int i = 0; i < rastgelesayi.Length; i++)
                if (rastgelesayi[i] % 3 == 0)
                {
                    toplam += rastgelesayi[i];
                    sayac++;
                }

            int[] dizi = {toplam,sayac};

            return dizi;
        }
    }
}
