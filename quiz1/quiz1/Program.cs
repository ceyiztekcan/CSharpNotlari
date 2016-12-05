using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //kare
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i==0 ||i== 4 || j==0 ||j==4)
            //        {
            //            Console.Write("* ");

            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //dikdortgen
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        if (i == 0 || i == 4 || j == 0 || j == 7)
            //        {
            //            Console.Write("* ");

            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //paralelkenar

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if (i == 0 && j >= 2)
            //        {
            //            Console.Write("*");

            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //        if (i == 1 && (j == 1 || j == 4))
            //        {
            //            Console.Write("*");

            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //        if (i == 2 && j <= 3)
            //        {
            //            Console.Write("*");

            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i == 0 && j >= 2)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    if (i == 1 && (j == 1 || j == 4))
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    if (i == 2 && j <= 3)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
