using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    static class ValueValidator
    {
        public static bool AssertStringOnLength (string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"Too long {propertyName}. It can be maximum {maxLength} symbols.");
            }
            return true;
        }
        public static bool AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Value of {propertyName} must be in range from {min} to {max}.");
            }
            return true;
        }
    }
}
