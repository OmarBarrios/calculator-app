using System;

namespace BackCalculator
{
    public class Calculator : MarshalByRefObject, ICalculator
    {
        double number;

        public Calculator() 
        {
            this.number = 0;
        }

        double ICalculator.Divide(double numberOne, double numberTwo)
        {
            if (numberTwo <= 0)
                throw new ArgumentOutOfRangeException();

            this.number = numberOne / numberTwo;
            return this.number;
        }

        double ICalculator.Multiply(double numberOne, double numberTwo)
        {
            this.number = numberOne * numberTwo;
            return this.number;
        }

        double ICalculator.Subtracts(double numberOne, double numberTwo)
        {
            this.number = numberOne - numberTwo;
            return this.number;
        }

        double ICalculator.Sum(double numberOne, double numberTwo)
        {
            this.number = numberOne + numberTwo;
            return this.number;
        }

        int ICalculator.Squared(int number)
        {
            return (number * number);
        }

        double ICalculator.DivideByItself(double numberTwo)
        {
            ICalculator result = new Calculator();
            this.number = result.Divide(1, numberTwo);

            return this.number;
        }

        double ICalculator.SquaredRoot(double numberOne)
        {
            this.number = Math.Sqrt(numberOne);
            return this.number;
        }
    }
}
