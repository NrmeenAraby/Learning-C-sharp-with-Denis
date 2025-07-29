using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public interface ILogger
    {
        void log(string msg);
    }

    public class FileLogger : ILogger
    {
        public void log(string msg) {

            string directoryPath = @"D:\LogsWithDenis";
            string filePath=Path.Combine(directoryPath, "log.txt");
            if (!Directory.Exists(directoryPath)) { 
              Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, msg +"\n");
        }
    }

    public class DbLogger : ILogger {

        public void log(string msg) { 
           Console.WriteLine("Logging to database "+msg);
        }
    }

    public class Application {   //DECOUBLING CODE 

        public readonly ILogger _logger;
        public Application(ILogger logger) { 
           _logger = logger;
        }
        public void DoWork() { 
            _logger.log("Work started");

            _logger.log("Work done!");
        }
    }
}
