using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    // y = a * sinh(ax)
    class DerivativeHyperbolicCosine : HyperbolicSinus
    {
        public DerivativeHyperbolicCosine(HyperbolicCosine cosh)
        {
            this.A = cosh.A;
        }
        public override void Calculate()
        {
            if (Double.IsNaN(Variable))
            {
                Console.WriteLine("y = " + A + " * sinh(" + A + " * x)");
            }
            else
            {
                Console.WriteLine("x = " + Variable);
                double result = A * Math.Sinh(A * Variable);
                Console.WriteLine("y = " + result);
            }
        }
    }
}
