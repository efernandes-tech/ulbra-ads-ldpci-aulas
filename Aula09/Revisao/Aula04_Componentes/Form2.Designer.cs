namespace Componentes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnOpcao2 = new System.Windows.Forms.RadioButton();
            this.rbtnOpcao1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEscolha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ckbxEscolha1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnOpcao2);
            this.groupBox1.Controls.Add(this.rbtnOpcao1);
            this.groupBox1.Location = new System.Drawing.Point(28, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções:";
            // 
            // rbtnOpcao2
            // 
            this.rbtnOpcao2.AutoSize = true;
            this.rbtnOpcao2.Checked = true;
            this.rbtnOpcao2.Location = new System.Drawing.Point(37, 58);
            this.rbtnOpcao2.Name = "rbtnOpcao2";
            this.rbtnOpcao2.Size = new System.Drawing.Size(83, 21);
            this.rbtnOpcao2.TabIndex = 1;
            this.rbtnOpcao2.TabStop = true;
            this.rbtnOpcao2.Text = "Opção 2";
            this.rbtnOpcao2.UseVisualStyleBackColor = true;
            this.rbtnOpcao2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnOpcao1
            // 
            this.rbtnOpcao1.AutoSize = true;
            this.rbtnOpcao1.Location = new System.Drawing.Point(37, 31);
            this.rbtnOpcao1.Name = "rbtnOpcao1";
            this.rbtnOpcao1.Size = new System.Drawing.Size(83, 21);
            this.rbtnOpcao1.TabIndex = 0;
            this.rbtnOpcao1.Text = "Opção 1";
            this.rbtnOpcao1.UseVisualStyleBackColor = true;
            this.rbtnOpcao1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "lblEscolha";
            // 
            // lblEscolha
            // 
            this.lblEscolha.Location = new System.Drawing.Point(275, 92);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(150, 22);
            this.lblEscolha.TabIndex = 2;
            this.lblEscolha.TextChanged += new System.EventHandler(this.lblEscolha_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.ckbxEscolha1);
            this.panel1.Location = new System.Drawing.Point(28, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(24, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Escolha 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ckbxEscolha1
            // 
            this.ckbxEscolha1.AutoSize = true;
            this.ckbxEscolha1.Checked = true;
            this.ckbxEscolha1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxEscolha1.Location = new System.Drawing.Point(24, 21);
            this.ckbxEscolha1.Name = "ckbxEscolha1";
            this.ckbxEscolha1.Size = new System.Drawing.Size(92, 21);
            this.ckbxEscolha1.TabIndex = 0;
            this.ckbxEscolha1.Text = "Escolha 1";
            this.ckbxEscolha1.UseVisualStyleBackColor = true;
            this.ckbxEscolha1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escolha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(226, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Mais Componentes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnOpcao1;
        private System.Windows.Forms.RadioButton rbtnOpcao2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox lblEscolha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox ckbxEscolha1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}