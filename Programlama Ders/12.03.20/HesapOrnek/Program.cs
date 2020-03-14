using System;

namespace HesapOrnek
{
    class Program
    {
        class KrediHesabı
        {
            public ulong HesapNo;
            public double Limit;
            public string KartSahibi;
        }

        class AnaSınıf
        {
            static void Main(string[] args)
            {
                KrediHesabı hesap1 = new KrediHesabı();
                KrediHesabı hesap2;
                //sınıflar new anahtar sözcüğü ile tanımlandığı için bütün üyeler varsayılan değere atanır.
                hesap1.HesapNo = 1023123523;
                Console.WriteLine(hesap1.HesapNo);

                hesap2 = hesap1;
                Console.WriteLine(hesap2.HesapNo);
                hesap2.HesapNo = 999999999;
                Console.WriteLine(hesap1.HesapNo);
            }
        }
    }
}

