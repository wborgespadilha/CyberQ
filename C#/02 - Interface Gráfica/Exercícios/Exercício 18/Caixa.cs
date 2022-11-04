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
    public partial class Caixa : Form
    {

        public static Cliente cliente = new Cliente();
        public static List<Extrato> listaExtratos = new List<Extrato>();

        public static void descontarSaldoCC(double valor)
        {
            cliente.SaldoCC -= valor;
        }

        public static void somarSaldoCC(double valor)
        {
            cliente.SaldoCC += valor;
        }

        public static void descontarSaldoCP(double valor)
        {
            cliente.SaldoCP -= valor;
        }

        public static void somarSaldoCP(double valor)
        {
            cliente.SaldoCP += valor;
        }

        public static void adicionarExtrato(Extrato extrato)
        {
            listaExtratos.Add(extrato);
        }

        public Caixa(Cliente clienteRecebido)
        {
            InitializeComponent();
            cliente = clienteRecebido;
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            lblWelcome.Text += cliente.Nome;
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Saldo saldo = new Saldo(cliente);
            saldo.Show();
        }

        private void btnSaqueCC_Click(object sender, EventArgs e)
        {
            SaqueCC saque = new SaqueCC(cliente);
            saque.Show();
        }

        private void btnSaqueCP_Click(object sender, EventArgs e)
        {
            SaqueCP saque = new SaqueCP(cliente);
            saque.Show();
        }

        private void btnDepositoCC_Click(object sender, EventArgs e)
        {
            DepositoCC deposito = new DepositoCC(cliente);
            deposito.Show();
        }

        private void btnDepositoCP_Click(object sender, EventArgs e)
        {
            DepositoCP deposito = new DepositoCP(cliente);
            deposito.Show();
        }

        private void btnEmpréstimo_Click(object sender, EventArgs e)
        {
            Emprestimo emprestimo = new Emprestimo(cliente);
            emprestimo.Show();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Extratos extratos = new Extratos(listaExtratos);
            extratos.Show();
        }
    }
}
