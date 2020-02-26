using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            int bakiye = 500;
            Console.Write("Sifre giriniz: ");
            int sifre = Convert.ToInt32(Console.ReadLine());

            if (SifreKontrol(sifre) == false)
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Şifre hatalı tekrar deneyiniz: ");
                    sifre = Convert.ToInt32(Console.ReadLine());

                    if (i == 1 && SifreKontrol(sifre) == false)
                    {
                        Console.WriteLine("Kart bloke oldu");
                        Environment.Exit(0);
                    }
                    if (SifreKontrol(sifre) == true)
                        break;
                }
            Console.Clear();

            while (SifreKontrol(sifre) == true)
            {
                Console.WriteLine("1- Para Yatır ");
                Console.WriteLine("2- Para Çek ");
                Console.WriteLine("3- Bakiye Sorgula ");
                Console.WriteLine("4- Çıkış ");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (secim)
                {
                    case 1:
                        bakiye = ParaYatir(bakiye);
                        Console.WriteLine("İşleminiz gerçekleşti");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();

                        break;
                    case 2:
                        bakiye = ParaCek(bakiye);
                        Console.WriteLine("İşleminiz gerçekleşti");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 3:
                        Sorgula(bakiye);
                        Console.WriteLine("Ana menünye dönmek için bir tuşa basınız");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Lüften kartınızı unutmayınız");
                        Environment.Exit(0);
                        break;
                }
            }

        }
        static bool SifreKontrol(int sifre)
        {
            if (sifre == 1234)
                return true;
            else
                return false;
        }

        static int ParaYatir(int bakiye)
        {
            Console.Write("Yatırmak istediğiniz miktarı giriniz: ");

            return bakiye + Convert.ToInt32(Console.ReadLine());
        }
        static int ParaCek(int bakiye)
        {
            Console.Write("Çekmek istediğiniz miktarı giriniz: ");

            return bakiye - Convert.ToInt32(Console.ReadLine());
        }
        static void Sorgula(int bakiye)
        {
            Console.WriteLine("Hesap bakiyeniz: " + bakiye);

        }

    }
}