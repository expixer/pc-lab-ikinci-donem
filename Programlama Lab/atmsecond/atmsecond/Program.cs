using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace atmsecond
{// girilen şifreyi kontrol eden metot true false döndür. Eğer true ise menüye sok çıkış diyesiye kadar.1 Para yatırma,2 para çekme 3 bakiye kontrol 4 Çıkış metotları olacak

    class Program
    {
        static void Main(string[] args)
        {
            int sifre = 123;
            int[] bakiye = { 700 };
            SifreKontrol(sifre);
            MenuBilgilendirme();
            Menu(bakiye);


        }

        static void BakiyeGor(int[] bakiye) {
            Console.Clear();
            Console.WriteLine("Bakiyeniz: " + bakiye[0]);
            Menu(bakiye);
        }
        static void SifreKontrol(int sifre)
        {
            Console.WriteLine("Lütfen Şifrenizi Giriniz.");
            int sifregirisi = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 0; i < 2; i++)
            {
                if (sifregirisi == sifre)
                {
                    
                    return;
                }
                else
                {
                    Console.WriteLine("Yanlış Şifre, Tekrar Deneyiniz.");
                    sifregirisi = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                if (i==1)
                    Environment.Exit(0);

            }
            Console.Clear();

        }
        static void MenuBilgilendirme()
        {
            Console.WriteLine("İşlem Menüsüne Hoş Geldiniz.");
            Thread.Sleep(1000);
            Console.Clear();
        }
        static void Menu(int[] bakiye)
        {
            Console.WriteLine("1. Para Yatır\n2. Para çek\n3. Bakiyeni Gör\n4. Çıkış Yap");
            int islem;
            islem = int.Parse(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    ParaYatir(bakiye);
                    break;
                case 2:
                    ParaCek(bakiye);
                    break;
                case 3:
                    BakiyeGor(bakiye);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem Yaptınız Tekrar Giriniz.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Menu(bakiye);
                    break;
            }
        }
        static void ParaYatir(int[] bakiye)
        {
            Console.Clear();
            Console.WriteLine("Yatırılacak Tutarı Giriniz.");
            int girilen;
            girilen = int.Parse(Console.ReadLine());
            bakiye[0] += girilen;
            Console.WriteLine("Yeni Bakiyeniz: " + bakiye[0]);
            Menu(bakiye);

        }
        static void ParaCek(int[] bakiye)
        {
            Console.Clear();
            Console.WriteLine("Çekilecek Tutarı Giriniz.");
            int girilen;
            girilen = int.Parse(Console.ReadLine());
            bakiye[0] -= girilen;
            Console.WriteLine("Yeni Bakiyeniz: " + bakiye[0]);
            Menu(bakiye);

        }
    }
}
