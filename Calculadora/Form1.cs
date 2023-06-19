using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    TxtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "MULT")
                {
                    TxtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "SUB")
                {
                    TxtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "DIV")
                {
                    TxtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
            

        }

        private void button12_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = "";
            TxtResultado.Text = "";
            operacao = "";
            valor1 = 0;
            valor2 = 0;

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //concatenando o texto
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                //informando para o programa que é uma soma
                operacao = "SOMA";

                labelOperacao.Text = "+";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "MULT";

                labelOperacao.Text = "X";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "SUB";

                labelOperacao.Text = "-";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "DIV";

                labelOperacao.Text = "/";
            }
        }
    }
}
