using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ederson_Mateus_17_09_2018
{
    public partial class Form3 : Form
    {
        int[,] mat = new int[4, 4];
        int n, linha = 0, col = 0, cont = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mat = new int[4, 4];
            linha = 0; col = 0; cont = 0;
            label2.Text = mostraMatriz(mat);
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont < mat.Length)
            {
                if (int.TryParse(textBox1.Text, out n))
                {
                    mat[linha, col++] = n;

                    listBox1.Items.Add("Valor " + n.ToString() + " adicionado na matriz.");

                    if (col == 4)
                    {
                        linha++;
                        col = 0;
                    }

                    label2.Text = mostraMatriz(mat);

                    cont++;

                    textBox1.Text = "";
                    textBox1.Focus();

                    if (cont == mat.Length)
                    {
                        button1.Text = "Verificar";
                        button1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Digite um valor inteiro!");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            else
            {
                textBox1.Text = "";
                listBox1.Items.Clear();
                listBox1.Items.Add(mostraMatriz(mat, 0));
                listBox1.Items.Add(mostraMatriz(mat, 1));
                listBox1.Items.Add(mostraMatriz(mat, 2));
                listBox1.Items.Add(mostraMatriz(mat, 3));
                MessageBox.Show(matrizSimetrica(mat));
            }
        }

        private string matrizSimetrica(int[,] m)
        {
            string str = "";
            bool sim = true;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    // str += "m[" + i + ", " + j + "] = " + m[i, j] + " COM m[" + j + ", " + i + "] = " + m[j, i] + "\n";
                    if (m[i, j] != m[j, i])
                    {
                        sim = false;
                    }
                }
            }
            if (sim)
            {
                str += "A matriz é simétrica!";
            }
            else
            {
                str += "A matriz não é simétrica!";
            }
            return str;
        }

        private string mostraMatriz(int[,] m, int aux = -1)
        {
            string str = "";
            for (int i = 0; i < m.GetLength(0); i++)
            {
                if (aux == -1 || aux == i)
                {
                    for (int j = 0; j < m.GetLength(1); j++)
                    {
                        str += "[ " + (m[i, j] != 0 ? m[i, j].ToString() : "  ") + " ] ";
                    }
                    str += "\n";
                }
            }
            return str;
        }

    }
}
