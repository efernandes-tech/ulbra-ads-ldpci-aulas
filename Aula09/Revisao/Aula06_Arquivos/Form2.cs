using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquivos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivos Texto (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.TextWriter tw = new System.IO.StreamWriter(saveFileDialog1.FileName, false);

                // 2º parâmetro de StreamWriter – determina, para o texto a ser salvo:
                // se o arquivo existe e é false, o arquivo é sobrescrito;
                // se o arquivo existe e é true, o texto é acrescentado ao
                // arquivo; se não existir o arquivo, um novo é criado.
                tw.Write(richTextBox1.Text);
                tw.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog2.Filter = "Arquivos Texto (*.txt)|*.txt";

            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                System.IO.TextReader tr = new System.IO.StreamReader(saveFileDialog2.FileName, false);
                // 2º parâmetro de StreamReader – determina se para o texto
                // a ser aberto é preciso “procurar” por alguma marcação
                // especial (ordem dos bytes) no início do arquivo.
                richTextBox1.Text = tr.ReadToEnd();
                tr.Close();
            }
        }
    }
}
