using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    // y = a * cosh(ax)
    class DerivativeHyperbolicSinus : HyperbolicCosine
    {
        public DerivativeHyperbolicSinus(HyperbolicSinus sinh)
        {
            this.A = sinh.A;
        }
        public override void Calculate()
        {
            if (Double.IsNaN(Variable))
            {
                Console.WriteLine("y = " + A + " * cosh(" + A + " * x)");
            }
            else
            {
                Console.WriteLine("x = " + Variable);
                double result = A * Math.Cosh(A * Variable);
                Console.WriteLine("y = " + result);
            }
        }
    }
}
