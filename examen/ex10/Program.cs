using System;

namespace ex._1._10
{
    class program
    {
        public static bool FindNumberInArray(int[] ints, int number)
        {
            foreach (int i in ints) 
                if (i == number)
                    return true;
            return false;
        }
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 9, 8, 15, -24, 660 };
            int needNumber = 0;
            bool flag = FindNumberInArray(numbers, needNumber);
            Console.WriteLine(flag);
        }
    }
}