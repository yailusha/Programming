using System; 

namespace dsa
{
    class Calculator
    {
        public static double Sum(int x, int y) { return x + y; }
        public static double Sum(float x, float y) { return (double)(x + y); }
        public static string Sum(string x, string y) { return x + y; }
        private static void Main(string[] args)
        {
            double a = Sum(1, 845);
            double b = Sum(0.7f, 45.5f);
            string c = Sum("ads", "daf");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
    
}