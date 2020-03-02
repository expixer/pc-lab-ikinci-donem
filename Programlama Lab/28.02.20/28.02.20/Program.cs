using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _28._02._20
{
    class Program

    {//kromozom methodu, çaprazlama methodu, mutasyon methodu
        static int[] BEKLENEN = new int[4];
        static int iterasyon = 1;
        static int Eslesme(int[] istenen,int[] gelen) {
            int eslesme=1;
            for (int i = 0; i < istenen.Length; i++)
            {
                if (istenen[i]!=gelen[i])
                {
                    eslesme = 0;
                }

            }
            return eslesme;
        }
        static int[] GenOlustur()
        {
            int[] gen = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < gen.Length; i++)
            {
                gen[i] = rnd.Next(0, 2);
            }
            return gen;
        }
        static int[] Caprazla(int[] annegelen, int[] babagelen)
        {
            int[] cocukgen = new int[4];
            int secim;
            Random rnd = new Random();

            for (int i = 0; i < cocukgen.Length; i++)
            {
                secim=rnd.Next(0, 2);
                if (i < 2)
                {
                    cocukgen[i] = annegelen[i];
                }
                else
                {
                    cocukgen[i] = babagelen[i];
                }
            }
                return cocukgen;
        }

        static int[] Mutasyon( int[] caprazlanan) {
            int[] mutasyongen = caprazlanan;
            Random rnd = new Random();
            int rastgele=rnd.Next(0, 4);
            if (mutasyongen[rastgele]==1)
            {
                mutasyongen[rastgele] = 0;
            }
            else if (mutasyongen[rastgele] == 0)
            {
                mutasyongen[rastgele] = 1;
            }

            return mutasyongen;
        }
        static void Main()
        {
            if (iterasyon==1)
                for (int i = 0; i < BEKLENEN.Length; i++)
                {
                    BEKLENEN[i] = int.Parse(Console.ReadLine());
                }
            Console.WriteLine(iterasyon+".İterasyon");
            int[] annegen = GenOlustur();
            Console.WriteLine("Anenin Genleri "+ string.Join("", annegen));
            Thread.Sleep(20);
            int[] babagen = GenOlustur();
            Console.WriteLine("Babanın Genleri " + string.Join("", babagen));
            int[] caprazlanangen = Caprazla(annegen, babagen);
            Console.WriteLine("Çaprazlanan Genleri " + string.Join("", caprazlanangen));
            if (Eslesme(BEKLENEN, caprazlanangen) == 1)
            {
                Console.WriteLine("İstenen Gen Bulundu.");
            }
            else
            {
                Console.WriteLine("istenen gen bulunamadı.");

                int[] songelen=Mutasyon(caprazlanangen);
                Console.WriteLine("Mutasyon Genleri " + string.Join("", songelen));
                if (Eslesme(songelen, BEKLENEN) == 1)
                {
                    Console.WriteLine("İstenen Gen Bulundu.");
                }
                else
                {
                    Console.WriteLine("İstenen Gen Bulunamadı.");
                    Console.WriteLine();
                    iterasyon++;
                    Main();
                }
            }
        }
    }
}