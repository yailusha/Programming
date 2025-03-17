using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    static class ValueValidator
    {
        public static bool AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength || value.Length == 0)
            {
                throw new ArgumentException($"Too long {propertyName}. It can be maximum {maxLength} symbols.");
            }
            return true;
        }
        public static bool AssertStringOnMinLength(string value, int minLength, string propertyName)
        {
            if (value.Length != minLength)
            {
                throw new ArgumentException($"Not enough length {propertyName}. It must has {minLength} symbols.");
            }
            return true;
        }
    }
}
