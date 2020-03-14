using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortgenClassOrnek
{
    class Dortgen
    {
        public int En;
        public int Boy;

        public int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }
        public void EnBoyBelirle(int En, int Boy)
        {
            if (En < 0 || Boy < 0)
            {
                En = 0;
                Boy = 0;
            }
            else
            {
                //this.xx bu classdaki manasında kullanılıyor.
                this.En = En;
                this.Boy = Boy;
            }
        }
        public void Yaz()
        {
            Console.WriteLine("****************");
            Console.WriteLine("En={0,5}", En);
            Console.WriteLine("Boy={0,5}", Boy);
            Console.WriteLine("Alan={0,5}", Alan());
            Console.WriteLine("****************");
        }
    }
     
    class Anasınıf
    {
        static void Main(String[] args)
        {
            Dortgen d1 = new Dortgen();
            Console.WriteLine("En ve Boyu Giriniz: ");
            d1.En = Convert.ToInt32(Console.ReadLine());
            d1.Boy= Convert.ToInt32(Console.ReadLine());
            d1.Yaz();
            Console.Read();

            d1.EnBoyBelirle(20, 50);
            d1.Yaz();

            Console.Read();

            d1.En = 12;
            d1.Boy = 20;
            d1.Yaz();
            Console.Read();
        }
    }

}
