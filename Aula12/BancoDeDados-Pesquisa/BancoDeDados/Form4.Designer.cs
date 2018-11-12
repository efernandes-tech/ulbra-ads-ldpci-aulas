namespace BancoDeDados
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.localidadesDataSet = new BancoDeDados.LocalidadesDataSet();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new BancoDeDados.LocalidadesDataSetTableAdapters.CidadeTableAdapter();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new BancoDeDados.LocalidadesDataSetTableAdapters.AlunoTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.localidadesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.alunoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.cidadeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nome";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Por cidade:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cidade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // localidadesDataSet
            // 
            this.localidadesDataSet.DataSetName = "LocalidadesDataSet";
            this.localidadesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.localidadesDataSetBindingSource;
            // 
            // localidadesDataSetBindingSource
            // 
            this.localidadesDataSetBindingSource.DataSource = this.localidadesDataSet;
            this.localidadesDataSetBindingSource.Position = 0;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cidadeBindingSource2;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "CodigoC";
            // 
            // cidadeBindingSource1
            // 
            this.cidadeBindingSource1.DataMember = "Cidade";
            this.cidadeBindingSource1.DataSource = this.localidadesDataSetBindingSource;
            // 
            // localidadesDataSetBindingSource1
            // 
            this.localidadesDataSetBindingSource1.DataSource = this.localidadesDataSet;
            this.localidadesDataSetBindingSource1.Position = 0;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Localidades.mdb";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT     Aluno.*, Cidade.*\r\nFROM        (Aluno INNER JOIN\r\n                  Ci" +
    "dade ON Aluno.CidadeA = Cidade.CodigoC)";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Aluno", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CodigoA", "CodigoA"),
                        new System.Data.Common.DataColumnMapping("NomeA", "NomeA"),
                        new System.Data.Common.DataColumnMapping("Telefone", "Telefone"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("CidadeA", "CidadeA"),
                        new System.Data.Common.DataColumnMapping("CodigoC", "CodigoC"),
                        new System.Data.Common.DataColumnMapping("Nome", "Nome"),
                        new System.Data.Common.DataColumnMapping("Estado", "Estado")})});
            this.oleDbDataAdapter1.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.oleDbDataAdapter1_RowUpdated);
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionText = "Consulta de Alunos";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.alunoBindingSource1;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(33, 132);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.Size = new System.Drawing.Size(725, 165);
            this.dataGrid1.TabIndex = 6;
            // 
            // alunoBindingSource1
            // 
            this.alunoBindingSource1.DataMember = "Aluno";
            this.alunoBindingSource1.DataSource = this.localidadesDataSet;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT     Aluno.*, Cidade.*\r\nFROM        (Aluno INNER JOIN\r\n                  Ci" +
    "dade ON Aluno.CidadeA = Cidade.CodigoC)";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection2;
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Aluno", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CodigoA", "CodigoA"),
                        new System.Data.Common.DataColumnMapping("NomeA", "NomeA"),
                        new System.Data.Common.DataColumnMapping("Telefone", "Telefone"),
                        new System.Data.Common.DataColumnMapping("Email", "Email"),
                        new System.Data.Common.DataColumnMapping("CidadeA", "CidadeA"),
                        new System.Data.Common.DataColumnMapping("CodigoC", "CodigoC"),
                        new System.Data.Common.DataColumnMapping("Nome", "Nome"),
                        new System.Data.Common.DataColumnMapping("Estado", "Estado")})});
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Localidades.mdb";
            // 
            // cidadeBindingSource2
            // 
            this.cidadeBindingSource2.DataMember = "Cidade";
            this.cidadeBindingSource2.DataSource = this.localidadesDataSet;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Pesq. Aluno";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private LocalidadesDataSet localidadesDataSet;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private LocalidadesDataSetTableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource localidadesDataSetBindingSource;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private LocalidadesDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource cidadeBindingSource1;
        private System.Windows.Forms.BindingSource localidadesDataSetBindingSource1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.BindingSource alunoBindingSource1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Windows.Forms.BindingSource cidadeBindingSource2;
    }
}