using System;

namespace ex._1._7
{
    class program
    {
        public static int[] FillArray(int[] ints)
        {
            Random rnd = new Random();
            for (int i = 0; i < ints.Length; i++)
                ints[i] = rnd.Next(-25, 126);
            return ints;
        }
        private static void Main(string[] args)
        {
            int[] numbers = new int[10];
            numbers = FillArray(numbers);
            foreach (int i in numbers)
                Console.Write(i + " ");
        }
    }
}