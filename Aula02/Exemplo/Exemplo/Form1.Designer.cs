namespace Exemplo
{
    partial class frmNOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNOME));
            this.lblNOME = new System.Windows.Forms.Label();
            this.tbxNOME = new System.Windows.Forms.TextBox();
            this.btnNOME = new System.Windows.Forms.Button();
            this.btnNOME2 = new System.Windows.Forms.Button();
            this.pbxNOME = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNOME)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNOME
            // 
            this.lblNOME.AutoSize = true;
            this.lblNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOME.Location = new System.Drawing.Point(108, 56);
            this.lblNOME.Name = "lblNOME";
            this.lblNOME.Size = new System.Drawing.Size(147, 17);
            this.lblNOME.TabIndex = 0;
            this.lblNOME.Text = "Primeiro Aplicativo!";
            this.lblNOME.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxNOME
            // 
            this.tbxNOME.Location = new System.Drawing.Point(95, 102);
            this.tbxNOME.Name = "tbxNOME";
            this.tbxNOME.Size = new System.Drawing.Size(174, 22);
            this.tbxNOME.TabIndex = 1;
            this.tbxNOME.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNOME
            // 
            this.btnNOME.Location = new System.Drawing.Point(145, 161);
            this.btnNOME.Name = "btnNOME";
            this.btnNOME.Size = new System.Drawing.Size(75, 23);
            this.btnNOME.TabIndex = 2;
            this.btnNOME.Text = "Limpar";
            this.btnNOME.UseVisualStyleBackColor = true;
            this.btnNOME.Click += new System.EventHandler(this.btnNOME_Click);
            // 
            // btnNOME2
            // 
            this.btnNOME2.Location = new System.Drawing.Point(145, 396);
            this.btnNOME2.Name = "btnNOME2";
            this.btnNOME2.Size = new System.Drawing.Size(75, 23);
            this.btnNOME2.TabIndex = 4;
            this.btnNOME2.Text = "Sair";
            this.btnNOME2.UseVisualStyleBackColor = true;
            this.btnNOME2.Click += new System.EventHandler(this.btnNOME2_Click);
            // 
            // pbxNOME
            // 
            this.pbxNOME.Image = ((System.Drawing.Image)(resources.GetObject("pbxNOME.Image")));
            this.pbxNOME.Location = new System.Drawing.Point(51, 218);
            this.pbxNOME.Name = "pbxNOME";
            this.pbxNOME.Size = new System.Drawing.Size(251, 135);
            this.pbxNOME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNOME.TabIndex = 5;
            this.pbxNOME.TabStop = false;
            this.pbxNOME.Click += new System.EventHandler(this.pbxNOME_Click_1);
            // 
            // frmNOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.pbxNOME);
            this.Controls.Add(this.btnNOME2);
            this.Controls.Add(this.btnNOME);
            this.Controls.Add(this.tbxNOME);
            this.Controls.Add(this.lblNOME);
            this.Name = "frmNOME";
            this.Text = "Primeira Aplicação";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNOME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNOME;
        private System.Windows.Forms.TextBox tbxNOME;
        private System.Windows.Forms.Button btnNOME;
        private System.Windows.Forms.Button btnNOME2;
        private System.Windows.Forms.PictureBox pbxNOME;
    }
}

