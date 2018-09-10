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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Underline);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, label1.Font.Style ^ FontStyle.Strikeout);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Courier New", label2.Font.Size, label2.Font.Style);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Comic Sans MS", label2.Font.Size, label2.Font.Style);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Arial", label2.Font.Size, label2.Font.Style);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Papyrus", label2.Font.Size, label2.Font.Style);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Forte", label2.Font.Size, label2.Font.Style);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Microsoft Sans Serif", label2.Font.Size, label2.Font.Style);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Green;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Yellow;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\");
            // Windows Explorer.
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.google.com");
            // Browser padrão.
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
            // Notepad.
        }
    }
}
