namespace SolveCalculate.Lib
{
    public class Calculate
    {
        public double CalculateSumma(double a, double b)
        {
            return Math.Round(a + b, 2);
        }

        public double CalculateDifference(double a, double b)
        {
            return Math.Round(a - b, 2);

        }

        public double CalculateMultiplication(double a, double b)
        {
            return Math.Round(a * b, 2);

        }

        public double CalculateQuotient(double a, double b)
        {
            return Math.Round(a / b, 2);

        }
    }
}
