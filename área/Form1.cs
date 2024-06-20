using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace área
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(float.TryParse(textBox1.Text, out float lado))
            {
                float area = lado * lado;

                lblResultado.Text = "A área do quadrado é: " + area;
            }
            else
            {
                MessageBox.Show("Entrada invalida. por faVOR, digite um número válido.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
