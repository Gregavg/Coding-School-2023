using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExSeven
    {
        short degreesCelsius = 25;
        public string getDegrees()
        {
            double degreesKelvin = degreesCelsius + 273.15;
            double degreesFahrenheit = (degreesCelsius * 1.8) + 32;

            string result = string.Format("{0} degrees Celcious are:\n" +
                "{1} degrees Kelvin and {2} degrees Fahrenheit.", degreesCelsius, degreesKelvin, degreesFahrenheit);

            return result;
        }
    }

}
