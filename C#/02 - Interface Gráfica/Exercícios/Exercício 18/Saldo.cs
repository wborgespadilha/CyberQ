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
    public partial class Saldo : Form
    {
        Cliente cliente = new Cliente();

        public Saldo(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Saldo_Load(object sender, EventArgs e)
        {
            txbSaldoCC.Text = $"{cliente.SaldoCC:C2}";
            txbSaldoCP.Text = $"{cliente.SaldoCP:C2}";
        }
    }
}
