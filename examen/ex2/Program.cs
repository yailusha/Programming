using System;

namespace ex._1._2
{
    class program
    {
        public static string[] SortArray(string[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i].Length > array[j].Length)
                    {
                        string tempLine = array[j];
                        array[j] = array[i];
                        array[i] = tempLine;
                    }
            return array;
        }
        private static void Main(string[] args)
        {
            string[] lines = { "sadafgasgagdf", "dsadagg", "dsafgkoad", "dsadaw" };
            lines = SortArray(lines);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}