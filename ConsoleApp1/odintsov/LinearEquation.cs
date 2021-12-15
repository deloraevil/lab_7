using System;
using System.Collections.Generic;
using System.Text;

namespace odintsov
{
    class LinearEquation
    {
        protected List<float> x;

        public List<float> a_linear_equation(float a, float b)
        {
            if (a == 0)
            {
                throw new Exception("Error: a = 0");
            }
            //return this.x = new List<float> { (-b) / a };
            return this.x = new List<float>() { (-b) / a };

        }
    }
}
