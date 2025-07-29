using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }
    public class Cat : IAnimal
    {
        public  void Eat(string food)
        {
            Console.WriteLine("Cat eats"+food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dogg : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine("Dog eats" + food);
        }

        public void MakeSound()
        {
            Console.WriteLine("Barking");
        }
    }
}
