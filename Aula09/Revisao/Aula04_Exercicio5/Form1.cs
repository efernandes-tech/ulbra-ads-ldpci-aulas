using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5
{
    public partial class Form1 : Form
    {
        float n1, n2, n3, soma, med;

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(textBox2.Text);
            n2 = float.Parse(textBox3.Text);
            n3 = float.Parse(textBox4.Text);

            soma = 0;

            if (n1 >= n2 && n1 >= n3)
            {
                soma += n1 * 4;
                soma += n2 * 3;
                soma += n3 * 3;
            }
            else
            {
                if (n2 >= n3)
                {
                    soma += n2 * 4;
                    soma += n3 * 3;
                    soma += n1 * 3;
                }
                else
                {
                    soma += n3 * 4;
                    soma += n2 * 3;
                    soma += n1 * 3;
                }
            }

            med = soma / 10;

            listBox1.Items.Add("Código do Aluno:");
            listBox1.Items.Add(textBox1.Text);

            listBox1.Items.Add("Primeira Nota:");
            listBox1.Items.Add(textBox2.Text);

            listBox1.Items.Add("Segunda Nota:");
            listBox1.Items.Add(textBox3.Text);

            listBox1.Items.Add("Terceira Nota:");
            listBox1.Items.Add(textBox4.Text);

            listBox1.Items.Add("Média Ponderada:");
            listBox1.Items.Add(Decimal.Round(Convert.ToDecimal(med), 2).ToString());

            if (med >= 7)
            {
                listBox1.Items.Add("APROVADO");
            }
            else
            {
                listBox1.Items.Add("REPROVADO");
            }
        }
    }
}
