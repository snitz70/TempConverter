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
            temperature = new Temperature();
            temperature.Celsius = 0;
            temperature.ChangeTemp(0, 0);
            textTo.Text = temperature.Fahrenheit.ToString();
        }

        private void tempFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTemp(tempFrom.SelectedIndex);
            DisplayTemp(tempTo.SelectedIndex);
        }

        private void tempTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTemp(tempTo.SelectedIndex);
        }

        private void DisplayTemp(int index)
        {
            //temperature.ChangeTemp(textFrom.Text, index);
            //if (index == 0)
            //    textTo.Text = temperature.Celsius.ToString();
            //else if (index == 1)
            //    textTo.Text = temperature.Fahrenheit.ToString();
            //else textTo.Text = temperature.Kelvin.ToString();
        }

        private void SetTemp(int index)
        {
            try
            {
                //if (index == 0)
                //    temperature.Celsius = decimal.Parse(textFrom.Text);
                //else if (index == 1)
                //    temperature.Fahrenheit = decimal.Parse(textFrom.Text);
                //else
                //    temperature.Kelvin = decimal.Parse(textFrom.Text);
                temperature.ChangeTemp(decimal.Parse(textFrom.Text), index);
            }
            catch
            {
                MessageBox.Show("Temperature not in correct format");
            }

        }

        private void textFrom_TextChanged(object sender, EventArgs e)
        {
            SetTemp(tempFrom.SelectedIndex);
            DisplayTemp(tempTo.SelectedIndex);
        }
    }
}
