using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vet_Mat
{
    public partial class Form4 : Form
    {
        int i = 0, j=0;
        int[] par = new int[10];
        int[] impar = new int[10];

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            num = Int32.Parse(textBox1.Text);
            if ((i < par.Length) || (j < impar.Length) || (num!=0))
            {
                if ((num % 2) == 0)
                {
                    if (num != 0)
                    {
                        par[i] = num;
                        i++;
                    }
                }
                else
                {
                    impar[j] = num;
                    j++;
                }

                textBox1.Clear();
                textBox1.Focus();

                if ((i == par.Length) || (j==impar.Length) || (num==0))
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;

                    label1.Visible = true;
                    label1.Text="Vetor Pares \n";
                    for (int y = 0; y < i; y++)
                    {
                        label1.Text += par[y].ToString() + " ";
                    }
                    label2.Visible = true;
                    label2.Text="Vetor Ímpares \n";
                    for (int x = 0; x < j; x++)
                    {
                        label2.Text += impar[x].ToString() + " ";
                    }
                }
            }
        }
    }
}