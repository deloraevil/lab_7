using System;
using System.Collections.Generic;
using odintsov;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinearEquation a = new LinearEquation();
                List<float> qwe = a.a_linear_equation(2, 6);
                foreach (var item in qwe)
                {
                    Console.WriteLine(item + " ");
                }


                QuadraticEquation b = new QuadraticEquation();
                List<float> qwe2 = b.solve(1, 3, -4);
                foreach (var item in qwe2)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();

                OdintsovLog.I().log("test");
                OdintsovLog.I().log("test2");
                OdintsovLog.I().write();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
