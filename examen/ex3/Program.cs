using System;

namespace ex._1._3
{
    class program
    {
        public static double FindMax(double[] array)
        {
            double maxNumber = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                    maxNumber = array[i];
            }
            return maxNumber;
        }
        private static void Main(string[] args)
        {
            double[] numbers = { 2.71, 3.14, -18.99, 10.2, 9.5, 1 };
            double maxNumber = FindMax(numbers);
            Console.WriteLine(maxNumber);
        }
    }
}