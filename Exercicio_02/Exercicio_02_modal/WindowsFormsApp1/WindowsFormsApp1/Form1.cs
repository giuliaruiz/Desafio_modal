using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] vlA = textBox1.Text.Split(',');
            if (vlA.Length != 20)
            {
                MessageBox.Show("O vetor deve conter exatamente 20 números.");
                return;
            }

            string[] vlB = textBox2.Text.Split(',');
            if (vlB.Length != 20)
            {
                MessageBox.Show("O vetor deve conter exatamente 20 números.");
                return;
            }

            int[] VA = new int[20];
            int[] VB = new int[20];

            for (int a = 0; a < 20; a++)
            {
                if (int.TryParse(vlA[a], out int valor))
                {
                    VA[a] = valor;
                }
                else
                {
                    MessageBox.Show("Digite apenas números inteiros válidos no primeiro campo.");
                    return;
                }
            }

            for (int a = 0; a < 20; a++)
            {
                if (int.TryParse(vlB[a], out int valor))
                {
                    VB[a] = valor;
                }
                else
                {
                    MessageBox.Show("Digite apenas números inteiros válidos no segundo campo.");
                    return;
                }
            }

            int[] VFinal = VerificarValoresRepetidos(VA, VB);

            textBox3.Text = string.Join(", ", VFinal);
        }

       private int[] VerificarValoresRepetidos(int[] VA, int[] VB)
        {
            int[] VFinal = VA.Intersect(VB).Distinct().ToArray();
            return VFinal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
