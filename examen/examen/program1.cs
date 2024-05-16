using System;

namespace ex._1._1
{
    class program1
    {
        public static int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmpNumber = array[i];
                        array[i] = array[j];
                        array[j] = tmpNumber;
                    }
                }

            return array;
        }

        private static void Main(string[] args)
        {
            int[] numbers = { -9, 10, -12, 55, 1 };
            numbers = SortArray(numbers);
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}