using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }

        //COMPUTED PROPERTY(DEPENDS ON OTHER PROPERTIES TO HAVE A VALVE)
        //READ ONLY PROPERTY
        public int Area {
            get { 
                return width * height;
            }
        }
    }
}
