using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Addition : Operation
    {
        public double calculate(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
