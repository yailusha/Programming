using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public class IdGenerator
    {
        private static int _nextId = 1;
        public static int GetNextId ()
        {
            return _nextId++;
        }
    }
}
