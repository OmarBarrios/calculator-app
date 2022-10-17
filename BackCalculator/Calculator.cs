using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCalculator
{
    public class Calculator : ICalculator
    {
        double number;
        public Calculator() 
        {
            this.number = 0;
        }

        double ICalculator.dividir(double numberOne, double numberTwo)
        {
            if (numberTwo <= 0)
                throw new ArgumentOutOfRangeException();

            this.number = numberOne / numberTwo;
            return this.number;
        }

        double ICalculator.multiply(double numberOne, double numberTwo)
        {
            this.number = numberOne * numberTwo;
            return this.number;
        }

        double ICalculator.subtracts(double numberOne, double numberTwo)
        {
            this.number = numberOne - numberTwo;
            return this.number;
        }

        double ICalculator.sum(double numberOne, double numberTwo)
        {
            this.number = numberOne + numberTwo;
            return this.number;
        }
    }
}
