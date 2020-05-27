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
            ExponentialFunction exp1 = new ExponentialFunction(Math.E, 3);
            exp1.Calculate();
            exp1.SetVariable(3);
            exp1.Calculate();
            Console.WriteLine("\n");
            DerivativeEponentialFunction der = new DerivativeEponentialFunction(exp1);
            der.Calculate();
            der.SetVariable(3);
            der.Calculate();

            HyperbolicSinus h1 = new HyperbolicSinus();
            h1.Calculate();
            h1.SetVariable(0.5);
            h1.Calculate();
            Console.WriteLine("\n");

            HyperbolicCosine h2 = new HyperbolicCosine(4);
            h2.Calculate();
            h2.SetVariable(0.5);
            h2.Calculate();
            Console.WriteLine("\n");

            DerivativeHyperbolicSinus d1 = new DerivativeHyperbolicSinus(h1);
            d1.Calculate();
            d1.SetVariable(1);
            d1.Calculate();
            Console.WriteLine("\n");

            DerivativeHyperbolicCosine d2 = new DerivativeHyperbolicCosine(h2);
            d2.Calculate();
            d2.SetVariable(5);
            d2.Calculate();
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
