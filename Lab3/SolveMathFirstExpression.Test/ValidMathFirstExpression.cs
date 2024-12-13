using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    public class ValidMathFirstExpression
    {
      
        [Test]
        public void TestCalculateFirstExpression()
        {
            double x = 2.9;
            double y = 0.3;

            MathFirstExpression ds = new MathFirstExpression();

            double result = ds.CalculateFirstExpression(x, y);

            double true_val = 21.881;

            Assert.AreEqual(true_val, result);
        }
    }
}