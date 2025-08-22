using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class BoxT<T> where T : class  //set a constraint on the type we can use
    {
        public T Content { get; set; }
        public BoxT(T content)
        {
            Content = content;
        }
        public BoxT() { }

        public void UpdateContent(T newContent)
        {
            Content=newContent;
            Console.WriteLine($"Updated Content to {newContent}");
        }
        public T GetContent()
        {
            return Content;
        }
    }
}
