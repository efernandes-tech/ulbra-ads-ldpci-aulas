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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'localidadesDataSet.Aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.localidadesDataSet.Aluno);
            // TODO: esta linha de código carrega dados na tabela 'localidadesDataSet.Cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.localidadesDataSet.Cidade);

        }

        private void oleDbDataAdapter1_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                oleDbDataAdapter1.SelectCommand.CommandText = "select * from aluno where nomea like'"
                + textBox1.Text + "%';";
                if (oleDbDataAdapter1.Fill(localidadesDataSet, "aluno") != 0)
                {
                    localidadesDataSet.Clear();
                    oleDbDataAdapter1.Fill(localidadesDataSet, "aluno");
                    dataGrid1.SetDataBinding(localidadesDataSet, "aluno");
                    MessageBox.Show("Aluno " + textBox1.Text + " encontrado!");
                }
                else
                    MessageBox.Show("Aluno " + textBox1.Text + " NÃO encontrado!");
            }
            else
                MessageBox.Show("Digite um aluno a pesquisar!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedValue.ToString());
            oleDbDataAdapter2.SelectCommand.CommandText = "select * from aluno where CidadeA = " + comboBox1.SelectedValue + "; ";
            if (oleDbDataAdapter2.Fill(localidadesDataSet, "aluno") != 0)
            {
                localidadesDataSet.Clear();
                oleDbDataAdapter2.Fill(localidadesDataSet, "aluno");
                dataGrid1.SetDataBinding(localidadesDataSet, "aluno");
            }
            else
            {
                MessageBox.Show("Não há alunos desta cidade!");
            }
        }
    }
}
