using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek3
{
    class Program
    {

        /*static void DiziYaz(int[] dizi_yaz, int secim)
        {

            if (secim==1)
            {
                foreach (int i in dizi_yaz)
                {
                    Console.Write(i + " ");
                }
            }
            else
            {
                foreach (int i in dizi_yaz)
                {
                    Console.WriteLine(i);
                }
            }

        }*/
        static void DiziYaz(Array dizi_yaz, int secim)
        {

            if (secim == 1)
            {
                foreach (object i in dizi_yaz)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
            else
            {
                foreach (int i in dizi_yaz)
                {
                    Console.WriteLine(i.ToString());
                }
            }

        }
        static int DiziMaks(int[] metot_dizi)
        {

            int max = 0;
            for (int i = 0; i < metot_dizi.Length; i++)
            {

                if (metot_dizi[i]>max)
                    max = metot_dizi[i];

            }
            return max;
        
        }


        static void Main(string[] args)
        {
            int boyut, maks, tercih;
            Console.Write("Oluşturmak istediğiniz dizinin boyutunu giriniz: ");
            boyut = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[boyut];
            Random rnd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0, 100);
            }
            Console.Write("Oluşturulan diziyi yan yana yazdırmak için 1,\nalt alta yazdırmak için 2 giriniz: ");
            tercih = Convert.ToInt32(Console.ReadLine());
            DiziYaz(dizi, tercih);
            maks = DiziMaks(dizi);
            Console.WriteLine("Oluşturulan dizinin en büyük elemanı: {0}", maks);

        }
    }
}
