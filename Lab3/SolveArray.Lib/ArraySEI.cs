namespace SolveArray.Lib
{
    public class ArraySEI
    {
        public int CalculateMinimum(int[] arr)
        {
            return arr.Min();
        }

        public int CalculateMaximum(int[] arr)
        {
            return arr.Max();
        }

        public double CalculateAverage(int[] arr)
        {
            return Math.Round(arr.Average(), 2);
        }

        public double CalculateMedian(int[] arr)
        {
            var sortedArray = arr.OrderBy(x => x).ToArray();

            int middleIndex = arr.Length / 2;

            // находим медиану 
            double median;
            if (sortedArray.Length % 2 == 0)
            {
                median = (sortedArray[middleIndex - 1] + sortedArray[middleIndex]) / 2.0;
            }
            else
            {
                median = sortedArray[middleIndex];
            }
            return Math.Round(median, 2);
        }

        public int CalculateNumberOfEven(int[] arr)
        {
            int count = 0;

            foreach (double elem in arr)
            {
                if (elem % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int CalculateNumberOfOdd(int[] arr)
        {
            int count = 0;

            foreach (int elem in arr)
            {
                if (elem % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int SignsOfDivisibilityByTwo(int[] arr)
        {
            int count = 0;

            foreach (int elem in arr)
            {
                if (elem % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int SignsOfDivisibilityByThree(int[] arr)
        {
            int count = 0;

            foreach (int elem in arr)
            {
                if (elem % 3 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int SignsOfDivisibilityByFive(int[] arr)
        {
            int count = 0;

            foreach (int elem in arr)
            {
                if (elem % 5 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public int SignsOfDivisibilityByTen(int[] arr)
        {
            int count = 0;

            foreach (int elem in arr)
            {
                if (elem % 10 == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
