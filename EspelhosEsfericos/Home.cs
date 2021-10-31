using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspelhosEsfericos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public double focal;
        public double objeto;
        public double imagem;

        private void Calc()
        {
            int nulo = 0; //Variável que calcula a quantidade de campos com valores nulos/vazios
            string incognita = ""; //Variável que define a incognita a ser calculada

            //Condição para definir +1 para cada campo nulo
            if (txtFocal.Text == "")
            {
                nulo += 1;
            }
            else
            {
                focal = double.Parse(txtFocal.Text); //Passar o valor do campo de texto para decimal
            }
            if (txtObjeto.Text == "")
            {
                nulo += 1;
            }
            else
            {
                objeto = double.Parse(txtObjeto.Text);
            }
            if (txtImagem.Text == "")
            {
                nulo += 1;
            }
            else
            {
                imagem = double.Parse(txtImagem.Text);
            }


            //Caso tenha mais de dois campos nulos, o programa emitirá um aviso
            if (nulo >= 2)
            {
                MessageBox.Show("São necessários no mínimo dois valores para que o cálculo seja realizado!", "Campos vazios!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Erase();
            }
            else if (nulo == 0)
            {
                MessageBox.Show("São necessários apenas dois valores para que o cálculo seja realizado!", "Campo preenchido a mais!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Erase();
            }
            else
            {
                //Verificação de qual campo está vazio para definir a incognita
                if (txtImagem.Text == "")
                {
                    incognita = "imagem";
                }
                else if (txtObjeto.Text == "")
                {
                    incognita = "objeto";
                }
                else if (txtFocal.Text == "")
                {
                    incognita = "focal";
                }

                double numerador = 0;
                double denominador = 0;

                //Cálculo para encontrar o valor da incognita
                switch (incognita)
                {
                    case "imagem":
                        {
                            numerador = objeto - focal;
                            denominador = objeto * focal;
                            imagem = denominador / numerador;
                            txtImagem.Text = imagem.ToString(); //Exibir o valor no campo que está vazio, referente a incognita
                            txtImagem.ForeColor = Color.Red; //Deixar a cor de exibição em vermelho
                        }
                        break;
                    case "objeto":
                        {
                            numerador = imagem - focal;
                            denominador = imagem * focal;
                            objeto = denominador / numerador;
                            txtObjeto.Text = objeto.ToString();
                            txtObjeto.ForeColor = Color.Red;
                        }
                        break;
                    case "focal":
                        {
                            numerador = imagem + objeto;
                            denominador = imagem * objeto;
                            objeto = denominador / numerador;
                            txtFocal.Text = objeto.ToString();
                            txtFocal.ForeColor = Color.Red;
                        }
                        break;
                }
            }

        }

        private void Erase()
        {
            txtFocal.Text = "";
            txtImagem.Text = "";
            txtObjeto.Text = "";

            txtFocal.ForeColor = Color.Black;
            txtImagem.ForeColor = Color.Black;
            txtObjeto.ForeColor = Color.Black;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calc();
        }

        //Condição para apenas inserir números e um ponto (.) nos campos.
        private void txtFocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtImagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            if ((Application.OpenForms["About"] as About) == null)
            {
                About about = new About();
                about.Show();
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            Erase();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
