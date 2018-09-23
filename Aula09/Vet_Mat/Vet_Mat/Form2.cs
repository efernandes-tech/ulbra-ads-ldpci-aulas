using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vet_Mat
{
    public partial class Form2 : Form
    {
        int i = 0;
        int soma = 0;
        int[] um = new int[15];

        public Form2()
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
            }

            if (i == um.Length)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    for (int y = 0; y < um.Length; y++)
                        soma += um[y];
                    label1.Text = label1.Text + soma.ToString();
                }
        }
    }
}