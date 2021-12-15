using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                A a = new A();
                double qwe = a.a_linear_equation(2, 6);
                Console.WriteLine(qwe);


                B b = new B();
                double[] qwe2 = b.b_quadratic_equation(1, -8, 7);
                Console.WriteLine(qwe2[0] + " " + qwe2[1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
