using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal interface IRepositoryT<T> where T : IEntity  //el type rlly yetb3tly yekon 3ml implementaion l IEntity interface 
    {
        void Add (T entity);
        void Remove(T entity);
    }

    internal class productRepository : IRepositoryT<Product>  //Product class has already implemented IEntity in the Repository.cs file
    {
        public void Add (Product entity)
        {

        }
        public void Remove(Product entity)
        {

        }
    }
}
