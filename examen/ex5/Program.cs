using System;

namespace ex._1._5
{
    class program
    {
        public static int CalculateTrue(bool[] bools)
        {
            int count = 0;
            foreach (bool s in bools)
                if (s)
                    count++;
            return count;
        }
        private static void Main(string[] args)
        {
            bool[] myArray = { true, false, false, false, true };
            int countTrue = CalculateTrue(myArray);
            Console.WriteLine(countTrue);
        }
    }
}