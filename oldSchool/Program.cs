using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;

namespace oldSchool
{
    // ENUMS //
    enum Day { mo,tu,we,th,fr,sa,su};
    enum Month {Jan=1,feb ,mar, apr, may, jun=12, jul, aug };
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] conditions = { "sunny", "rainy", "cloudy", "snowy" };
            //string[] weatherCondition = new string[7];
            //Random rando = new Random();
            //for(int i = 0; i < 7; i++)
            //{
            //    weatherCondition[i] = conditions[rando.Next(conditions.Length)];
            //}

            ////MIN FORM AN ARRAY
            //int[] nums = { 2, 5, -8, 6, 3 };
            //int mn = nums.Min();


            //Customer customer = new Customer();
            //customer.Name = Console.ReadLine();
            //Console.WriteLine(customer.Name);

            //Car car = new Car("A3","Audi",false);
            //car.drive();

            //WITH OPTIONAL PARAMETERS CONSTRUCTOR
            //Customer customer = new Customer("Nrmeen");
            //Console.WriteLine(customer.Address);

            //NAMED PARAMETERS
            //Console.WriteLine(add(firstNum: 10, secondNum: 20));
            //Console.WriteLine(add(10, secondNum: 20));
            //Console.WriteLine(add(firstNum: 10,20));

            //OPERATOR OVERLOADING
            //Vector v1 = new Vector(1, 5);
            //Vector v2=new Vector(2, 5);
            //// Vector v3 = new Vector(2, 1);
            //Vector result = v1 + v2; //+v3;
            //result.Display();

            //COMPUTED PROPERTY
            //Rectangle r = new Rectangle();
            //r.height = 5;
            //r.width = 10;
            //Console.WriteLine(r.Area); 

            //ACCESSING THE PUPLIC STATIC VAR NumberOfCars OF THE Car
            //Car car = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car("A3","Audi",false);
            //Console.WriteLine(Car.NumberOfCars);

            //TRYING STATIC CONSTRUCTORS
            //Console.WriteLine(Car.TryStaticConstructors);

            //IS AS
            // Car car = new Car();
            // if(car is Car)
            // {
            //    Console.WriteLine("car is a Car");
            // }

            //Object obj = "Hello World";
            //if (obj is string msg)
            //{  //msg is a variable that will hold the content of the obj if it is of string type

            //    //string msgg = (string )obj; //msg in the if equivalent to this 
            //    Console.WriteLine(msg);
            //}
            //else
            //{
            //    Console.WriteLine("nope");

            //}

            // ID KEY WITH STATIC FIELD AND READONLY FIELD 
            //Customer cust1 = new Customer();
            //Customer cust2 = new Customer("Nrmeen", "somewhere", "25555");
            //cust1.GetDetails();
            //cust2.GetDetails();
            //Console.WriteLine(cust2.Id);

            // WRITE ONLY PROPERTY (WE CANT ACCESS)
            //Customer cust1 = new Customer();
            //cust1.Password = "dkfdjb6";

            ////LISTS////

            //List<string> list = new List<string>();
            //list.Add("hi");
            //list.Add("hello");
            //list.Add("hi");
            //list.Add("hey");
            //foreach (string st in list)
            //{
            //    Console.WriteLine(st);
            //}
            //bool isDeleted = list.Remove("hi");
            //while (isDeleted)
            //{
            //    isDeleted = list.Remove("hi");
            //}
            //Console.WriteLine("Afetr removing hi");
            //foreach(string st in list)
            //{
            //    Console.WriteLine(st);
            //}

            //DECLARING AND INITIALIZING LISTS AT THE SAME TIME
            //List<string> colors = [
            //    "Red",
            //    "Blue",
            //    "Pink",
            //    ];
            //colors.Add("White");

            //To avoid compatibility issues with declaring and initializing at the same time, use this syntax: 
            // List<int> myNumbers = new List<int> { 10, 1, 15, 11, 5, 25 };
            //myNumbers.Sort();
            //Console.WriteLine("The list after sorting ");
            //foreach (int num in myNumbers) { 
            //  Console.WriteLine(num);
            //}

            //FIND ALL
            //List<int> higherEqual10 = myNumbers.FindAll(x => x >= 10);
            //Console.WriteLine("higherEqual10");
            //foreach(int num in higherEqual10)
            //{
            //    Console.WriteLine(num);
            //}

            //PREDICATES AND LAMBDAS
            //Predicate<int> isGreaterThan10 = x => x >= 10;
            //List<int> higherEqual10 = myNumbers.FindAll(isGreaterThan10);

            //ANY
            //bool hasLargeNumber = myNumbers.Any(x => x > 20);
            //if (hasLargeNumber) {
            //    Console.WriteLine("There are large numbers");
            //}
            //else
            //{
            //    Console.WriteLine("No large numbers in the list");
            //}

            //LISTS WITH COMPLEX OBJECTS
           /* List<Car> cars = new List<Car> {
               new Car("A3","Audi",false),
               new Car{Model="jj",Brand="ssss", IsLuxury=false }
            };
            cars.Add(new Car("i7", "BMW", true));
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Brand);
            }

            //FILTERING LISTS WITH COMPLEX TYPE
            List<Car> nonLuxury = cars.Where(c => c.IsLuxury == false).ToList();
            Console.WriteLine("Non Luxury Cars");
            foreach (Car car in nonLuxury)
            {
                Console.WriteLine(car.Brand);
            }*/

            //ARRAYLIST
            /* ArrayList arrlist = new ArrayList();  //we can define without size
             ArrayList arrlist2 = new ArrayList(100); //also we can put a size

             arrlist.Add("Hi");
             arrlist.Add(13);
             arrlist.Add(50.25);
             arrlist.Add(20);
             arrlist.Add(13);

             arrlist.Remove(13); //just remove first occurance
             arrlist.RemoveAt(0); //idx
             Console.WriteLine(arrlist.Count);*/


            //HASHTABLES
            /* Car car1 = new Car("A3", "Audi", false);
             Car car2 = new Car("jj", "ssss", false);
             Car car3 = new Car("i7", "BMW", true);

             Hashtable ht = new Hashtable();
             ht.Add(car1.Model, car1);
             ht.Add(car2.Model, car2);
             ht.Add(car3.Model, car3);

             Car storedCar = (Car)ht[car2.Model];  //dont forget type casting, as hashtables hold both the key and the value as objects
             foreach (DictionaryEntry entry in ht)
             {
                 Car tmp = (Car)entry.Value;
                 Console.WriteLine("car's Model: {0},Brand: {1}", tmp.Model, tmp.Brand);
             }

             //OR
             foreach (Car car in ht.Values)
             {
                 Console.WriteLine("car's Model: {0},Brand: {1}", car.Model, car.Brand);}
             */

            //NULLABLE
            /*int? x = null;
            int sum = 0;
            if (x.HasValue)
            {
                Console.WriteLine(x);
                sum += x.Value;  //we must use .value when adding to another 
            }
            else
            {
                Console.WriteLine("x has no value" + x); // x will be ignored and it wont cause a problem
            }*/


            //DICTIONARY
            /*Dictionary<int, string> employees=new Dictionary<int, string>();
            //add item
            employees.Add(105, "Ali");
            employees.Add(10,"smith");
            employees.Add(5, "Doe");
            employees.Add(100, "albert");
         
            //access item 
            string name = employees[10];
            Console.WriteLine(name);
            //update item
            employees[5] = "Ayan";
            //remove item
            employees.Remove(100);
            //iterating the dictionary
            foreach(KeyValuePair<int,string> emp in  employees)
            {
                Console.WriteLine($"Id: {emp.Key}, Name: {emp.Value}");
            }
            //Avoiding the error of adding an existing key
            if (!employees.ContainsKey(10))
            {
                employees.Add(10, "Oday");
            }
            else{
                employees[10] = "oday";
            }

            bool added= employees.TryAdd(10, "Oday");
            if (!added) {
                Console.WriteLine("This id is already exist");           
            }
            //With complex value
            Dictionary<int,Car> cars=new Dictionary<int,Car>();
            cars.Add(1, new Car("i7", "BMW", true));
            cars.Add(2, new Car("jj", "ssss", false));
            cars.Add(3, new Car("A3", "Audi", false));
            foreach(var car in cars)
            {
                Console.WriteLine(car.Value.Model);
            }
            //Another way to declare and initalize Dictionary
            var dict = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"]="California",
                ["TX"]="Texas"
            };
            //Avoiding the error of accessing an non existant key
            string state;
            if(dict.TryGetValue("NY",out state))
            {
                Console.WriteLine(state);
            }*/


            //TRY, CATCH,CATCH,.. AND Finally

            /*int result = 0;
            try
            {
                Console.WriteLine("Enter a num: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 10;
                result = num2 / num1;
            }
           catch (DivideByZeroException ex)
            {
               Console.WriteLine("Dont divide by ZERO!" + ex.Message);
            }
           catch (FormatException ex)
            {
                Console.WriteLine("JUST NUMBERS ARE ALLOWED"+ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number out of the type bound!"+ex.Message);
            }
            catch (Exception ex) { 
               Console.WriteLine("Error: "+ex.Message);

                //DEBUG
                Debug.WriteLine("DEBUGGGGGG"+ex.ToString);  //just executed i fwe r in debug not just bild mood
            }
            finally
            {
                Console.WriteLine("This always executes no matter what");
            }
            Console.WriteLine("Result: " + result);*/

            //THROW AN EXCEPTION

            /*Console.WriteLine("Entrer ur age: ");
            GetUserAge(Console.ReadLine());*/

            //EXCEPTIONS WITH THE CALL STACK

            /*try
            {
                LevelOne();
            }
            catch (Exception ex) { 
                Console.WriteLine("Exception caught in Main"+ex.Message);
            }
            Console.WriteLine("App is still running");*/

            //HIDE AND OVERRIDE AND VIRTUAL
            //Animal animal = new Dog();  //upcasting
            //animal.MakeSound(); //override, so of the dog will be called
            //animal.Eat(); //Hide, so the method inside the animal will be called

            //CONSTRUCTOR INHERITANCE 
            /* Employee emp = new Employee("Nrmeen", 21, "SW Eengineer", 255);
             emp.DisplayEmployeeInfo();
             //SHOWING XML DOCUMENTAION EFFECT WHEN WE HOVER HE METHOD
             emp.BecomeOlder(2);*/

            //POLYMORPHISM 
            /*IAnimal cat = new Cat();
            IAnimal dog = new Dogg();
            cat.MakeSound();
            dog.MakeSound();*/

            //FILE ON MY PC
            /* 
             File.AppendAllText("log.txt", "HELLLOOOOOO\n");  // if log.txt isnt there on my pc so it will create a file with this name
            */

            //CREATE A DIRECTORY THAT IS THE PATH FOR THE FILE WE WILL HANDLE
            /*string directoryPath = @"D:\LogsWithDenis"; // the folder path
            string filePath = Path.Combine(directoryPath, "log.txt"); //put the log.txt file inside the folder and then the complete path will be put in the filePath variable

            if (!Directory.Exists(directoryPath)) {          //lw el folder m4 mawgod create it
                 Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, "Heyyyyyy\n");*/

            //PRACTUCE ON DECOUPLINE
            /* ILogger flogger = new FileLogger();
             ILogger Dlogger =new DbLogger();    
             Application app=new Application(flogger);
             app.DoWork();
             app=new Application(Dlogger);
             app.DoWork();*/

            //PRACTICE ON CONSTRUCTOR DEPENDENCY INJECTION
            /* Hammer hammer = new Hammer();
             Builder builder=new Builder(hammer);
             builder.BuildHouse();*/

            //PRACTICE ON SETTER DEPENDENCY INJECTION
            /* Hammer hammer = new Hammer();
             Builder builder = new Builder();
             builder.Hammer = hammer;   //injection dependency via setter
             builder.BuildHouse();*/

            //PRACTICE ON INTERFACE DEPENDENCY INJECTION (via the interface method)
            /* Hammer hammer = new Hammer();
             Builder builder = new Builder();

             builder.setHammer(hammer);
             builder.BuildHouse();*/

            //PRACTICE ON  MULTIPLE INHERITANCE (USING INTERFACES)
            /*MultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
            multiFunctionPrinter.print();
            multiFunctionPrinter.Scan();*/

            //PRACTICE ON STRUCTS
            /*Point p1=new Point(10,20);
            Point p2=new Point(20,30);
            Point p3 = p2;
            double distance=p1.DistanceTo(p2);
            Console.WriteLine($"Distance between the two points: {distance:F3}");  //:F3 means pur 3 nums after the floating point
            */

            //PRACTICE ON ENUMS
            Day mo=Day.mo;
            Console.WriteLine(mo); //prints the word itself
            Console.WriteLine((int)mo); //to print the integer value

            Month j = Month.Jan;
            Console.WriteLine(j);
            Console.WriteLine((int)j);

            Month jul=Month.jul;
            Console.WriteLine(Month.jul);//prints the word itself
            Console.WriteLine((int)jul);

        }



        static void LevelOne()
        {
            Console.WriteLine("LevelOne before calling LevelTwo");
            LevelTwo();
            Console.WriteLine("Level one after calling level two");
        }
        static void LevelTwo()
        {
            Console.WriteLine("LevelTwo before the exception");
            throw new Exception("smth went wrong");
            Console.WriteLine("LevelTwo after the exception");
        }
        static int GetUserAge(string input)
        {
            int age = 0;
            if (!int.TryParse(input, out age)) {
                throw new Exception("plz enter a valid age");
            }
            if (age < 0 || age > 120) {
                throw new Exception("ur age must be between 0 and 120");
            }

            return age;
        }
        static int add(int firstNum,int secondNum)
        {
            return firstNum + secondNum;
        } 
    }
}
