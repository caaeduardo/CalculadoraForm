using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
        
    {
        int val1, val2, Resultado;  
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 7;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textResultado.Text = "";
            LBLVal1.Visible=false;

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text; 
            textResultado.Text = res + 1;
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 2;
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 3;
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 4;
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 5;
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 6;
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 8;
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 9;
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            var res = textResultado.Text;
            textResultado.Text = res + 0;
        }

        private void BTNRestaurar_Click(object sender, EventArgs e)
        {
            textResultado.Text = ""; // Limpa a caixa de texto
            LBLVal1.Visible = false; // Oculta o label do primeiro valor
            LBLVal2.Visible = false; // Oculta o label do segundo valor
            LBLSinal.Visible = false; // Oculta o label do sinal da operação
        }

        private void BTNDivisao_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(textResultado.Text);
            textResultado.Text = "";
            LBLSinal.Visible = true;
            LBLSinal.Text = "/";
            LBLVal1.Visible = true;
            LBLVal1.Text = val1.ToString();
        }

        private void BTNMultiplicacao_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(textResultado.Text);
            textResultado.Text = "";
            LBLSinal.Visible = true;
            LBLSinal.Text = "*";
            LBLVal1.Visible = true;
            LBLVal1.Text = val1.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void BTNSoma_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(textResultado.Text);
            textResultado.Text = "";
            LBLSinal.Visible = true;
            LBLSinal.Text = "+";
            LBLVal1.Visible = true;
            LBLVal1.Text = val1.ToString();
        }

        private void BTNIgual_Click(object sender, EventArgs e)
        {
            if (LBLSinal.Text == "+")
            {
                val2 = Convert.ToInt32(textResultado.Text);
                LBLVal2.Visible = true;
                LBLVal2.Text = val2.ToString();
                Resultado = val1 + val2;
                textResultado.Text = Resultado.ToString();
            }
            else if (LBLSinal.Text == "-")
            {
                val2 = Convert.ToInt32(textResultado.Text);
                LBLVal2.Visible = true;
                LBLVal2.Text = val2.ToString();
                Resultado = val1 - val2;
                textResultado.Text = Resultado.ToString();

            }
            else if (LBLSinal.Text == "*")
            {
                val2 = Convert.ToInt32(textResultado.Text);
                LBLVal2.Visible = true;
                LBLVal2.Text = val2.ToString();
                Resultado = val1 * val2;
                textResultado.Text = Resultado.ToString();

            }
            else if (LBLSinal.Text == "/")
            {
                val2 = Convert.ToInt32(textResultado.Text);
                LBLVal2.Visible = true;
                LBLVal2.Text = val2.ToString();
                Resultado = val1 / val2;
                textResultado.Text = Resultado.ToString();

            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
