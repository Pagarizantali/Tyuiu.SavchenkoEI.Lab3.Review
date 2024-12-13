using SolveTabMathFuction.Lib;

namespace SolveTabMathFuction.Test
{
    public class ValidTabMathFuction
    {
       
        [Test]
        public void TestCalculateTabMathFuction()
        {
            TabMathFuction ds = new TabMathFuction();

            int startValue = 1;
            int stopValue = 4;

            double[][] true_result = [[1, 0.73], [2, -0.72], [3, -0.54], [4, -5.15]];

            double[][] result = ds.CalculateTabMathFuction(startValue, stopValue);

            Assert.AreEqual(result, true_result);
        }
    }
}