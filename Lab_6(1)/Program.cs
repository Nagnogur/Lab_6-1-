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
            Console.WriteLine("Enter 0 to exit or choose type of function below:\n1 - y=a^(bx); 2 - y=(a^(bx))'; 3 - y=sinh(ax); 4 - y=(sinh(ax))'; 5 - y=cosh(ax); 6 - y=(cosh(ax))'");
            int type;
            while (true)
            {
                type = Convert.ToInt32(Console.ReadLine());
                switch (type)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter a and b(optional).");
                            double[] a = Console.ReadLine().Split().Select(s => double.Parse(s)).ToArray();
                            ExponentialFunction exp;
                            if (a.Length > 1)
                            {
                                exp = new ExponentialFunction(a[0], a[1]);
                            }
                            else
                            {
                                exp = new ExponentialFunction(a[0]);
                            }
                            Console.WriteLine("Enter variable value");
                            exp.SetVariable(Convert.ToDouble(Console.ReadLine()));
                            exp.Calculate();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter a and b(optional).");
                            double[] a = Console.ReadLine().Split().Select(s => double.Parse(s)).ToArray();
                            ExponentialFunction exp;
                            if (a.Length > 1)
                            {
                                exp = new ExponentialFunction(a[0], a[1]);
                            }
                            else
                            {
                                exp = new ExponentialFunction(a[0]);
                            }
                            Console.WriteLine("Enter variable value");
                            DerivativeEponentialFunction dexp = new DerivativeEponentialFunction(exp);
                            dexp.SetVariable(Convert.ToDouble(Console.ReadLine()));
                            dexp.Calculate();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter a.");
                            double a = Convert.ToDouble(Console.ReadLine());
                            HyperbolicSinus sinh = new HyperbolicSinus(a);
                            Console.WriteLine("Enter variable value");
                            sinh.SetVariable(Convert.ToDouble(Console.ReadLine()));
                            sinh.Calculate();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter a.");
                            double a = Convert.ToDouble(Console.ReadLine());
                            DerivativeHyperbolicSinus dsinh = new DerivativeHyperbolicSinus(new HyperbolicSinus(a));
                            Console.WriteLine("Enter variable value");
                            dsinh.SetVariable(Convert.ToDouble(Console.ReadLine()));
                            dsinh.Calculate();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter a.");
                            double a = Convert.ToDouble(Console.ReadLine());
                            HyperbolicCosine cosh = new HyperbolicCosine(a);
                            Console.WriteLine("Enter variable value");
                            cosh.SetVariable(Convert.ToDouble(Console.ReadLine()));
                            cosh.Calculate();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter a.");
                            double a = Convert.ToDouble(Console.ReadLine());
                            DerivativeHyperbolicCosine dcosh = new DerivativeHyperbolicCosine(new HyperbolicCosine(a));
                            Console.WriteLine("Enter variable value");
                            dcosh.SetVariable(Convert.ToDouble(Console.ReadLine()));
                            dcosh.Calculate();
                            break;
                        }
                }
            }
        }
    }
}
