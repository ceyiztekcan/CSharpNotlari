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
            //while (true)
            //{
            //    counter++;
            //    Console.WriteLine("Tahminin ne: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin == rasgelesayi)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("tebrikler {0}adimda bildin", counter);
            //Console.ReadKey();
            #endregion
            #region 2li tabandan 10lu tabana
            //string bin = " ";
            //int sayi, kalan;
            //Console.WriteLine("sayiyi girin : ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //while (sayi != 0)
            //{
            //    kalan = sayi % 2;
            //    sayi = sayi / 2;
            //    bin = kalan.ToString() + bin;

            //}
            //Console.WriteLine("2'li taban : {0} :", bin);
            //Console.ReadKey();
            #endregion

            #region kullaniciSinirliİslemler


            //    bool devam = true;
            //while (devam)
            //{
            //    Console.Write("1.sayi :");
            //    double sayi1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("2.sayi :");
            //    double sayi2 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("İşlem seç");
            //    char islem = Convert.ToChar(Console.ReadLine());
            //    double sonuc;



            //    switch (islem)
            //    {
            //        case '+':
            //            sonuc = sayi1 + sayi2;
            //            break;
            //        case '-':
            //            sonuc = sayi1 - sayi2;
            //            break;
            //        case '*':
            //            sonuc = sayi1 * sayi2;
            //            break;
            //        case '/':
            //            sonuc = sayi1 / sayi2;
            //            break;
            //        default:
            //            Console.WriteLine("geçersiz işlem");
            //            sonuc = 0;
            //            break;
            //    }
            //    Console.WriteLine("sonuc: " + sonuc);
            //    Console.WriteLine("devam ? (evet)");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "evet")
            //    {
            //        devam = true;


            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}
            //Console.WriteLine("bye");
            //Console.ReadKey();
            #endregion
            #region TahminEtVer1.0.0.1
            //Console.WriteLine("[1-100] arası sayı tahmin et");
            //Random rnd = new Random();
            //int rasgelesayi = rnd.Next(1, 101);
            //int tahmin, counter = 0;
            //while (true)
            //{
            //    counter++;
            //    Console.WriteLine("Tahminin ne: ");
            //    tahmin = Convert.ToInt32(Console.ReadLine());
            //    if (tahmin < rasgelesayi)
            //    {
            //        Console.WriteLine("daha büyük sayı söyle");

            //    }
            //    else if (tahmin > rasgelesayi)
            //    {
            //        Console.WriteLine("daha küçük sayı söyle");

            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("tebrikler {0}adimda bildin", counter);
            //Console.ReadKey();
            #endregion
            //            #region TekSayiToplamYaDaCarpımBulma
            //            long toplam = 0, carpim = 1,
            //            int sayi,  sayac =1;
            //            char islem;
            //            Console.WriteLine("sayi giriniz :");
            //            sayi = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("işlem secin :");
            //            islem = Convert.ToChar(Console.ReadLine());
            //            while (sayac<=sayi)
            //            {
            //                if (sayac % 2 == 1)
            //                {
            //                    toplam += sayac;
            //                    carpim *= sayac;

            //                }
            //                sayac++;
            //                if (islem=='+')
            //                {
            //                    Console.WriteLine(toplam);
            //                }
            //                else if (islem=='*')
            //                {
            //                    Console.WriteLine(carpim);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("yanlış giriş");

            //                }
            //                Console.ReadKey();
            //            }

            //        }
        }
    }
