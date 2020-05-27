using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    // y = a^(bx)
    class ExponentialFunction : SingleVariableFunction
    {
        public ExponentialFunction() { }
        double a = double.NaN, b = 1;

        public double A
        {
            get { return a; }
        }
        public double B
        {
            get { return b; }
        }
        public ExponentialFunction(double a)
        {
            this.Input(a);
        }
        public ExponentialFunction(double a, double b)
        {
            this.Input(a, b);
        }
        private void Input(double a, double b)
        {
            if (a > 0 && a != 1)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
        private void Input(double a)
        {
            if (a > 0 && a != 1)
            {
                this.a = a;
            }
            else
            {
                Console.WriteLine("Wrong input!");
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
                Console.WriteLine("y = " + a + "^(" + b + "x)");
            }
            else
            {
                Console.WriteLine("x = " + Variable);
                double result = Math.Pow(a, b * Variable);
                Console.WriteLine("y = " + result);
            }
        }
        public override void SetVariable(double value)
        {
            this.Variable = value;
        }
    }
}
