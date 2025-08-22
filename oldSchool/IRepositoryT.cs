using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal interface IRepositoryT<T>
    {
        void Add (T entity);
        void Remove(T entity);
    }

    internal class productRepository : IRepositoryT<Product>
    {
        public void Add (Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }
    }
}
