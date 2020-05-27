using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    // y = cosh(ax)
    class HyperbolicCosine : SingleVariableFunction
    {
        double a;
        public double A
        {
            get { return a; }
            set { this.a = value; }
        }
        public HyperbolicCosine()
        {
            this.a = 1;
        }

        public HyperbolicCosine(double a)
        {
            this.a = a;
        }

        public override void Calculate()
        {
            if (Double.IsNaN(Variable))
            {
                Console.WriteLine("y = cosh(" + a + " * x)");
            }
            else
            {
                Console.WriteLine("x = " + Variable);
                double result = Math.Cosh(a * Variable);
                Console.WriteLine("y = " + result);
            }
        }

        public override void SetVariable(double value)
        {
            this.Variable = value;
        }
    }
}
