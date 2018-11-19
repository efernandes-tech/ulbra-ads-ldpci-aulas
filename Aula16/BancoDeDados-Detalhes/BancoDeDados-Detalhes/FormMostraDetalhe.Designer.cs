namespace BancoDeDados_Detalhes
{
    partial class FormMostraDetalhe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoNFLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label clienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostraDetalhe));
            this.notaFiscalDataSet = new BancoDeDados_Detalhes.NotaFiscalDataSet();
            this.notasFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasFTableAdapter = new BancoDeDados_Detalhes.NotaFiscalDataSetTableAdapters.NotasFTableAdapter();
            this.tableAdapterManager = new BancoDeDados_Detalhes.NotaFiscalDataSetTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new BancoDeDados_Detalhes.NotaFiscalDataSetTableAdapters.ClientesTableAdapter();
            this.itensTableAdapter = new BancoDeDados_Detalhes.NotaFiscalDataSetTableAdapters.ItensTableAdapter();
            this.notasFBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.notasFBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoNFTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.itensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itensDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosTableAdapter = new BancoDeDados_Detalhes.NotaFiscalDataSetTableAdapters.ProdutosTableAdapter();
            codigoNFLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasFBindingNavigator)).BeginInit();
            this.notasFBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoNFLabel
            // 
            codigoNFLabel.AutoSize = true;
            codigoNFLabel.Location = new System.Drawing.Point(3, 11);
            codigoNFLabel.Name = "codigoNFLabel";
            codigoNFLabel.Size = new System.Drawing.Size(60, 13);
            codigoNFLabel.TabIndex = 1;
            codigoNFLabel.Text = "Codigo NF:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(3, 38);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 3;
            dataLabel.Text = "Data:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(3, 63);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(42, 13);
            clienteLabel.TabIndex = 5;
            clienteLabel.Text = "Cliente:";
            // 
            // notaFiscalDataSet
            // 
            this.notaFiscalDataSet.DataSetName = "NotaFiscalDataSet";
            this.notaFiscalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasFBindingSource
            // 
            this.notasFBindingSource.DataMember = "NotasF";
            this.notasFBindingSource.DataSource = this.notaFiscalDataSet;
            // 
            // notasFTableAdapter
            // 
            this.notasFTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.ItensTableAdapter = this.itensTableAdapter;
            this.tableAdapterManager.NotasFTableAdapter = this.notasFTableAdapter;
            this.tableAdapterManager.ProdutosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BancoDeDados_Detalhes.NotaFiscalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // itensTableAdapter
            // 
            this.itensTableAdapter.ClearBeforeFill = true;
            // 
            // notasFBindingNavigator
            // 
            this.notasFBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notasFBindingNavigator.BindingSource = this.notasFBindingSource;
            this.notasFBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notasFBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notasFBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.notasFBindingNavigatorSaveItem});
            this.notasFBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notasFBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notasFBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notasFBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notasFBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notasFBindingNavigator.Name = "notasFBindingNavigator";
            this.notasFBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notasFBindingNavigator.Size = new System.Drawing.Size(384, 25);
            this.notasFBindingNavigator.TabIndex = 0;
            this.notasFBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // notasFBindingNavigatorSaveItem
            // 
            this.notasFBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notasFBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notasFBindingNavigatorSaveItem.Image")));
            this.notasFBindingNavigatorSaveItem.Name = "notasFBindingNavigatorSaveItem";
            this.notasFBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.notasFBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.notasFBindingNavigatorSaveItem.Click += new System.EventHandler(this.notasFBindingNavigatorSaveItem_Click_1);
            // 
            // codigoNFTextBox
            // 
            this.codigoNFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasFBindingSource, "CodigoNF", true));
            this.codigoNFTextBox.Enabled = false;
            this.codigoNFTextBox.Location = new System.Drawing.Point(69, 8);
            this.codigoNFTextBox.Name = "codigoNFTextBox";
            this.codigoNFTextBox.ReadOnly = true;
            this.codigoNFTextBox.Size = new System.Drawing.Size(200, 20);
            this.codigoNFTextBox.TabIndex = 2;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasFBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(69, 34);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 4;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notasFBindingSource, "Cliente", true));
            this.clienteComboBox.DataSource = this.clientesBindingSource;
            this.clienteComboBox.DisplayMember = "Nome";
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(69, 60);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.clienteComboBox.TabIndex = 6;
            this.clienteComboBox.ValueMember = "CodigoC";
            this.clienteComboBox.Enter += new System.EventHandler(this.clienteComboBox_Enter);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.notaFiscalDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(codigoNFLabel);
            this.panel1.Controls.Add(this.clienteComboBox);
            this.panel1.Controls.Add(this.codigoNFTextBox);
            this.panel1.Controls.Add(clienteLabel);
            this.panel1.Controls.Add(dataLabel);
            this.panel1.Controls.Add(this.dataDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 100);
            this.panel1.TabIndex = 7;
            // 
            // itensBindingSource
            // 
            this.itensBindingSource.DataMember = "NotasFItens";
            this.itensBindingSource.DataSource = this.notasFBindingSource;
            // 
            // itensDataGridView
            // 
            this.itensDataGridView.AutoGenerateColumns = false;
            this.itensDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itensDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.itensDataGridView.DataSource = this.itensBindingSource;
            this.itensDataGridView.Location = new System.Drawing.Point(12, 141);
            this.itensDataGridView.Name = "itensDataGridView";
            this.itensDataGridView.RowHeadersVisible = false;
            this.itensDataGridView.Size = new System.Drawing.Size(360, 220);
            this.itensDataGridView.TabIndex = 7;
            this.itensDataGridView.Enter += new System.EventHandler(this.itensDataGridView_Enter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoI";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodigoI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NotaFiscal";
            this.dataGridViewTextBoxColumn2.HeaderText = "NotaFiscal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn3.DataSource = this.produtosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "CodigoP";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.notaFiscalDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // FormMostraDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.itensDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notasFBindingNavigator);
            this.Name = "FormMostraDetalhe";
            this.Text = "FormMostraDetalhe";
            this.Load += new System.EventHandler(this.FormMostreDetalhe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notaFiscalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasFBindingNavigator)).EndInit();
            this.notasFBindingNavigator.ResumeLayout(false);
            this.notasFBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotaFiscalDataSet notaFiscalDataSet;
        private System.Windows.Forms.BindingSource notasFBindingSource;
        private NotaFiscalDataSetTableAdapters.NotasFTableAdapter notasFTableAdapter;
        private NotaFiscalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notasFBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton notasFBindingNavigatorSaveItem;
        private NotaFiscalDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.TextBox codigoNFTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private NotaFiscalDataSetTableAdapters.ItensTableAdapter itensTableAdapter;
        private System.Windows.Forms.BindingSource itensBindingSource;
        private System.Windows.Forms.DataGridView itensDataGridView;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private NotaFiscalDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
    }
}