using BackCalculator;
namespace TestCalculatorProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MethodSum()
        {
            // arrange
            double numberOne = 22.3;
            double numberTwo = 4.2;
            double expected = 26.5;
            ICalculator calculator = new Calculator();
            //act
            double result = calculator.Sum(numberOne, numberTwo);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        public void MethodSubstract()
        {
            // arrange
            double numberOne = 10.6;
            double numberTwo = 5.3;
            double expected = 5.3;
            ICalculator calculator = new Calculator();
            //act
            double result = calculator.Subtracts(numberOne, numberTwo);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        public void MethodMultiply()
        {
            // arrange
            double numberOne = 8;
            double numberTwo = 8;
            double expected = 64;
            ICalculator calculator = new Calculator();
            //act
            double result = calculator.Multiply(numberOne, numberTwo);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}