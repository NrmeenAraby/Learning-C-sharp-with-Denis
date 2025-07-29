using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering..");
        }
    }

    public class Builder
    {
        private Hammer _hammer;
        public Builder()
        {
            _hammer = new Hammer();   //Builder is responsible for creating its dependencies
        }
        public void BuildHouse()
        {
            _hammer.Use();
            Console.WriteLine("Building..");
        }
    }
}
