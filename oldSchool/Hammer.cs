using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering..");
        }
    }

    public class Builder
    {
        private Hammer _hammer;

        //CONSTRUCTOR DEPENDENCY INJECTION 
        public Builder(Hammer hammer)
        {
            _hammer = hammer;   
        }
        public void BuildHouse()
        {
            _hammer.Use();
            Console.WriteLine("Building..");
        }
    }
}
