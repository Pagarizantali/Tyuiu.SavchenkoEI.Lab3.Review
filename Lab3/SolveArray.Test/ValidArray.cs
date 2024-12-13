using SolveArray.Lib;

namespace SolveArray.Test
{
    public class ValidArray
    {
        [Test]
        public void TestCalculateMinimum()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.CalculateMinimum(arr);

            int true_val = 6;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateMaximum()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.CalculateMaximum(arr);

            int true_val = 15;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateAverage()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            double result = ds.CalculateAverage(arr);

            double true_val = 9.5;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateMedian()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 9, 15, 6];

            double result = ds.CalculateMedian(arr);

            double true_val = 9;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateNumberOfEven()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.CalculateNumberOfEven(arr);

            int true_val = 2;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestCalculateNumberOfOdd()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.CalculateNumberOfOdd(arr);

            int true_val = 2;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestSignsOfDivisibilityByTwo()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.SignsOfDivisibilityByTwo(arr);

            int true_val = 2;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestSignsOfDivisibilityByThree()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.SignsOfDivisibilityByThree(arr);

            int true_val = 2;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestSignsOfDivisibilityByFive()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.SignsOfDivisibilityByFive(arr);

            int true_val = 2;

            Assert.AreEqual(true_val, result);
        }

        [Test]
        public void TestSignsOfDivisibilityByTen()
        {
            ArraySEI ds = new ArraySEI();

            int[] arr = [7, 10, 15, 6];

            int result = ds.SignsOfDivisibilityByTen(arr);

            int true_val = 1;

            Assert.AreEqual(true_val, result);
        }
    }
}