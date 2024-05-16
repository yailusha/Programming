using System;

namespace ex._1._4
{
    class program
    {
        public static int FindMin(double[] doubles)
        {
            double minNumber = doubles[0];
            int index = 0;
            for (int i = 1; i < doubles.Length; i++)
            {
                if (minNumber > doubles[i])
                {
                    minNumber = doubles[i];
                    index = i;
                }
            }
            return index;
        }
        private static void Main(string[] args)
        {
            double[] numbers = { 2.71, 3.14, -18.99, 10.2, 9.5, 1 };
            double minNumber = FindMin(numbers);
            Console.WriteLine(minNumber);
        }
    }
}