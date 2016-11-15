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
            textTo.Text = temperature.Fahrenheit.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTemp(comboBox1.SelectedIndex);
            DisplayTemp(comboBox2.SelectedIndex);
            Console.WriteLine(temperature.Celsius.ToString(),
                temperature.Fahrenheit.ToString(),
                temperature.Kelvin.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTemp(comboBox2.SelectedIndex);
        }

        private void DisplayTemp(int index)
        {
            if (index == 0)
                textTo.Text = temperature.Celsius.ToString();
            else if (index == 1)
                textTo.Text = temperature.Fahrenheit.ToString();
            else textTo.Text = temperature.Kelvin.ToString();
        }

        private void SetTemp(int index)
        {
            try
            {
                if (index == 0)
                    temperature.Celsius = decimal.Parse(textFrom.Text);
                else if (index == 1)
                    temperature.Fahrenheit = decimal.Parse(textFrom.Text);
                else
                    temperature.Kelvin = decimal.Parse(textFrom.Text);
            }
            catch
            {
                MessageBox.Show("Temperature not in correct format");
            }

        }

        private void textFrom_TextChanged(object sender, EventArgs e)
        {
            SetTemp(comboBox1.SelectedIndex);
            DisplayTemp(comboBox2.SelectedIndex);
        }
    }
}
