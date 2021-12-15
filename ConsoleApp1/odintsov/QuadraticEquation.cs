using System;
using System.Collections.Generic;
using System.Text;
using core;

namespace odintsov
{
    class QuadraticEquation:LinearEquation, EquationInterface
    {
        public List<float> solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return a_linear_equation(b, c);

            }
            double d = discriminant(a, b, c);
            if (d < 0)
            {
                throw new Exception("Rootless");
            }

            if (d == 0)
            {
                return this.x = new List<float>() { (-b) / 2 * a };
            }
            d = Math.Sqrt(d);
            return this.x = new List<float>() { ((-b) + (float)d) / (2 * a), ((-b) - (float)d) / (2 * a) };
        }


        /*public double[] b_quadratic_equation(double a, double b, double c)
        {
            if (a == 0)
            {
               return a_linear_equation(b, c);
             
            }
            double d = discriminant(a, b, c);
            if (d < 0)
            {
                throw new Exception("Rootless");
            }

            if (d == 0)
            {
                return this.x = new double[] { (-b) / 2 * a };
            }
            d = Math.Sqrt(d);
            return this.x = new double[] { ((-b) + d) / (2 * a), ((-b) - d) / (2 * a) };
        }*/

        protected double discriminant(float a, float b, float c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

    }
}
