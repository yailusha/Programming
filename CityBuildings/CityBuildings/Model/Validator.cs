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
            if (value < min || value > max)
            {
                MessageBox.Show($"Value not in range from 0 to 5, current value: {value}");
                return false;
            }
            return true;
        }
        public static bool AssertOnLengthRange(string value, int max)
        {
            if (value.Length > max)
            {
                MessageBox.Show("The value is too high.");
                return false;
            }
            return true;
        }
    }
}
