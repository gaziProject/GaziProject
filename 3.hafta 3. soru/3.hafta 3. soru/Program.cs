using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.hafta_3.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı üretmek istiyorsanız belirtin");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[] pozitif = new int[sayi];
            int[] negatif = new int[sayi];
            int[] sifir = new int[sayi];
            Random rnd = new Random();
            int a;
            for (int i=0; i<sayi;i++)
            {
                a = rnd.Next(-100, 100);
                if(a>0)
                {
                    pozitif[i] = a;
                }
                else if(a<0)
                {
                    negatif[i] = a;
                }
                else
                {
                    sifir[i] = a;
                }
            }
            Console.WriteLine("Pozitif olanlar");
            foreach(int m in pozitif)
            {
                if(m>0)
                Console.WriteLine(m);
            }
            Console.WriteLine("Negatif olanlar");
            foreach (int m in negatif)
            {
                if(m<0)
                Console.WriteLine(m);
            }
            Console.WriteLine("sifir olanlar");
            foreach (int m in sifir)
            {
                Console.WriteLine(m);
            }
            Console.Read();
        }
    }
}
