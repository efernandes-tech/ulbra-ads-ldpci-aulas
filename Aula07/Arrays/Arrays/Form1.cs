using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sai = "";
            int[] x;
            x = new int[10];
            int[] y = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };
            const int TAM_VET = 10;
            int[] z;
            z = new int[TAM_VET];
            for (int i = 0; i < z.Length; i++)
            {
                z[i] = 2 + 2 * i;
            }   
            sai += "Índice \tVetor x \tVetor y \tVetor z \n";
            for (int i = 0; i < TAM_VET; i++)
            {
                sai += i + "\t" + x[i] + "\t" + y[i] + "\t" + z[i] + "\n";
            }
            MessageBox.Show(sai, "Trabalhando com vetores de inteiros",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] mat1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            // mat1 matriz retangular

            int[][] mat2 = new int[3][];

            // mat2 matriz irregular

            mat2[0] = new int[] { 1, 2 };
            mat2[1] = new int[] { 3 };
            mat2[2] = new int[] { 4, 5, 6 };

            label1.Text = "Valores da matriz 1 - por linha: \n";

            MessageBox.Show("Quantidade total de elementos:\n"
                + (mat1.Length).ToString()
                + "\nNúmero de colunas:\n"
                + mat1.GetLength(0).ToString(), "Matriz 1");

            for (int i = 0; i < mat1.GetLength(0); i++) // Nº linhas.
            {
                // Percorre uma matriz retangular.
                for (int j = 0; j < mat1.GetLength(1); j++) // Nº colunas.
                {
                    label1.Text += mat1[i, j] + " ";
                }
                label1.Text += "\n";
            }

            label1.Text += "\nValores da matriz 2 - por linha: \n";

            MessageBox.Show("Número de linhas:\n"
                + (mat2.Length).ToString()
                + "\nQuantidade de elementos - linha 2:\n"
                + (mat2[2].Length).ToString(), "Matriz 2");

            for (int i = 0; i < mat2.Length; i++)
            {
                // Percorre uma matriz irregular.
                for (int j = 0; j < mat2[i].Length; j++)
                {
                    label1.Text += mat2[i][j] + " ";
                }
                label1.Text += "\n";
            }
        }
    }
}
