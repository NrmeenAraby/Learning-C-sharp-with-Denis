using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class Animal
    {
         public void Eat()
         {
            Console.WriteLine("Eating...");
         }

        public virtual void MakeSound()
        {
            Console.WriteLine("just sound");

        }
    }

    class Dog:Animal
    {
       public new void Eat()
       {
            Console.WriteLine("Dog is eating..");
       }
        public override void MakeSound()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Collie : Dog { 
       
        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }
    }

}
