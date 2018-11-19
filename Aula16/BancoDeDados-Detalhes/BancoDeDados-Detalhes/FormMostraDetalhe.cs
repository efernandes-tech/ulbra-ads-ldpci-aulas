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
    public partial class FormMostraDetalhe : Form
    {
        public FormMostraDetalhe()
        {
            InitializeComponent();
        }

        private void notasFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notaFiscalDataSet);

        }

        private void notasFBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.notasFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notaFiscalDataSet);

        }

        private void FormMostreDetalhe_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.notaFiscalDataSet.Produtos);
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.Itens'. Você pode movê-la ou removê-la conforme necessário.
            this.itensTableAdapter.Fill(this.notaFiscalDataSet.Itens);
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.Itens'. Você pode movê-la ou removê-la conforme necessário.
            this.itensTableAdapter.Fill(this.notaFiscalDataSet.Itens);
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.Itens'. Você pode movê-la ou removê-la conforme necessário.
            this.itensTableAdapter.Fill(this.notaFiscalDataSet.Itens);
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.Itens'. Você pode movê-la ou removê-la conforme necessário.
            this.itensTableAdapter.Fill(this.notaFiscalDataSet.Itens);
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.Itens'. Você pode movê-la ou removê-la conforme necessário.
            this.itensTableAdapter.Fill(this.notaFiscalDataSet.Itens);
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.notaFiscalDataSet.Clientes);
            // TODO: esta linha de código carrega dados na tabela 'notaFiscalDataSet.NotasF'. Você pode movê-la ou removê-la conforme necessário.
            this.notasFTableAdapter.Fill(this.notaFiscalDataSet.NotasF);

        }

        private void clienteComboBox_Enter(object sender, EventArgs e)
        {
            FormCliente fc = new FormCliente();
            fc.clientesTableAdapter.Fill(this.notaFiscalDataSet.Clientes);
        }

        private void itensDataGridView_Enter(object sender, EventArgs e)
        {
            FormProduto fp = new FormProduto();
            fp.produtosTableAdapter.Fill(this.notaFiscalDataSet.Produtos);
            this.Validate();
            this.notasFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.notaFiscalDataSet);
        }
    }
}
