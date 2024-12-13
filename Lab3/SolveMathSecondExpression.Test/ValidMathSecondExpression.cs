using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    public class ValidMathSecondExpression
    {
       
        [Test]
        public void TestCalculateSecondExpression()
        {
            MathSecondExpression ds = new MathSecondExpression();

            double x = 3;

            double true_result = -0.54;

            double result = ds.CalculateSecondExpression(x);

            Assert.AreEqual(result, true_result);
        }
    }
}