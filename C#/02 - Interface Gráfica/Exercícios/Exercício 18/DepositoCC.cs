using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_18
{

    public partial class DepositoCC : Form
    {

        Cliente cliente = new Cliente();
        double valor = 0;

        public DepositoCC(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
               
                valor = Convert.ToDouble(txbValor.Text);
                Caixa.somarSaldoCC(valor);

                Extrato extrato = new Extrato("Deposito", valor, "CC");
                Caixa.adicionarExtrato(extrato);

                MessageBox.Show("Depósito realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();

            }
            catch(Exception)
            {
                MessageBox.Show("Insira apenas números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double valorSaque()
        {
            return valor;
        }

        private void DepositoCC_Load(object sender, EventArgs e)
        {
            txbSaldo.Text = $"{cliente.SaldoCC:C2}";
        }
    }
}
