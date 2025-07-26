using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class Customer
    {

        private string _password;
        public string Name{ get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // WRITE ONLY PROPERTY
        public string Password {
            set {  _password = value; }
                }

        //ID KEY AND READONLY
        public static int nextrId = 0;
        private readonly int _id;

        public int Id {
            get { 
                return _id;
            } 
        }

        //DEAFULT CONSTRUCTOR
        public Customer()
        {
            _id = nextrId++;
            Name = "New Customer";
            Address = "Unknown";
            ContactNumber = "None";
        }

        //CUSTOM CONSTRUCTORS
        //DEFAULT/OPTIONAL PARAMETERS
        public Customer(string name,string address="NA", string contactNumber = "NA")
        {
            _id = nextrId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
      
        public void setDetails(string name, string address, string contactNumber)
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"name is: {Name} and Id is {_id}");
        }
    }
}
