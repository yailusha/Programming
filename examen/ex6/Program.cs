using System;

namespace ex._1._6
{
    class program
    {
        public static bool FindTrue(bool[] bools)
        {
            foreach (bool b in bools)
                if (b)
                    return true;
            return false;
        }
        private static void Main(string[] args)
        {
            bool[] myArray = { false, false, false,  false, false };
            bool flag = FindTrue(myArray);
            Console.WriteLine(flag);
        }
    }
}

