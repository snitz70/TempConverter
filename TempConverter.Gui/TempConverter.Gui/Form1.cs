using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempConverter;

namespace TempConverter.Gui
{
    public partial class Form1 : Form
    {
        Temperature temperature;
        private enum Temps { Celsius, Fahrenheit, Kelvin };

        public Form1()
        {
            InitializeComponent();
            SetTemp(0);
            DisplayTemp(1);
        }

        private void tempFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTemp(tempFrom.SelectedIndex);
            DisplayTemp(tempTo.SelectedIndex);
        }

        private void tempTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTemp(tempFrom.SelectedIndex);
            DisplayTemp(tempTo.SelectedIndex);
        }


        private void textFrom_TextChanged(object sender, EventArgs e)
        {
            SetTemp(tempFrom.SelectedIndex);
            DisplayTemp(tempTo.SelectedIndex);
        }

        private void DisplayTemp(int index)
        {
            if (index == (int)Temps.Celsius)
                textTo.Text = temperature.Celsius.ToString("F2");
            if (index == (int)Temps.Fahrenheit)
                textTo.Text = temperature.Fahrenheit.ToString("F2");
            if (index == (int)Temps.Kelvin)
                textTo.Text = temperature.Kelvin.ToString("F2");
        }

        private void SetTemp(int index)
        {
            try
            {
                if (index == (int)Temps.Celsius)
                    temperature = Temperature.FromCelsius(decimal.Parse(textFrom.Text));
                if (index == (int)Temps.Fahrenheit)
                    temperature = Temperature.FromFahrenheight(decimal.Parse(textFrom.Text));
                if (index == (int)Temps.Kelvin)
                    temperature = Temperature.FromKelvin(decimal.Parse(textFrom.Text));
            }
            catch
            {

            }
        }
    }
}
