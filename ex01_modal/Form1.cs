using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex01_modal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;  
        }

        private int ContarLetrasAMinusculas(string palavra)
        {
            int contador = 0;

            foreach (Match match in Regex.Matches(palavra, @"a"))
            {
                if (match.Value == "a")
                    contador++;
            }

            return contador;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string palavra = textBox1.Text;
            int contador = ContarLetrasAMinusculas(palavra); 
            textBox2.Text = contador.ToString(); 
        }
    }
}
