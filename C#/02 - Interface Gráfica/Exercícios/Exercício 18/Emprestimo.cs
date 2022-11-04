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

    public partial class Emprestimo : Form
    {

        Cliente cliente = new Cliente();
        double valor = 0;

        public Emprestimo(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(txbValor.Text);

                if (valor > cliente.SaldoCC*10)
                {
                    MessageBox.Show("Você não pode pegar um empréstimo tão alto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbValor.Text = "";
                    return;
                }

                Caixa.somarSaldoCC(valor);

                MessageBox.Show("Empréstimo realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Emprestimo_Load(object sender, EventArgs e)
        {
            txbSaldo.Text = $"{(cliente.SaldoCC*10):C2}";
        }
    }
}
