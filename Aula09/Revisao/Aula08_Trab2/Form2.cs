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
    public partial class Form2 : Form
    {

        const int TAM_VET = 5;
        int[] vet1 = new int[TAM_VET];
        int[] vet2 = new int[TAM_VET];
        int[] vet3 = new int[TAM_VET];
        int n, cont = 0, pos = -1;
        string aux;


        public Form2()
        {
            InitializeComponent();

            textBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out n))
            {
                vet1[cont++] = n;
                listBox1.Items.Add("Valor " + n.ToString() + " adicionado no vetor A.");
                label2.Text = mostraVetor(vet1);
                textBox1.Text = "";
                textBox1.Focus();

                if (cont == TAM_VET)
                {
                    label1.Text = "Digite um valor p/ o Vetor B:";
                    button1.Visible = false;
                    button2.Visible = true;
                    // listBox1.Items.Clear();
                    cont = 0;
                }
            }
            else
            {
                MessageBox.Show("Digite um valor inteiro!");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out n))
            {
                vet2[cont++] = n;
                listBox1.Items.Add("Valor " + n.ToString() + " adicionado no vetor B.");
                label3.Text = mostraVetor(vet2);
                textBox1.Text = "";
                textBox1.Focus();

                if (cont == TAM_VET)
                {
                    label1.Text = "Digite um número:";
                    button2.Visible = false;
                    button3.Visible = true;
                    // listBox1.Items.Clear();
                    cont = 0;
                }
            }
            else
            {
                MessageBox.Show("Digite um valor inteiro!");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out n))
            {
                pos = -1; cont = 0; vet3 = new int[TAM_VET];

                listBox1.Items.Clear();
                
                for (int i = 0; i < TAM_VET; i++)
                {
                    if (n == vet1[i])
                    {
                        pos = i;
                    }
                }

                if (pos < 0)
                {
                    listBox1.Items.Add("Vetor A = " + listaVetor(vet1));
                    listBox1.Items.Add("Vetor B = " + listaVetor(vet2));
                    listBox1.Items.Add("Número lido = " + n.ToString() + " (não consta no ");
                    listBox1.Items.Add("Vetor A)");
                    MessageBox.Show("Digite outro número!");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else
                {
                    for (int i = 0; i < TAM_VET; i++)
                    {
                        if (n == vet2[i])
                        {
                            cont++;
                        }
                    }

                    listBox1.Items.Add("Vetor A = " + listaVetor(vet1));
                    listBox1.Items.Add("Vetor B = " + listaVetor(vet2));
                    listBox1.Items.Add("Número lido = " + n.ToString() + " (Consta no ");
                    listBox1.Items.Add("Vetor A)\n");

                    if (cont > 0)
                    {
                        for (int j = 0; j < cont; j++)
                        {
                            vet3[j] = n;
                        }

                        listBox1.Items.Add("Vetor C = " + listaVetor(vet3));
                        label4.Text = mostraVetor(vet3);
                    }
                    else
                    {
                        listBox1.Items.Add("Vetor C = (vazio, pois o número ");
                        listBox1.Items.Add(n.ToString() + " não está no Vetor B)");
                    }
                }
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Digite um número inteiro!");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private string mostraVetor(int[] v)
        {
            string ret = "";
            for (int i = 0; i < TAM_VET; i++)
            {
                ret += "[ " + (v[i] != 0 ? v[i].ToString() : " ") + " ] ";
            }
            return ret;
        }

        private string listaVetor(int[] v)
        {
            string ret = "";
            for (int i = 0; i < TAM_VET; i++)
            {
                ret += v[i].ToString();
                if (i < TAM_VET - 1)
                {
                    ret += ", ";
                }
            }
            return ret;
        }
    }
}
