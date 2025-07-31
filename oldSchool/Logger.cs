using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public delegate void LogHandler(string message);
    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console log: "+message);
        }
        public void LogToFile(string message) {
            Console.WriteLine("File log: "+message);
        }
    }
}
