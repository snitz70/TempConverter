using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    public class Temperature
    {
        private decimal fahrenheit = 32M;
        private decimal celsius = 0M;
        private decimal kelvin = 273.15M;

        public decimal Fahrenheit
        {
            get
            {
                return celsius * 9 / 5 + 32;
            }
            set
            {
                fahrenheit = value;
            }
        }

        public decimal Celsius
        {
            get
            {
                return (fahrenheit - 32) * 5 / 9;
            }
            set
            {
                celsius = value;
            }
        }

        public decimal Kelvin
        {
            get
            {
                return celsius + 273.15M;
            }
            set
            {
                kelvin = value;
            }
        }
    }
}
