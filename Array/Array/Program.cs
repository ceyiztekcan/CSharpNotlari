using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[3];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            //Console.ReadKey();

            //Console.Write("sınıf mevcudu ?:");
            //int mevcut = Convert.ToInt32(Console.ReadLine());
            //string[] ogrenciler = new string[mevcut];

            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.Write("{0}. öğrencini ismi: ",i);
            //    ogrenciler[i] = Console.ReadLine();

            //}

            //Console.Clear();

            //Console.WriteLine("öğrenciler : \n");

            //foreach (var item in ogrenciler)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //Random random = new Random();
            //int pozitif = 0, negatif =0, sifir = 0;

            //Console.WriteLine("kaç sayı olsun :?");
            //int boyut = Convert.ToInt32(Console.ReadLine());
            //int [] array = new int[boyut];
            //Console.Clear();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(-100, 101);


            //}

            //foreach (var sayi in array)
            //{
            //    Console.WriteLine(sayi);
            //    if (sayi>0)
            //    {
            //        pozitif++;

            //    }
            //    else if (sayi<0)
            //    {
            //        negatif++;
            //    }
            //    else
            //    {
            //        sifir++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("{0} tane pozitif var ", pozitif);
            //Console.WriteLine("{0} tane negatif var ", negatif);
            //Console.WriteLine("{0} tane sıfır var ", sifir);

            //string[] gunler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            //bool devam = true;
            //while (devam)
            //{


            //    Console.WriteLine("Haftanın kaçıncı günü :?");
            //    int sira = Convert.ToInt16(Console.ReadLine());

            //    if (sira <= 7 && sira >= 1)
            //    {
            //        Console.WriteLine(gunler[sira - 1]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("gecersiz");
            //    }
            //    Console.WriteLine("devam ? :(e)");
            //    char c = Convert.ToChar(Console.ReadLine());
            //    if (c == 'e')
            //    {
            //        devam = true;
            //        Console.Clear();
            //    }
            //    else
            //    {
            //        devam = false;
            //    }
            //}

            //int[,] sinavlar = new int[2, 3];

            //sinavlar[0, 0] = 1;
            //sinavlar[1, 0] = 20;
            //sinavlar[0, 1] = 2;
            //sinavlar[1, 1] = 40;
            //sinavlar[0, 2] = 3;
            //sinavlar[1, 2] = 60;
            //for (int i = 0; i <3; i++)

            //{
            //    Console.WriteLine(sinavlar[0, i] + "-" + sinavlar[1, i]);
            //}
            int i = 0;
            do
            {
                Console.WriteLine("yaz");
            } while (i!=0);
        }
    }
}
