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

    public partial class SaqueCC : Form
    {

        Cliente cliente = new Cliente();
        double valor = 0;

        public SaqueCC(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void SaqueCC_Load(object sender, EventArgs e)
        {
            txbSaldo.Text = $"{cliente.SaldoCC:C2}";
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToDouble(txbValor.Text) > cliente.SaldoCC)
                {
                    MessageBox.Show("Você não tem saldo suficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                    return;
                }
               
                valor = Convert.ToDouble(txbValor.Text);
                Caixa.descontarSaldoCC(valor);

                Extrato extrato = new Extrato("Saque", valor, "CC");
                Caixa.adicionarExtrato(extrato);

                MessageBox.Show("Saque realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

    }
}
