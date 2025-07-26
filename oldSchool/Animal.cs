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
        public virtual void SealedMethod() {
            Console.WriteLine("to be Sealed method");    
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
        public sealed override void SealedMethod()
        {
            Console.WriteLine("sealed method");
        }
    }
    class cat : Animal {

        public override void SealedMethod()
        {
            Console.WriteLine("sealed method");
        }
    }

    class Collie : Dog { 
       
        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }

        //but here we can't override SealedMethod
    }
    class kitten : cat
    {

        public void GoingNuts()
        {
            Console.WriteLine("Collie going Nuts");
        }
        public override void SealedMethod() { }

    }

}
