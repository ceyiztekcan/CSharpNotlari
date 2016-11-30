using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [1,10]SayıTahmin
            //Console.WriteLine("1-10 arası sayı tahmin etme oyunu ");
            //Random rnd = new Random();
            //int r = rnd.Next(1, 11);
            //int sayac = 0, sayi;
            //while (true)
            //{
            //    sayac++;
            //    Console.Write("tahminin ne : ");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == r)
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine("{0}. tahminde bildiniz ", sayac);
            //Console.ReadKey();
            #endregion
            #region TekCift
            char devam = 'e';
            while (devam == 'e')
            {

                Console.Write("bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("{0} sayısı çifttir", sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı tektir", sayi);
                }
                Console.Write("devam edelim mi?(e)");
                 devam = Convert.ToChar(Console.ReadLine());
               
               
            }
            Console.ReadKey();
            #endregion
        }
    }
}