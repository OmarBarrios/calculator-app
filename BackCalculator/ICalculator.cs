using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackCalculator
{
    public interface ICalculator
    {
        double sum(double numberOne, double numberTwo);
        double subtracts(double numberOne, double numberTwo);
        double multiply(double numberOne, double numberTwo);
        double dividir(double numberOne, double numberTwo);
    }
}
