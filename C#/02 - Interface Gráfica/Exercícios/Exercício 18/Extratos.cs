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
    public partial class Extratos : Form
    {

        List<Extrato> extratoList;

        public Extratos(List<Extrato> lista)
        {
            InitializeComponent();
            extratoList = lista;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Extratos_Load(object sender, EventArgs e)
        {
            foreach(Extrato extrato in extratoList)
            {
                if(extrato.Conta == "CC")
                {
                    lbxExtratosCC.Items.Add($"{extrato.Tipo} - {extrato.Valor:C2}");
                }
                else
                {
                    lbxExtratosCP.Items.Add($"{extrato.Tipo} - {extrato.Valor:C2}");
                }
            }
        }
    }
}
