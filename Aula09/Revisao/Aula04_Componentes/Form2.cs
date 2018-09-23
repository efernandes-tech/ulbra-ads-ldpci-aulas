using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblEscolha.Text = rbtnOpcao1.Text + " - primeiro";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblEscolha.Text = rbtnOpcao2.Text + " - segundo";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblEscolha.Text = "Clicou - " + ckbxEscolha1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();
            textBox2.Text = DateTime.Now.ToLongDateString();
            //textBox1.Text = DateTime.Now.ToShortTimeString();
            //textBox2.Text = DateTime.Now.ToShortDateString();
        }

        private void lblEscolha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
