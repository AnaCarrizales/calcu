using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double num1;//primero
        double num2;//segundo
        double resultado;
        string operacion;
        string backup;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
            backup += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
            backup = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
            backup = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
            backup = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
            backup += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
            backup += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
            backup += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
            backup += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
            backup += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
            backup += "9";
        }

        private void Btnpto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
            backup += ".";
        }

        private void Btnmas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Btnmenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Btnmult_Click(object sender, EventArgs e)
        {
            operacion = "*";
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Btndiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Pantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = num1 - num2;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = num1 * num2;
                    Pantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = num1 / num2;
                    Pantalla.Text = resultado.ToString();
                    break;
            }
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
            
        }

        private void Btnporcentaje_Click(object sender, EventArgs e)
        {
            operacion = "%";
            num1 = double.Parse(Pantalla.Text);
            resultado = num1/100;
            Pantalla.Text = (num1/100).ToString();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }
    }
}
