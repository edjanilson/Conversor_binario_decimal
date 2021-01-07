using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaoBinarioDecimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNum0.Text == "" || txtNum1.Text == "" || txtNum2.Text == "" || txtNum3.Text == "" || txtNum4.Text == "" || txtNum5.Text == "" || txtNum6.Text == "" || txtNum7.Text == "")
            {
                MessageBox.Show("Dados ausentes. Insira todos os números e tente novamente.", "====Atenção====", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    double valor_total;

                    //Recebe um número em binário
                    int num0, num1, num2, num3, num4, num5, num6, num7;
                    num0 = int.Parse(txtNum0.Text);
                    num1 = int.Parse(txtNum1.Text);
                    num2 = int.Parse(txtNum2.Text);
                    num3 = int.Parse(txtNum3.Text);
                    num4 = int.Parse(txtNum4.Text);
                    num5 = int.Parse(txtNum5.Text);
                    num6 = int.Parse(txtNum6.Text);
                    num7 = int.Parse(txtNum7.Text);

                    //Realiza a potenciação
                    double doiselevadoazero = Math.Pow(2, 0);
                    double doiselevadoaum = Math.Pow(2, 1);
                    double doiselevadoadois = Math.Pow(2, 2);
                    double doiselevadoatres = Math.Pow(2, 3);
                    double doiselevadoaquatro = Math.Pow(2, 4);
                    double doiselevadoacinco = Math.Pow(2, 5);
                    double doiselevadoaseis = Math.Pow(2, 6);
                    double doiselevadoasete = Math.Pow(2, 7);

                    if (num0<2 && num1<2 && num2<2 && num3 < 2 && num4 < 2 && num5 < 2 && num6 < 2 && num7 < 2)
                    {


                        //Junta o cálculo da potenciação com o número binário em questão
                        double valor1 = doiselevadoazero * num0;
                        double valor2 = doiselevadoaum * num1;
                        double valor3 = doiselevadoadois * num2;
                        double valor4 = doiselevadoatres * num3;
                        double valor5 = doiselevadoaquatro * num4;
                        double valor6 = doiselevadoacinco * num5;
                        double valor7 = doiselevadoaseis * num6;
                        double valor8 = doiselevadoasete * num7;

                        //Calcula o valor final
                        valor_total = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8;

                        //Exibe o valor final na textbox
                        txtResultadoFinal.Text = valor_total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Os números precisam estar entre 0 e 1.","====Erro====",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        txtNum0.Clear();
                        txtNum1.Clear();
                        txtNum2.Clear();
                        txtNum3.Clear();
                        txtNum4.Clear();
                        txtNum5.Clear();
                        txtNum6.Clear();
                        txtNum7.Clear();
                    }

                }catch(FormatException)
                {
                    MessageBox.Show("Entrada de dados no formato incorreto. Insira apenas números e tente novamente.", "====Erro====", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum0.Clear();
                    txtNum1.Clear();
                    txtNum2.Clear();
                    txtNum3.Clear();
                    txtNum4.Clear();
                    txtNum5.Clear();
                    txtNum6.Clear();
                    txtNum7.Clear();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fecha o programa
            Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtNum0.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtNum4.Clear();
            txtNum5.Clear();
            txtNum6.Clear();
            txtNum7.Clear();
            txtResultadoFinal.Clear();

        }
    }
}
