﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void print()
        {
            Console.WriteLine("University {0} with Id {1}",Name,Id);
        }
    }
}
