namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double CalculateSecondExpression(double x)
        {

            double x2 = Math.Pow(x, 2);
            double f_a = (Math.Cos(x2) + Math.Sin(x2)) / (Math.Sin(x) + 1);
            double s_a = (Math.Sin(x2) - Math.Cos(x)) / (Math.Cos(x) + 15);
            double result = Math.Round(f_a - s_a, 2);
           
            return result;
        }
    }
}
