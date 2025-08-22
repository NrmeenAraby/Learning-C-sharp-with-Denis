using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    internal class BoxT<T>
    {
        public T Content { get; set; }
        public BoxT(T content)
        {
            Content = content;
        }

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
