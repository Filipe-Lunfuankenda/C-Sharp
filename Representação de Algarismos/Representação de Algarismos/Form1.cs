using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Representação_de_Algarismos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de Representação de Algarismos";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(textBox1.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            textBox1.Text = Convert.ToString(i2);
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(num, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(num, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(num, 8);
        }

        private void btnRoman_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] dezenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] milhares = { "", "M", "MM", "MMM" };

            if (num <= 0 || num > 3999)
            {
               MessageBox.Show("O número deve ser maior que zero e estar entre 1 e 3999");
                return;
            }

            string roman = milhares[num / 1000] + centenas[(num % 1000) / 100] + dezenas[(num % 100) / 10] + unidades[num % 10];

            textBox1.Text = roman;
        }

        private void btnDuodecimal_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int num))
            {
                if(num == 0)
                {
                    textBox1.Text = Convert.ToString(0);
                    return;
                }

                string[] simbols = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "X", "E" };
                int tamanhoArray = 8;
                string[] algarismos = new string[tamanhoArray];
                int contador = 0;

                while(num > 0 && contador < tamanhoArray)
                {
                    int resto = num % 12;
                    algarismos[contador] = simbols[resto];
                    num /= 12;
                    contador++;
                }

                string resultado = "";
                for(int i = contador - 1; i >=0; i--)
                {
                    resultado += algarismos[i];
                }

                textBox1.Text = resultado;
            }
            else
            {
                MessageBox.Show("Por favor, digite um número inteiro válido.");
            }
        }

        private void numeros(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (textBox1.Text == "0")
                textBox1.Text = "";
            {
                if (num.Text == ",")
                {
                    if (!textBox1.Text.Contains(","))
                        textBox1.Text = textBox1.Text + num.Text;
                }
                else
                {
                    textBox1.Text += num.Text;
                }
            }
        }
    }
}
