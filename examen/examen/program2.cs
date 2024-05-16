using System;

namespace ex._1._2
{
    class program
    {
        public static string[] SortArray(string[] array)
        {
            for (int i = 0; i<array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        string tempLine = array[i];
                        array[i] = array[j];
                        array[j] = tempLine;
                    }
                }
            }
            return array;
        }
        private static void main(string[] args)
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