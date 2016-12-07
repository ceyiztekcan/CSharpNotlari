using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine(numbers.Count);
            //Console.Clear();
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine("{0} = {1}", i, numbers[i]);
            //}

            //int[] array = new int[2];
            //array[0] = 3;
            //array[1] = 5;
            //List<int> list = new List<int>(array);
            //Console.WriteLine("{0} tane eleman yazdıracağım", list.Count);
            //foreach (var elm in list)
            //{
            //    Console.Write(elm + " ");
            //}

            //List<int> numbers = new List<int>(new int[] { 1903, 1904, 1905, 1907 });
            //int index = numbers.IndexOf(1907);

            //List<string> isimler = new List<string>();
            //isimler.AddRange(new string[] { "Ali", "Veli", "Ayşe", "Fatma" });
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);

            //}
            //List<int> numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.AddRange(new int[] { 8, 10, 13, 3, 8 });

            //numbers.RemoveAt(0);//girilen index silinir
            //numbers.Remove(8);//girilen değer silinir birden fazla varsa ilki silinir
            //numbers.RemoveRange(3, 2); // aralık siler

            //bool varmi = true;

            //while (varmi)
            //{
            //    if (numbers.Contains(8))
            //    {
            //        numbers.Remove(8);
            //    }
            //    else
            //    {
            //        varmi = false;
            //    }
            //}

            //var result = numbers.Find(i => i > 5); //5 den büyük ilk değer döner
            //var result = numbers.FindAll(i => i > 5);// 5 den büyük tüm değerler döner
            //var result = numbers.FindAll(i => i > 5).Count();// 5 den büyük ELEMANLARIN ADEDİ döner
            //numbers.Sort();
            ////numbers.Reverse();

            //foreach (var item in numbers)
            //{

            //    Console.WriteLine("\n\t" + item);
            //}

            //List<char> harfler = new List<char>();
            //for (char i = 'a'; i <='z'; i++)
            //{
            //    harfler.Add(i);
            //}
            //harfler.Sort();
            //harfler.Reverse();
            ////foreach (var item in harfler)
            ////{
            ////    Console.Write(item +" ");

            ////}
            //for (int i = 0; i <harfler.Count; i++)
            //{
            //    Console.Write(harfler[i] + " ");
            //}
            List<string> isimler = new List<string>();
            isimler.Add("Hakan");
            isimler.AddRange(new string[] { "irfan", "aytekin", "cemal", "merve", "yankı" });
            isimler.Sort();
            //isimler.Reverse();
            foreach (var item in isimler)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}
