namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(double x, double y)
        {
            double x3 = Math.Pow(x, 3);
            double x2 = Math.Pow(x, 2);
            double y2 = Math.Pow(y, 2);
            double ex = Math.Pow(Math.E, x);
            double first_argument = y2 + Math.Cos(x3) + (12 * x * y) - (3 * x2);
            double second_argument = Math.Cos(x3 + 3) + (18 * y) - 1;
            double z = ex - (first_argument / second_argument);

            return Math.Round(z, 3);
        }
    }
}
