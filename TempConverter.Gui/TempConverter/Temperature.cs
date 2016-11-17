using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    public class Temperature
    {
        // set intial temperatures
        private decimal fahrenheit = 32M;
        private decimal celsius = 0M;
        private decimal kelvin = 273.15M;

        private int CurrentUnit;
        private decimal result;

        public enum Temps { Celsius, Fahrenheit, Kelvin }

        public decimal Fahrenheit
        {
            get
            {
                if (CurrentUnit == (int)Temps.Celsius) 
                     result = celsius * 9 / 5 + 32;
                else if (CurrentUnit == (int)Temps.Kelvin)
                    result = kelvin * 9 / 5 - 459.67M;
                else
                    result = fahrenheit;
                return result;

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
                if (CurrentUnit == (int)Temps.Fahrenheit)
                    result = (fahrenheit - 32) * 5 / 9;
                else if (CurrentUnit == (int)Temps.Kelvin)
                    result = kelvin - 273.15M;
                else
                    result = celsius;
                return result;
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
                if (CurrentUnit == (int)Temps.Celsius)
                    result = celsius + 273.15M;
                else if (CurrentUnit == (int)Temps.Fahrenheit)
                    result = (fahrenheit + 459.67M) * 5 / 9;
                else
                    result = kelvin;
                return result;
            }
            set
            {
                kelvin = value;
            }
        }

        public void ChangeTemp(decimal temp, int unit)
        {
            if (unit == (int)Temps.Celsius)
                Celsius = temp;
            if (unit == (int)Temps.Fahrenheit)
                Fahrenheit = temp;
            if (unit == (int)Temps.Kelvin)
                Kelvin = temp;

            CurrentUnit = unit;
        }

        //private bool ValidateTemp(decimal temp)
        //{
        //    decimal.TryParse
        //}
    }
}
