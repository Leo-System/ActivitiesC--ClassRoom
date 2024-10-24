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

namespace restauranteQuinta
{
    public partial class Form1 : Form
    {
        //Criando uma variável global para chamar um método, pois muitos métodos vão acessá-la.
        double totalDaConta = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chbRefeicao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double qtdChopp = 0, qtdPetiscos = 0, qtdRefeicao = 0, totalChopp = 0, totalPetiscos = 0, totalRefeicao = 0, totalParcial = 0, taxaServico = 0;
            
            //Armazenado a quantidade de chopps
            if(txtChop.Text != "")
            {
                qtdChopp = double.Parse(txtChop.Text);
            }
            else
            {
                qtdChopp = 0;
            }

            //Armazenado a quantidade de Petiscos
            if (txtPetiscos.Text != "")
            {
                qtdPetiscos = double.Parse(txtPetiscos.Text);
            }
            else
            {
                qtdPetiscos = 0;
            }

            //Armazenado a quantidade de refeicoes
            if (txtRefeicoes.Text != "")
            {
                qtdRefeicao = double.Parse(txtRefeicoes.Text);
            }
            else
            {
                qtdRefeicao = 0;
            }

            //Conferindo se a check box de chop esta ativada;
            if(chbChop.Checked == true)
            {
                totalChopp = qtdChopp * 4.50;
            }
            else
            {
                txtChop.Text = "";
                totalChopp = 0;
            }

            //Conferindo se a check box de petiscos esta ativada;
            if (chbPetiscos.Checked == true)
            {
                totalPetiscos = qtdPetiscos * 7.90;
            }
            else
            {
                txtPetiscos.Text = "";
                totalPetiscos = 0;
            }

            //Conferindo se a check box de refeicoes esta ativada;
            if (chbRefeicao.Checked == true)
            {
                totalRefeicao = qtdRefeicao * 15.90;
            }
            else
            {
                txtRefeicoes.Text = "";
                totalRefeicao = 0;
            }

            //Exibindo o Total Parcial
            totalParcial = totalChopp + totalPetiscos + totalRefeicao;
            txtTotalParcial.Text  = totalParcial.ToString("C", CultureInfo.CurrentCulture);

            //Mostrando a Taxa de Serviço.
            taxaServico = (totalParcial * 10) / 100;
            txtTaxaServico.Text = taxaServico.ToString("C", CultureInfo.CurrentCulture);

            //Mostrando o Total a pagar.
            totalDaConta = totalParcial + taxaServico;
            txtTotalPagar.Text = totalDaConta.ToString("C", CultureInfo.CurrentCulture);
        }

        private void txtChop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRefeicoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbChop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalParcial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }SSS
}
