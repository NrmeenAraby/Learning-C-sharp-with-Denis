using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class Comparer
    {
        public static bool AreEqual<T>(T a, T b) where T : class 
        {
            return a == b;
        }
    }
}
