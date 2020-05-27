using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    // y = sinh(ax)
    class HyperbolicSinus : SingleVariableFunction
    {
        double a;
        public double A
        {
            get { return a; }
        }
        public HyperbolicSinus()
        {
            this.a = 1;
        }

        public HyperbolicSinus(double a)
        {
            this.a = a;
        }

        public override void Calculate()
        {
            if (Double.IsNaN(Variable))
            {
                Console.WriteLine("y = sinh(" + a + " * x)");
            }
            else
            {
                Console.WriteLine("x = " + Variable);
                double result = Math.Sinh(a * Variable);
                Console.WriteLine("y = " + result);
            }
        }

        public override void SetVariable(double value)
        {
            this.Variable = value;
        }
    }
}
