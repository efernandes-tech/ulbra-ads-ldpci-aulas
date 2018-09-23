using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasDeControle
{
    public partial class Form1 : Form
    {
        double a, b;    // float.Parse() ou Double.Parse()
        int num, x;     // Int32.Parse() ou Int64.Parse()
        // bool x1;     // bool.Parse()
        // char z;      // char.Parse()
        string y;

        private void Form1_Load(object sender, EventArgs e)
        {
            num = 5;
            a = 20.3;
            b = 18.55;

            // x1 = true;
            // z = 'w';
            // c = "Boa Noite!";

            // const double PI = 3.1415926535;
            // const float raio = 12;
            // const int idade = 18;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a > b)
                MessageBox.Show("A é maior do que B");
            else
                if (b > a)
                    MessageBox.Show("B é maior do que A");
                else
                    if (b == a)
                        MessageBox.Show("B é igual a A");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (num)
            {
                case 1:
                    MessageBox.Show("O número digitado é UM");
                    break;
                case 2:
                    MessageBox.Show("O número digitado é DOIS");
                    break;
                case 3:
                case 4:
                    MessageBox.Show("O número digitado é TRÊS ou QUATRO");
                    break;
                default:
                    MessageBox.Show("O número digitado é diferente");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (a > 10)
            {
                MessageBox.Show("O valor de A é: " + a);
                a--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            do
            {
                MessageBox.Show("O valor de B é: " + b);
                b--;
            } while (b > 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (x = 1; x < 10; x++)
            {
                y = y + x + " ";
                MessageBox.Show("Valores de x: " + y);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
