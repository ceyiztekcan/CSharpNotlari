using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            #region[0,9] sayilari yaz
            //int counter = 0;
            //while(counter < 10)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
            //Console.ReadKey();
            #endregion
            #region[1-n] sayıları topla

            //int counter = 1, toplam = 0, n=10 ;
            //while(counter <= n)
            //{
            //    toplam += counter;
            //    counter++;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadKey();
            #endregion

            #region faktoriyel

            //int counter = 1, facto = 1, n = 5;
            //while (counter <= n)
            //{
            //    facto *= counter;
            //    counter++;
            //}
            //Console.WriteLine(facto);
            //Console.ReadKey();
            #endregion

            #region TahminEt
            //Console.WriteLine("[1-10] arası sayı tahmin et");
            //Random rnd = new Random();
            //int rasgelesayi = rnd.Next(1, 11);
            //int tahmin, counter = 0;
            //while(true)
            //{
            //    counter++;
            //    Console.WriteLine("Tahminin ne: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin== rasgelesayi)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("tebrikler {0}adimda bildin", counter);
            //Console.ReadKey();
            #endregion
            #region 2li tabandan 10lu tabana
            string bin = " ";
            int sayi , kalan;
            Console.WriteLine("sayiyi girin : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi !=0)
            {
                kalan = sayi % 2;
                sayi = sayi / 2;
                bin = kalan.ToString() + bin;
            
            }
            Console.WriteLine("2'li taban : {0} :" , bin);
            Console.ReadKey();
            #endregion
        }

    }
}
