using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldSchool
{

    public class TemperatureInfoEventArgs: EventArgs
    {
        public double Temperature { get; set; }
        public string SunnyOrNot { get; set; }
        public TemperatureInfoEventArgs(double temperature)
        {
            Temperature = temperature;
            
        }
    }
    public class TemperatureMonitor
    {

        //AN EVENT DEPENDS ON THE DELEGATE WE DEFINED
        // public event TemperatureChangeHandler OnTemperatureChange;

        // EVENT HANDLER (a built in delegate)
        public event EventHandler<TemperatureInfoEventArgs> OnTemperatureChange;

        private double _temperature;

        public double Temperature{ get { return _temperature;}
            set { 
                _temperature = value;
                if (_temperature > 30)
                {
                    //RAISE EVENT!
                    RaiseTemperatureChangedEvent(new TemperatureInfoEventArgs(_temperature)); //sender , info

                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(TemperatureInfoEventArgs e)
        {
            OnTemperatureChange?.Invoke(this,e);
        }
    }

    public class TemperatureAlert
    {
        public void OnTemperatureChanged(object sender,TemperatureInfoEventArgs e)
        {
            Console.WriteLine($"Alert: Temperature is {e.Temperature} sender: {sender}");
        }
    }
}
