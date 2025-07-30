using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public struct Point
    {
      
        //READ ONLY properties, so this struct type is IMMUTABLE
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x; 
            Y = y;
        }

        public double DistanceTo(Point p)
        {
            double dx=p.X - X;
            double dy=p.Y - Y;
            return Math.Sqrt(dx*dx + dy*dy);
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X} , {Y})");
        }

    }
}
