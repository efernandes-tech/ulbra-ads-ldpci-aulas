namespace BancoDeDados
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label codigoALabel;
            System.Windows.Forms.Label nomeALabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cidadeALabel;
            this.localidadesDataSet = new BancoDeDados.LocalidadesDataSet();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new BancoDeDados.LocalidadesDataSetTableAdapters.AlunoTableAdapter();
            this.tableAdapterManager = new BancoDeDados.LocalidadesDataSetTableAdapters.TableAdapterManager();
            this.alunoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alunoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codigoALabel1 = new System.Windows.Forms.Label();
            this.nomeATextBox = new System.Windows.Forms.TextBox();
            this.telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cidadeAComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new BancoDeDados.LocalidadesDataSetTableAdapters.CidadeTableAdapter();
            codigoALabel = new System.Windows.Forms.Label();
            nomeALabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cidadeALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingNavigator)).BeginInit();
            this.alunoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // localidadesDataSet
            // 
            this.localidadesDataSet.DataSetName = "LocalidadesDataSet";
            this.localidadesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.localidadesDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CidadeTableAdapter = this.cidadeTableAdapter;
            this.tableAdapterManager.UpdateOrder = BancoDeDados.LocalidadesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunoBindingNavigator
            // 
            this.alunoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunoBindingNavigator.BindingSource = this.alunoBindingSource;
            this.alunoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.alunoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.alunoBindingNavigatorSaveItem});
            this.alunoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alunoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunoBindingNavigator.Name = "alunoBindingNavigator";
            this.alunoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunoBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.alunoBindingNavigator.TabIndex = 0;
            this.alunoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // alunoBindingNavigatorSaveItem
            // 
            this.alunoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoBindingNavigatorSaveItem.Image")));
            this.alunoBindingNavigatorSaveItem.Name = "alunoBindingNavigatorSaveItem";
            this.alunoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.alunoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.alunoBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunoBindingNavigatorSaveItem_Click);
            // 
            // codigoALabel
            // 
            codigoALabel.AutoSize = true;
            codigoALabel.Location = new System.Drawing.Point(12, 50);
            codigoALabel.Name = "codigoALabel";
            codigoALabel.Size = new System.Drawing.Size(69, 17);
            codigoALabel.TabIndex = 1;
            codigoALabel.Text = "Codigo A:";
            // 
            // codigoALabel1
            // 
            this.codigoALabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "CodigoA", true));
            this.codigoALabel1.Location = new System.Drawing.Point(87, 50);
            this.codigoALabel1.Name = "codigoALabel1";
            this.codigoALabel1.Size = new System.Drawing.Size(121, 23);
            this.codigoALabel1.TabIndex = 2;
            this.codigoALabel1.Text = "label1";
            // 
            // nomeALabel
            // 
            nomeALabel.AutoSize = true;
            nomeALabel.Location = new System.Drawing.Point(12, 79);
            nomeALabel.Name = "nomeALabel";
            nomeALabel.Size = new System.Drawing.Size(62, 17);
            nomeALabel.TabIndex = 3;
            nomeALabel.Text = "Nome A:";
            // 
            // nomeATextBox
            // 
            this.nomeATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "NomeA", true));
            this.nomeATextBox.Location = new System.Drawing.Point(87, 76);
            this.nomeATextBox.Name = "nomeATextBox";
            this.nomeATextBox.Size = new System.Drawing.Size(121, 22);
            this.nomeATextBox.TabIndex = 4;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 107);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(68, 17);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneMaskedTextBox
            // 
            this.telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Telefone", true));
            this.telefoneMaskedTextBox.Location = new System.Drawing.Point(87, 104);
            this.telefoneMaskedTextBox.Name = "telefoneMaskedTextBox";
            this.telefoneMaskedTextBox.Size = new System.Drawing.Size(121, 22);
            this.telefoneMaskedTextBox.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 135);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(87, 132);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 22);
            this.emailTextBox.TabIndex = 8;
            // 
            // cidadeALabel
            // 
            cidadeALabel.AutoSize = true;
            cidadeALabel.Location = new System.Drawing.Point(12, 163);
            cidadeALabel.Name = "cidadeALabel";
            cidadeALabel.Size = new System.Drawing.Size(69, 17);
            cidadeALabel.TabIndex = 9;
            cidadeALabel.Text = "Cidade A:";
            // 
            // cidadeAComboBox
            // 
            this.cidadeAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alunoBindingSource, "CidadeA", true));
            this.cidadeAComboBox.DataSource = this.cidadeBindingSource;
            this.cidadeAComboBox.DisplayMember = "Nome";
            this.cidadeAComboBox.FormattingEnabled = true;
            this.cidadeAComboBox.Location = new System.Drawing.Point(87, 160);
            this.cidadeAComboBox.Name = "cidadeAComboBox";
            this.cidadeAComboBox.Size = new System.Drawing.Size(121, 24);
            this.cidadeAComboBox.TabIndex = 10;
            this.cidadeAComboBox.ValueMember = "CodigoC";
            this.cidadeAComboBox.Enter += new System.EventHandler(this.cidadeAComboBox_Enter);
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.localidadesDataSet;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(codigoALabel);
            this.Controls.Add(this.codigoALabel1);
            this.Controls.Add(nomeALabel);
            this.Controls.Add(this.nomeATextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneMaskedTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cidadeALabel);
            this.Controls.Add(this.cidadeAComboBox);
            this.Controls.Add(this.alunoBindingNavigator);
            this.Name = "Form2";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingNavigator)).EndInit();
            this.alunoBindingNavigator.ResumeLayout(false);
            this.alunoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalidadesDataSet localidadesDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private LocalidadesDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private LocalidadesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton alunoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codigoALabel1;
        private System.Windows.Forms.TextBox nomeATextBox;
        private System.Windows.Forms.MaskedTextBox telefoneMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox cidadeAComboBox;
        private LocalidadesDataSetTableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
    }
}