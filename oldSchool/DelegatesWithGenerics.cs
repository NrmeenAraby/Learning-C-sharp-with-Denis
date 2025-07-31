using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public delegate int Comparison<T>(T x, T y);
    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class HumanSorter
    {
       public void Sort(Human[] humans, Comparison<Human> comparison) {
          for(int i = 0; i < humans.Length-1; i++)
            {
                for (int j = i + 1; j < humans.Length; j++) {
                    if ((comparison(humans[i], humans[j])) > 0){
                        Human tmp = humans[i];
                        humans[i] = humans[j];
                        humans[j] = tmp;   
                    }
                }
            }
       }
    }
}
