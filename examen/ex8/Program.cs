using System;

namespace ex._1._8
{
    class program
    {
        public static int FindNumber(int[] ints, int number)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == number)
                    return i;
            }
            return -1;
        }
        private static void Main(string[] args)
        {
            int[] numbers = { 98, 10, -50, 6, 98, 7, 5, 22 };
            int numberToFind = 8;
            int indexOfNumber = FindNumber(numbers, numberToFind);
            Console.WriteLine(indexOfNumber);
        }
    }
}