using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vet_Mat
{
    public partial class Form5 : Form
    {
        int[,] mat = new int[3, 2];
        int i=0,j=0;

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

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
                label3.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
                textBox2.Focus();
            }
            //MessageBox.Show(mat.GetLength(0).ToString(),"linhas de mat");
            //MessageBox.Show(mat.GetLength(1).ToString(), "colunas de mat");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int val, w;

            val = Int32.Parse(textBox2.Text);
            label1.Visible = true;
            label1.Text = "Matriz Original:\n";
            for (int z = 0; z < mat.GetLength(0); z++)
            {
                for (w = 0; w < mat.GetLength(1); w++)
                    label1.Text += mat[z, w] + " ";
                if (w == mat.GetLength(1))
                    label1.Text += "\n";
            }


            for (int z = 0; z < mat.GetLength(0); z++)
                for (w = 0; w < mat.GetLength(1); w++)
                    mat[z, w] = mat[z, w] * val;

            label2.Visible = true;
            label2.Text = "Matriz Modificada:\n";
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