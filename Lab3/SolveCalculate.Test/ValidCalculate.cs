using SolveCalculate.Lib;

namespace SolveCalculate.Test
{
    public class ValidCalculate
    {
        [Test]
        public void TestCalculateSumma()
        {
            double a = 5;
            double b = 10;

            Calculate ds = new Calculate();

            double result = ds.CalculateSumma(a, b);

            double true_val = 15;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateDifference()
        {
            double a = 5;
            double b = 10;

            Calculate ds = new Calculate();

            double result = ds.CalculateDifference(a, b);

            double true_val = -5;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateMultiplication()
        {
            double a = -5;
            double b = 10;

            Calculate ds = new Calculate();

            double result = ds.CalculateMultiplication(a, b);

            double true_val = -50;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateQuotient()
        {
            double a = 5;
            double b = -10;

            Calculate ds = new Calculate();

            double result = ds.CalculateQuotient(a, b);

            double true_val = -0.5;

            Assert.AreEqual(true_val, result);
        }

    }
}