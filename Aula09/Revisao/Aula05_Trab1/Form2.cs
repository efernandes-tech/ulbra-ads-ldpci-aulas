using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV_1
{
    public partial class Form2 : Form
    {
        double sl,spf,nf,sf,sb,INSS,txINSS,sind,ps;
        public Form2()
        {
            sl = 0;
            spf = 0;
            nf = 0;
            sb = 0;
            INSS = 0;
            txINSS = 0;
            sind = 0;
            ps = 0;

            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            txINSS = 10;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = true;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            txINSS = 9;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            txINSS = 8;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                checkBox1.Enabled = false;
            }   
            checkBox2.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            txINSS = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (salarioBruto.Text.Length == 0
                || numeroFilhos.Text.Length == 0
                || salarioFilho.Text.Length == 0) {
                MessageBox.Show("Digite os valores.", "Atenção");
                return;
            } 

            // Sal. Fam.
            spf = double.Parse(salarioFilho.Text);
            nf = double.Parse(numeroFilhos.Text);

            sf = spf * nf;

            textBox1.Text = sf.ToString();

            // Si
            if (checkBox1.Checked)
            {
                textBox2.Text = "30";
                sind = 30;
            }
            else
            {
                textBox2.Text = "";
                sind = 0;
            }


            // Pl
            if (checkBox2.Checked) {
                textBox3.Text = "50";
                ps = 50;
            }
            else
            {
                textBox3.Text = "";
                ps = 0;
            }

            // INSS
            sb = double.Parse(salarioBruto.Text);

            INSS = (sb * txINSS) / 100;

            textBox4.Text = INSS.ToString();

            // Salário Líquido = (Salário Bruto - (Sindicato + Plano de Saúde + INSS)) + Salário Família
            sl = (sb - (sind + ps + INSS)) + sf;
            textBox5.Text = sl.ToString();

        }
    }
}
