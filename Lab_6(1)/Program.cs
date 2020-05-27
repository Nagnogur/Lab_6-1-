using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            ExponentialFunction exp1 = new ExponentialFunction(Math.E);
            exp1.Calculate();
            exp1.SetVariable(3);
            exp1.Calculate();
            Console.WriteLine("\n");
            DerivativeEponentialFunction der = new DerivativeEponentialFunction(exp1);
            der.Calculate();
            der.SetVariable(3);
            der.Calculate();
            Console.ReadKey();
        }
    }
}
