using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class ClassWithGenericMethod
    {
        public void Log<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
