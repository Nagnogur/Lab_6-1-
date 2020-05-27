using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    // y = a^(bx) * ln(a) * b
    class DerivativeEponentialFunction : ExponentialFunction
    {
        double a = double.NaN, b = 1;
        
        public DerivativeEponentialFunction(ExponentialFunction exp)
        {
            if (Double.IsNaN(exp.A))
            {
                Console.WriteLine("a and b are not declared");
            }
            else
            {
                a = exp.A;
                b = exp.B;
            }
        }

        public override void Calculate()
        {
            if (Double.IsNaN(a))
            {
                Console.WriteLine("a and b are not declared");
            }
            else if (Double.IsNaN(Variable))
            {
                Console.WriteLine("y = " + b + " * " + a + "^(" + b + "x) * ln(" + a + ")");
            }
            else
            {
                Console.WriteLine("x = " + Variable);
                double result = Math.Pow(a, b * Variable) * Math.Log(a) * b;
                Console.WriteLine("y = " + result);
            }
        }
        public override void SetVariable(double value)
        {
            this.Variable = value;
        }
    }
}
