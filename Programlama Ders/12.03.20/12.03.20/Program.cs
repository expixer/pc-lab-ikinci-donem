using System;

namespace _12._03._20
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
                KrediHesabı hesap = new KrediHesabı();
                //sınıflar new anahtar sözcüğü ile tanımlandığı için bütün üyeler varsayılan değere atanır.
                hesap.HesapNo = 1023123523;
                hesap.Limit = 20000;
                hesap.KartSahibi = "Johny Bravo";
                Console.WriteLine(hesap.HesapNo);
                Console.WriteLine(hesap.Limit);
                Console.WriteLine(hesap.KartSahibi);
            }
        }
    }
}