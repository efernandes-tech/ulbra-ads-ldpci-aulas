using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados_Detalhes
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCliente fc = new FormCliente();
            fc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto();
            fp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMostraDetalhe fmd = new FormMostraDetalhe();
            fmd.Show();
        }
    }
}
