using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV_1
{
    public partial class Form3 : Form
    {
        int codigo, a, b, c, resultado;

        private void button1_Click(object sender, EventArgs e)
        {
            if (cod.Text.Length == 0
                || valor1.Text.Length == 0
                || valor2.Text.Length == 0
                || valor3.Text.Length == 0)
            {
                MessageBox.Show("Digite os valores.", "Atenção");
                return;
            }

            codigo = int.Parse(cod.Text);
            a = int.Parse(valor1.Text);
            b = int.Parse(valor2.Text);
            c = int.Parse(valor3.Text);
            
            if (codigo == 1)
            {
                resultado = a * b * c;
                final.Text = resultado.ToString();
            }
            else if (codigo == 2)
            {
                resultado = a + b + c;
                final.Text = resultado.ToString();
            }
            else if (codigo == 3)
            {
                resultado = a - b - c;
                final.Text = resultado.ToString();
            }
            else if (codigo == 4)
            {
                resultado = (a * a * a) + (b * b * b) + (c * c * c);
                final.Text = resultado.ToString();

            }
            else if (codigo == 5)
            {
                resultado = (a * a) + (b * b) + (c * c);
                final.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Código Inválido!");
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            codigo = 0;
            a = 0;
            b = 0;
            c = 0;
            resultado = 0;
        }


    }
}
