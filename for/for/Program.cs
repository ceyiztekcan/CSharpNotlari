using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            #region for
            //int n = 5, fact = 1;
            //for (int i = 1; i <=n; i++)
            //{
            //    fact *= i;
            //}
            //Console.WriteLine(fact);
            //Console.ReadKey();
            #endregion
            #region BirdenFazlaKontrol
            bool durum = true;
            for (int i = 0; durum == true && i < 100; i++)
            {
                if (i*2 > 20)
                {
                    durum = false;
                }
                else
                {
                    Console.WriteLine("{0} iken devam", i);
                }
            }
            Console.ReadKey();
            #endregion
            #region BreakContinue
            //for (int i = 0; i <100; i++)
            //{
            //    if (i*2 <20)
            //    {
            //        //break; döngüyü sonlandırır
            //        //continue;bir sonraki değere geçirir
            //    }
            //    Console.WriteLine("{0} devam", i);
            //}
            #endregion
            #region[1,n] aralığındakiSayılarınToplamı
            //int n = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i = 1; i < length; i++)
            //{

            //}
            #endregion
            #region İcİceFor
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

        }
    }
}
