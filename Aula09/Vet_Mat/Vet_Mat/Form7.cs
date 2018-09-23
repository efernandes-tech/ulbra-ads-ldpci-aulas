using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vet_Mat
{
    public partial class Form7 : Form
    {
        float[,] mat = new float[5, 3];
        string[] vet = new string[5];
        int i = 0;

        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, med_a=0, med_t=0, som_a=0, som_t=0;
            int w=0, z=0;
            string nome;

            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);
            n3 = float.Parse(textBox3.Text);
            nome = textBox4.Text;

            if (i < mat.GetLength(0))
            {
                    vet[i] = nome;
                    mat[i, w] = n1;
                    mat[i, w + 1] = n2;
                    mat[i, w + 2] = n3;
                    i++;
                    textBox4.Clear(); 
                    textBox4.Text = "Nome";
                    textBox4.Focus();
                    textBox1.Text = "Nota 1";
                    textBox2.Text = "Nota 2";
                    textBox3.Text = "Nota 3";
            }

            if (i == mat.GetLength(0))
            {
                textBox4.Enabled=false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button1.Enabled = false;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label1.Text = "Alunos:\n";
                label2.Text = "Notas:\n";
                label3.Text = "Média:\n";
                label4.Text = "Média da turma: ";
                for (z = 0; z < mat.GetLength(0); z++)
                {
                    som_a = 0;
                    label1.Text += vet[z]+"\n";
                   for (w = 0; w < mat.GetLength(1); w++)
                   {
                       label2.Text += mat[z, w].ToString() + " ";
                       som_a += mat[z, w];      
                   }
                   med_a = som_a / mat.GetLength(1);
                   label3.Text += med_a.ToString();
                   label3.Text += "\n";
                   label2.Text += "\n";
                   som_t += med_a;
                }
                med_t= som_t / mat.GetLength(0);
                label4.Text += med_t.ToString();
            }
        }
    }
}