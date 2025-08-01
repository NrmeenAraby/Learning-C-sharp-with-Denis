using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{
    public class TempratureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChange;

        private double _temperature;

        public double Temperature{ get { return _temperature;}
            set { 
                _temperature = value;
                if (_temperature > 30)
                {
                    //RAISE EVENT!
                    RaiseTemperatureChangedEvent("Temperature is above threshold");

                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string msg)
        {
            OnTemperatureChange?.Invoke(msg);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
