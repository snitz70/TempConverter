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
            if (index == 0)
                textTo.Text = temperature.Celsius.ToString();
            if (index == 1)
                textTo.Text = temperature.Fahrenheit.ToString();
            if (index == 2)
                textTo.Text = temperature.Kelvin.ToString();
        }

        private void SetTemp(int index)
        {
            if (index == 0)
                temperature = Temperature.FromCelsius(decimal.Parse(textFrom.Text));
            if (index == 1)
                temperature = Temperature.FromFahrenheight(decimal.Parse(textFrom.Text));
            if (index == 2)
                temperature = Temperature.FromKelvin(decimal.Parse(textFrom.Text));
        }

        private void textTo_TextChanged(object sender, EventArgs e)
        {
            SetTemp(tempFrom.SelectedIndex);
            DisplayTemp(tempTo.SelectedIndex);
        }
    }
}
