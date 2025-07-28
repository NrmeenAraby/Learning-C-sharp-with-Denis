using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person Constructor is called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name:{Name}, Age: {Age}");
        }

        /// <summary>Makes our object older.</summary>
        /// <param name="years">The parameter that indicates the amount of years the object should increased by.</param>
        /// <returns>Returns the new age after becoming olders.</returns>        
        public int BecomeOlder(int years)
        {
            Age += years;
            return Age;
    
        }
    }

    class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeId { get; private set; }

        public Employee(string name,int age ,string jobTitle, int employeeId) : base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
            Console.WriteLine("Employee Constructor is called");
        }
        public void DisplayEmployeeInfo() {
            DisplayPersonInfo();
            Console.WriteLine($"Job Title: {JobTitle}, Employee Id: {EmployeeId}");
        }
    }
}
