using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class BoxTT<TFirst,TSecond>
    {
        public TFirst   First { get; set; }
        public TSecond Second { get; set; }
        public BoxTT(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }

        public void display()
        {
            Console.WriteLine($"First: {First} Second: {Second}");
        }
    }
}
