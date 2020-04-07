using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public float ValorContaCorrente { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            txtNomeClienteAtual.Text        = txtNome.Text;
            txtEnderecoClienteAtual.Text    = txtEndereco.Text;
            txtValorContaClienteAtual.Text  = txtValorInicial.Text;

            txtNome.Text = "";
            txtEndereco.Text = "";
            txtValorInicial.Text = "";

            ValorContaCorrente = (float) Convert.ToDouble(txtValorContaClienteAtual.Text);


        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            float valorOperacao = (float)Convert.ToDouble(txtOperacoesConta.Text);


            ValorContaCorrente = ValorContaCorrente + valorOperacao;

            txtValorContaClienteAtual.Text = ValorContaCorrente.ToString();
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            float valorOperacao = (float)Convert.ToDouble(txtOperacoesConta.Text);

            if (ValorContaCorrente - valorOperacao >= 0)
            {
                ValorContaCorrente = ValorContaCorrente - valorOperacao;

                txtValorContaClienteAtual.Text = ValorContaCorrente.ToString();
            }else
                MessageBox.Show("Voce nao tem saldo para fazer esta operacao" );

        }
    }
}
