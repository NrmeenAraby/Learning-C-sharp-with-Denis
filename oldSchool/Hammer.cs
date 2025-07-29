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
        //SETTER DEPENDENCY INJECTION
        public Hammer Hammer { get; set; }

        //CONSTRUCTOR DEPENDENCY INJECTION 
        /*
         private Hammer _hammer; 
         public Builder(Hammer hammer)
         {
            _hammer = hammer;   
         }*/
        public void BuildHouse()
        {
            Hammer.Use();
            Console.WriteLine("Building..");
        }
    }
}
