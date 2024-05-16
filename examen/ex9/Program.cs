using System;

namespace ex._1._9
{
    class program
    {
        public static double[] GenerateArray(double[] doubles, double number)
        {
            int count = 0;
            double[] newArray = new double[1];
            foreach (double d in doubles) 
                if (d > number)
                {
                    count++;
                    Array.Resize(ref newArray, count);
                    newArray[count-1] = d;
                }
            return newArray;
        }
        private static void Main()
        {
            double[] numbers = { 1.1, 9.9, 2.71, 3, 14, 5.111, 6.432 };
            double numberForCheck = 2.8;
            double[] newNumbers = GenerateArray(numbers, numberForCheck);
            foreach (double i in newNumbers)
                Console.Write(i + " ");
        }
    }
}