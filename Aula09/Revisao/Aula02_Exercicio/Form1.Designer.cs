namespace Exercicio
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAumenta = new System.Windows.Forms.Button();
            this.btnDiminui = new System.Windows.Forms.Button();
            this.btnMudaTamanho = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOutroFormulario = new System.Windows.Forms.Button();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.lblBotoes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAumenta
            // 
            this.btnAumenta.Location = new System.Drawing.Point(47, 66);
            this.btnAumenta.Name = "btnAumenta";
            this.btnAumenta.Size = new System.Drawing.Size(100, 27);
            this.btnAumenta.TabIndex = 0;
            this.btnAumenta.Text = "Aumenta";
            this.btnAumenta.UseVisualStyleBackColor = true;
            // 
            // btnDiminui
            // 
            this.btnDiminui.Location = new System.Drawing.Point(241, 66);
            this.btnDiminui.Name = "btnDiminui";
            this.btnDiminui.Size = new System.Drawing.Size(100, 27);
            this.btnDiminui.TabIndex = 1;
            this.btnDiminui.Text = "Diminui";
            this.btnDiminui.UseVisualStyleBackColor = true;
            this.btnDiminui.Click += new System.EventHandler(this.btnDiminui_Click);
            // 
            // btnMudaTamanho
            // 
            this.btnMudaTamanho.Location = new System.Drawing.Point(150, 113);
            this.btnMudaTamanho.Name = "btnMudaTamanho";
            this.btnMudaTamanho.Size = new System.Drawing.Size(91, 47);
            this.btnMudaTamanho.TabIndex = 2;
            this.btnMudaTamanho.Text = "Muda Tamanho";
            this.btnMudaTamanho.UseVisualStyleBackColor = true;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDica.Location = new System.Drawing.Point(112, 179);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(165, 20);
            this.lblDica.TabIndex = 4;
            this.lblDica.Text = "Clique na imagem!";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(266, 396);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOutroFormulario
            // 
            this.btnOutroFormulario.BackColor = System.Drawing.Color.Maroon;
            this.btnOutroFormulario.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOutroFormulario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOutroFormulario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOutroFormulario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOutroFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOutroFormulario.Location = new System.Drawing.Point(47, 396);
            this.btnOutroFormulario.Name = "btnOutroFormulario";
            this.btnOutroFormulario.Size = new System.Drawing.Size(137, 36);
            this.btnOutroFormulario.TabIndex = 6;
            this.btnOutroFormulario.Text = "Outro Formulário";
            this.btnOutroFormulario.UseVisualStyleBackColor = false;
            this.btnOutroFormulario.Click += new System.EventHandler(this.btnOutroFormulario_Click);
            // 
            // pbxImagem
            // 
            this.pbxImagem.Image = global::Exercicio.Properties.Resources._20872204_1_;
            this.pbxImagem.Location = new System.Drawing.Point(47, 227);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(294, 134);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagem.TabIndex = 3;
            this.pbxImagem.TabStop = false;
            this.pbxImagem.Click += new System.EventHandler(this.pbxImagem_Click);
            // 
            // lblBotoes
            // 
            this.lblBotoes.AutoSize = true;
            this.lblBotoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblBotoes.Location = new System.Drawing.Point(108, 24);
            this.lblBotoes.Name = "lblBotoes";
            this.lblBotoes.Size = new System.Drawing.Size(175, 20);
            this.lblBotoes.TabIndex = 7;
            this.lblBotoes.Text = "Clique nos botões...";
            this.lblBotoes.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.lblBotoes);
            this.Controls.Add(this.btnOutroFormulario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.pbxImagem);
            this.Controls.Add(this.btnMudaTamanho);
            this.Controls.Add(this.btnDiminui);
            this.Controls.Add(this.btnAumenta);
            this.Name = "frmPrincipal";
            this.Text = "Trabalhando com propriedades";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAumenta;
        private System.Windows.Forms.Button btnDiminui;
        private System.Windows.Forms.Button btnMudaTamanho;
        private System.Windows.Forms.PictureBox pbxImagem;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOutroFormulario;
        private System.Windows.Forms.Label lblBotoes;
    }
}

