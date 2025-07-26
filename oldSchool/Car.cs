using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class Car
    {
        private string _model="";
        private string _brand = "";
        private int _id = 0;
        private string message;
        public static int NumberOfCars;
        public static int TryStaticConstructors;

          static Car() {

            TryStaticConstructors = 5;
        }

        //  private bool _isLuxury;
        //PROPERTY

        //EXPRESSION BODIED ON READ ONLY PROPERTY
        public int Id => _id;

        //EXPRESSION BODIED ON A CONSTRUCTOR
        public Car(string msg) => message = msg;

        //EXPRESSION BODIED ON A FINALIZER
        ~Car() => Console.WriteLine("Finalizer called!");

        public string Model { get => _model; set {
                if (string.IsNullOrEmpty(value)) {
                    Console.WriteLine("You entered NOTHING");
                    _model = "Default Value";
                }
                else
                {
                    Console.WriteLine("okkkkk, Model property");

                    _model = value;
                }
            } }
        public string Brand {
            get {
                if (IsLuxury) 
                    return _brand + "- Luxury Edition";
                else
                    return _brand;
                }

                set {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("You entered NOTHING");
                        _brand = "Default Value";
                    }
                    else
                    {
                        Console.WriteLine("okkkkk, Brand property");
                        _brand = value;
                    }
                } 
        }

        // public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //WITHOUT BACKING FIELD 
        public bool IsLuxury { get; set; }
        public Car(string model, string brand,bool isLuxury)
        {
            NumberOfCars++;
            Console.WriteLine("im the constructor");
            Model = model;
            Brand = brand;
            IsLuxury=isLuxury;
        }
        public Car()
        {
            NumberOfCars++;
        }

        public void drive()
        {
            Console.WriteLine($"I am a/an {Model} and i am driving" );
        }



      
    }
}
