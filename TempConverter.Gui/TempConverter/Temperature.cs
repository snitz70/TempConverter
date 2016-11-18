using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    public class Temperature
    {
        private decimal _kelvin = 0.0M;

        public decimal Fahrenheit
        {
            get { return _kelvin * 9 / 5 - 459.67M; }
            set { _kelvin = (value + 459.67M) * 5 / 9; }
        }

        public decimal Celsius
        {
            get { return _kelvin - 273.15M; }
            set { _kelvin = value + 273.15M; }
        }

        public decimal Kelvin
        {
            get { return _kelvin; }
            set { _kelvin = value; }
        }

        public static Temperature FromKelvin(decimal kelvin)
        {
            var temperature = new Temperature();
            temperature.Kelvin = kelvin;
            return temperature;
        }

        public static Temperature FromFahrenheight(decimal fahrenheit)
        {
            var temperature = new Temperature();
            temperature.Fahrenheit = fahrenheit;
            return temperature;
        }

        public static Temperature FromCelsius(decimal celsius)
        {
            var temperature = new Temperature();
            temperature.Celsius = celsius;
            return temperature;
        }
    }
}
