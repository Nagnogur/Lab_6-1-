using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1_
{
    abstract class SingleVariableFunction
    {
        double variable = double.NaN;

        public double Variable 
        {
            get { return variable; }
            set { variable = value; } 
        }

        public abstract void Calculate();

        public abstract void SetVariable(double value);
    }
}
