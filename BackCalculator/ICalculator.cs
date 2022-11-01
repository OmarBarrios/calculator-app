
namespace BackCalculator
{
    public interface ICalculator
    {
        double Sum(double numberOne, double numberTwo);
        double Subtracts(double numberOne, double numberTwo);
        double Multiply(double numberOne, double numberTwo);
        double Divide(double numberOne, double numberTwo);
        int Squared(int number);
        double DivideByItself(double numberTwo);
        double SquaredRoot(double number);

    }
}
