using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class frmNOME : Form
    {
        public frmNOME()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxNOME_Click(object sender, EventArgs e)
        {

        }

        private void btnNOME_Click(object sender, EventArgs e)
        {
            tbxNOME.Clear();
        }

        private void btnNOME2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem Simples...");

            Application.Exit();
        }

        private void pbxNOME_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Essa ação mostra esta caixa de mensagem!\nClique OK para fechá-la...", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
