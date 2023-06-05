using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            List<string> strings = new List<string>();
            List<double> numeros = new List<double>();

            string[] valores = input.Split(',');

            foreach (string valor in valores)
            {
                if (double.TryParse(valor.Trim(), out double numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    strings.Add(valor.Trim());
                }
            }

            string exibirStrings = string.Join(", ", strings);
            string exibirNumeros = string.Join(", ", numeros);

            textBox2.Text = exibirStrings;
            textBox3.Text = exibirNumeros;
        }
    }
}
