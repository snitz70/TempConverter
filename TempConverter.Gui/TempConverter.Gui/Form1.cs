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
            temperature.Celsius = 0M;
            //textTo.Text = temperature.Fahrenheit.ToString();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
