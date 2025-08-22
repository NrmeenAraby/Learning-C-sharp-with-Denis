using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal interface IEntity
    {
        public int Id { get;  }
    }
    internal class Product : IEntity
    {
        public int Id { get; }
    }
    internal class Repository<T> where T :IEntity
    {
        private List<T> values = new List<T>();
        public void Add(T val)
        {
            values.Add(val);
        }
    }
}
