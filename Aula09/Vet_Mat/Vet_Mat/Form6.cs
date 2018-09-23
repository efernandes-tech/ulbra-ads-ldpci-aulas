using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vet_Mat
{
    public partial class Form6 : Form
    {
        int[,] mat = new int[3, 3];
        int i = 0, j = 0;

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, w, y;
            string pos="";

            num = Int32.Parse(textBox1.Text);
            if (i < mat.GetLength(0))
            {
                if (j < mat.GetLength(1))
                {
                    mat[i, j] = num;
                    textBox1.Clear();
                    textBox1.Focus();
                    j++;
                }
                if (i < mat.GetLength(0) && j == mat.GetLength(1))
                {
                    j = 0;
                    i++;
                }
            }

            if (i == mat.GetLength(0))
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                
                label1.Text = "Menor elemento e posição:\n";
                y = mat[0, 0];
                pos = "0, 0";
                for (int z = 0; z < mat.GetLength(0); z++)
                {
                    for (w = 0; w < mat.GetLength(1); w++)
                        if (y > mat[z, w])
                        {
                            y = mat[z, w];
                            pos = z + ", " + w;
                        }
                }
                label1.Visible = true;
                label1.Text += "Elemento: " + y.ToString() + "     Posição: " + pos;

                label2.Visible = true;
                label2.Text = "Elementos da Matriz:\n";
                for (int z = 0; z < mat.GetLength(0); z++)
                {
                    for (w = 0; w < mat.GetLength(1); w++)
                        label2.Text += mat[z, w] + " ";
                    if (w == mat.GetLength(1))
                        label2.Text += "\n";
                }
            }
        }
    }
}