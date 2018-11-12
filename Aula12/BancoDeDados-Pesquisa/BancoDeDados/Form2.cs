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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.localidadesDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'localidadesDataSet.Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.localidadesDataSet.Cidade);
            // TODO: esta linha de código carrega dados na tabela 'localidadesDataSet.Aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.localidadesDataSet.Aluno);

        }

        private void cidadeAComboBox_Enter(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.cidadeTableAdapter.Fill(this.localidadesDataSet.Cidade);
        }
    }
}
