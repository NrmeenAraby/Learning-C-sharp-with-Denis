using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public interface IPrintable
    {
        void print();
    }

    public interface IScannable
    {
        void Scan();
    }
    public class MultiFunctionPrinter : IPrintable, IScannable
    {
        public void print()
        {
            Console.WriteLine("Printing");
        }

        public void Scan() {
            Console.WriteLine("Scanning");
        }

    }

}
