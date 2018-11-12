using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localidadesDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'localidadesDataSet.Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.localidadesDataSet.Cidade);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cidadeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.localidadesDataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Não é possível deletar esta cidade.\n"
                    + "Há alunos relacionados a ela.",
                    "Erro ao Excluir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.cidadeTableAdapter.Fill(this.localidadesDataSet.Cidade);
            }
        }
    }
}
