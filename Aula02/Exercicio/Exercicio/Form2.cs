using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class frmOutro : Form
    {
        public frmOutro()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                tbxResultado.Text = (float.Parse(tbxNum1.Text) +
                float.Parse(tbxNum2.Text)).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor inválido ou em branco!", "Erro ao digitar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNum1.Clear();
            tbxNum2.Clear();
            tbxResultado.Clear();
            tbxNum1.Focus(); // Colocar o foco para o 1º valor.
        }
    }
}
