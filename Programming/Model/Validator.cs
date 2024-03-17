using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class Validator
    {
        public static bool AssertOnPositiveValue (int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Incorrect value: {value} in {nameof(value)}. Value must be positive");
            }
            return true;
        }
        public static bool AssertOnPositiveValue(double value)
        {
            if (value < 0.0)
            {
                throw new ArgumentException($"Incorrect value: {value} in {nameof(value)}. Value must be positive");
            }
            return true;
        }
        public static bool AssertValueInRange(int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Value not in range: {value} in {nameof(value)}");
            }
            return true;
        }
        public static bool AssertValueInRange(double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Value not in range: {value} in {nameof(value)}");
            }
            return true;
        }
    }
}
