using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public interface IToolUser
    {
        void setHammer(Hammer hammer);
    }
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering..");
        }
    }

    public class Builder: IToolUser
    {
        //INTERFACE DEPENDENCY INJECTION
         private Hammer _hammer;

        public void setHammer(Hammer hammer)
        {
            _hammer = hammer;
        }
        //SETTER DEPENDENCY INJECTION
        /*  public Hammer Hammer { get; set; }*/

        //CONSTRUCTOR DEPENDENCY INJECTION 
        /*
         private Hammer _hammer; 
         public Builder(Hammer hammer)
         {
            _hammer = hammer;   
         }*/
        public void BuildHouse()
        {
            _hammer.Use();
            Console.WriteLine("Building..");
        }

      
    }
}
