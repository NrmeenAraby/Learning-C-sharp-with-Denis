using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public class EventPublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string msg)
        {
            OnNotify?.Invoke(msg);
        }
    }
    public class EventSubscriber
    {
        public void OnEventRaised(string msg)
        {
            Console.WriteLine("Event received: "+msg);
        }
    }
}
