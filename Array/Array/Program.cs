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

            Console.Write("sınıf mevcudu ?:");
            int mevcut = Convert.ToInt32(Console.ReadLine());
            string[] ogrenciler = new string[mevcut];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.Write("{0}. öğrencini ismi: ",i);
                ogrenciler[i] = Console.ReadLine();

            }

            Console.Clear();

            Console.WriteLine("öğrenciler : \n");

            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


            
        }
    }
}
