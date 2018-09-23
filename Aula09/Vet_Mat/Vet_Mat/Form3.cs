using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vet_Mat
{
    public partial class Form3 : Form
    {
        int i = 0;
        int[] um = new int[10];

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            if (i < um.Length)
            {
                num = Int32.Parse(textBox1.Text);
                um[i] = num;
                i++;
                textBox1.Clear();
                textBox1.Focus();

                if (i == um.Length)
                {
                    textBox1.Enabled = false;
                    button1.Enabled=false;
                    label1.Enabled = true;
                    textBox2.Visible = true;
                    button2.Visible = true;
                    label1.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int comp, soma=0;

            comp=Int32.Parse(textBox2.Text);
            for (int y = 0; y < um.Length; y++)
            {
                if (comp == um[y])
                     soma += 1;      
            }
                if (soma != 0)
                    label1.Text = "O número está " + soma.ToString() + " vez(es) no vetor";
                else
                    label1.Text = "Número não encontrado!";
            textBox2.Enabled = false;    
            button2.Enabled = false;
        }
    }
}