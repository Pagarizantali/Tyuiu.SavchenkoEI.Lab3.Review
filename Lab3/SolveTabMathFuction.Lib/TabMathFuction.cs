namespace SolveTabMathFuction.Lib
{
    public class TabMathFuction
    {
        public double[][] CalculateTabMathFuction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
            {
                int temp = startValue;
                startValue = stopValue;
                stopValue = temp;
            }

            int n = stopValue - startValue + 1;

            double[][] result = new double[n][];

            double x = startValue;

            for (int i = 0; i < n; i++)
            {
                double x2 = Math.Pow(x, 2);
                result[i] = new double[2];
                result[i][0] = x;
                double f_a = (Math.Cos(x2) + Math.Sin(x2)) / (Math.Sin(x) + 1);
                double s_a = (Math.Sin(x2) - Math.Cos(x)) / (Math.Cos(x) + 15);
                result[i][1] = Math.Round(f_a - s_a, 2);
                x++;
            }

            return result;
        }
    }
}
