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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxFones.Items.Add(mtbxFoneDigitado.Text);
            mtbxFoneDigitado.Clear();
            mtbxFoneDigitado.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string item = lbxFones.SelectedItem.ToString();
            lbxFones.Items.Remove(item);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbxFones.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.lblEscolha.Text = textBox3.Text;
        }
    }
}
