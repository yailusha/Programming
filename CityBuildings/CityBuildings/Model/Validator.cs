using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBuildings.Model
{
    static class Validator
    {
        public static bool AssertValueInRange(double value, double min, double max)
        {
            if (value < min ||  value > max)
            {
                throw new ArgumentException($"Value not in range from 0 to 5: {value}");
            }
            return true;
        }
        public static bool AssertOnLengthRange(string value, int max)
        {
            if (value.Length > max)
            {
                throw new ArgumentException("Incorrect value");
            }
            return true;
        }
    }
}
