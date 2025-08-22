using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace oldSchool
{
    // ENUMS //
    enum Day { mo,tu,we,th,fr,sa,su};
    enum Month {Jan=1,feb ,mar, apr, may, jun=12, jul, aug };

    /// 1- DELEGATES DECLARATION///
    public delegate void Notify(string message);
    public delegate void TemperatureChangeHandler(string msg);

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

            //PRACTICE ON DECOUPLINE
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
            /* Day mo=Day.mo;
             Console.WriteLine(mo); //prints the word itself
             Console.WriteLine((int)mo); //to print the integer value

             Month j = Month.Jan;
             Console.WriteLine(j);
             Console.WriteLine((int)j);

             Month jul=Month.jul;
             Console.WriteLine(Month.jul);//prints the word itself
             Console.WriteLine((int)jul);*/

            /// DATE TIME ///
            /* DateTime dateTime = new DateTime(2004,5,25);
             Console.WriteLine("My birthday is : "+dateTime);
             Console.WriteLine("Today is: "+DateTime.Today); //prints with 12:00AM (not with the right time)
            //write current time on screen (right time)
            Console.WriteLine(DateTime.Now);
            //get the day of today
            Console.WriteLine(DateTime.Today.DayOfWeek);
            //data of tomorrow
            DateTime tomorrow=GetTomorrow();
            Console.WriteLine("Tomorrow will be: "+ tomorrow);
            //first day of some year
            Console.WriteLine(GetFirstDayOfYear(2004));

            //num of days in a month in some year
            int days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("in 2004: "+days);
            days = DateTime.DaysInMonth(2005, 2);
            Console.WriteLine("in 2005: "+days);

            // we can print hours, minutes or seconds
            DateTime now = DateTime.Now;
            Console.WriteLine("Hours: "+now.Hour+" Minutes: "+now.Minute+" Seconds: "+now.Second);

            //how many days ??
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input=Console.ReadLine();
            DateTime date; 
            if (DateTime.TryParse(input, out date))
            {
                TimeSpan daysPassed=now.Subtract(date);
                Console.WriteLine("Days passed: "+daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }*/

            //MATH CLASS
            /*Console.WriteLine("Ceiling "+Math.Ceiling(12.2));
            Console.WriteLine("Floor "+Math.Floor(13.6));
            Console.WriteLine("3 Pow 5:  "+Math.Pow(3,5));
            Console.WriteLine("PI "+Math.PI);
            Console.WriteLine("square root "+Math.Sqrt(25.1));
            Console.WriteLine("Abs "+Math.Abs(-5));
            Console.WriteLine("Min of 5 and 2.2:  "+Math.Min(2.2,5));
            Console.WriteLine("Max of 6 and 1: "+Math.Max(1,6));
            Console.WriteLine("cos of 90: "+Math.Cos(90));*/

            ///  DELEGATES ///
            //2- Instantiation
            /* Notify notifyDelegate = ShowMessage;

             //3-Invocation
             notifyDelegate("Heya, im learnig delegates");*/

            /// BUBBLE SORT///
            /* int[] arr = { 5, 3, 8, 4, 2 };
             BubbleSortAlgo.BubbleSort(arr);
             foreach (int num in arr) { 
               Console.WriteLine(num);
             }*/

            //SIMPLE PRACTICE ON GENERIC
            /*int[] arr = { 5, 3, 8, 4, 2 };
            string[] arr2 = { "one", "two", "three" };
            PrintArray(arr);
            PrintArray(arr2);*/

            //PRACTICE ON DELEGATES WITH GENERICS WITHIN CLASSES

            /* Human[] humans = {
               new Human{Name="Alice",Age=30 },   // i use those {} as we didn put a constructor 
               new Human{Name="Bob",Age=25 },
               new Human{Name="charlie",Age=35 },
               new Human{Name="Denis",Age=36 }
             }; 
             HumanSorter sorter = new HumanSorter();
             sorter.Sort(humans,CompareByAge);
             foreach (Human human in humans) { 
                 Console.WriteLine("Name: "+human.Name+", Age: "+human.Age);
             }
             sorter.Sort(humans, CompareByName);
             foreach (Human human in humans)
             {
                 Console.WriteLine("Name: " + human.Name + ", Age: " + human.Age);
             }*/

            /// Multicast delegates ///
            /* Logger logger = new Logger();
             LogHandler logHandler = logger.LogToConsole; // now the delegate has a refernce on the LogToConsole method

             //Add another method (Multicast delegate)
             logHandler += logger.LogToFile;

             //Invokeing the multicast delegate
             logHandler("Log this info!");
             //or safely we can use the method we defiend
             InvokeSafely(logHandler,"log this i nfo, BUT SAFELY");

            //removing a method from the multicast delegate
             logHandler -= logger.LogToFile;
             logHandler("After removing LogToFile");

             //TO REMOVE IN A SAFE WAY using the method we defiend
             if (IsMethodInDelegate(logHandler,logger.LogToFile)) {
                 logHandler -= logger.LogToFile;
                 Console.WriteLine("After removing LogToFile, SAFELY");

             }
             else
             {
                 Console.WriteLine("NOT FOUND");
             }


                 //To invoke safely (to make sure that our delegate already have functions and we wont call a null delegate)
                 //also this approach calls method by method (not all in one line)
                 foreach (LogHandler handler in logHandler.GetInvocationList())
                 {
                     try
                     {
                         logHandler("Event occured with try catch");
                     }
                     catch (Exception ex)
                     {
                         Console.WriteLine("Exception caught: " + ex.Message);
                     }
                 }*/

            // PRACTICE ON EVENTS
            /* EventPublisher eventPublisher = new EventPublisher();
             EventSubscriber eventSubscriber = new EventSubscriber();

             eventPublisher.OnNotify += eventSubscriber.OnEventRaised;
             eventPublisher.RaiseEvent("Testtt");*/
            /*TemperatureMonitor tempratureMonitor = new TemperatureMonitor();
            TemperatureAlert temperatureAlert = new TemperatureAlert();

             tempratureMonitor.OnTemperatureChange += temperatureAlert.OnTemperatureChanged;

             Console.WriteLine("Plz enter a the temperature");
             tempratureMonitor.Temperature=double.Parse(Console.ReadLine());*/

            /// REGEX ///
            /*  string pattern = @"\d{5}";
            Regex regex=new Regex(pattern);
            string txt = " Hi ther, my number is 12538";
            MatchCollection matchCollection = regex.Matches(txt);
            Console.WriteLine("{0} hits found",matchCollection.Count);
            foreach(Match match in matchCollection)
            {
                GroupCollection groupCollection = match.Groups;
                Console.WriteLine($"{groupCollection[0].Value} found at {groupCollection[0].Index}");
            }*/

            /// LINQ ///
            /*int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> oddNums = from number in numbers
                                       where number % 2 != 0
                                       select number;
            foreach (int num in oddNums) { 
               Console.WriteLine(num);
            }
            //ORDER BY
            int[] someNums = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sorted= from num in someNums
                                     orderby num 
                                     select num; 

            IEnumerable<int>reversed=sorted.Reverse();
            foreach (int num in reversed) { 
               Console.WriteLine(num);
            }
            //Or
            IEnumerable<int>reversedLINQ = from num in someNums
                                           orderby num descending
                                           select num;
            foreach (int num in reversedLINQ)
            {
                Console.WriteLine(num);
            }

            UniversityManagerLINQ universityManagerLINQ = new UniversityManagerLINQ();
            universityManagerLINQ.FemaleStudents();
            universityManagerLINQ.MaleStudents();
            universityManagerLINQ.SortStudentsByAge();
            universityManagerLINQ.AllStudentsFromASU();

            try
            {
                string input = Console.ReadLine();
                int idAsInput = int.Parse(input);
                universityManagerLINQ.AllStudentsFromThatUni(idAsInput);
            }
            catch (Exception ex) { 
              Console.WriteLine(ex.ToString()); 
            }
            universityManagerLINQ.StudentAndUniversityNameCollection();*/

            // LINQ WITH XML
            /*string studentsXML = @"<Students>
                                 <Student>
                                   <Name>Nero</Name>
                                   <Age>21</Age>
                                    <University>ASU</University>
                                    <Semester>7</Semester>
                                 </Student>
                                 <Student>
                                   <Name>Lara</Name>
                                   <Age>19</Age>
                                    <University>GUC</University>
                                    <Semester>3</Semester>
                                 </Student>
                                 <Student>
                                   <Name>leyla</Name>
                                   <Age>19</Age>
                                    <University>ASU</University>
                                    <Semester>3</Semester>
                                 </Student>
                                </Students>";
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);
            var students = from student in studentsXdoc.Descendants("Student") //.Descendants("Student") → This method digs through the whole XML tree and grabs all <Student> tags
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };
            foreach (var student in students) {
                Console.WriteLine("Students {0} with age {1} from Universirt {2} is in his/her {3} semester",student.Name,student.Age,student.University,student.Semester);
            }
            //sorted
            var sortedStudents = from student in students
                                 orderby student.Age
                                 select student;

            Console.WriteLine("After sorting by age: ");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("Students {0} with age {1} from Universirt {2} is in his/her {3} semester", student.Name, student.Age, student.University, student.Semester);
            }*/

            /* int hi = 5;
             hi++;
             Console.WriteLine(hi);*/

            /// GENERICS ///
            BoxT<string> boxStr = new BoxT<string>("Hello");
            boxStr.UpdateContent("Learning Generics in C#");
            Console.WriteLine(boxStr.GetContent());
        }



        static bool IsMethodInDelegate(LogHandler OurDelegate,LogHandler method)
        {
            if(OurDelegate==null)
            {
                return false;
            }

            foreach(var d in OurDelegate.GetInvocationList())
            {
                if (d == (Delegate)method) //34an el list holds delegates, f casting to delegate zyadt ta2keed m4 aktr
                {
                    return true;
                }
            }
            return false;
        }
        static void InvokeSafely(LogHandler logHandler,string msg)
        {
            if (logHandler != null) {
                logHandler(msg);
            }
        }
        static int CompareByName(Human human1, Human human2)
        {
            return human1.Name.CompareTo(human2.Name);
        }

        static int CompareByAge(Human human1, Human human2) { 
          return human1.Age.CompareTo(human2.Age);        
         }

        //intro to GENERICS 
        static void PrintArray<T>(T[] arr) {
            foreach (T item in arr) { 
              Console.WriteLine(item);            
            }
        }
                

        //The method we use with DELEGATES
        static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        static DateTime GetTomorrow()
        {
            
            return DateTime.Today.AddDays(1);
        }
        static DateTime GetFirstDayOfYear(int year) { 
          return new DateTime(year,1,1);
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
