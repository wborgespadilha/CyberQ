using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_17
{
    public partial class Listar : Form
    {
        List<Pessoa> lista;

        public Listar(List<Pessoa> lista)
        {
            this.lista = lista;
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            double homens = 0;
            double mulheres = 0;

            string[,] estados = new string[27, 2];

            for (int i = 0; i < 27; i++)
            {
                estados[i, 0] = "";
                estados[i, 1] = "0";
            }

            Pessoa maiorIdade = new Pessoa();
            maiorIdade.Idade = 0;

            Pessoa menorIdade = new Pessoa();
            menorIdade.Idade = 99999;

            foreach(Pessoa pessoa in lista)
            {
                if(pessoa.Genero == "M")
                {
                    homens++;
                }
                if(pessoa.Genero == "F")
                {
                    mulheres++;
                }

                if(pessoa.Idade > maiorIdade.Idade)
                {
                    maiorIdade = pessoa;
                }
                if (pessoa.Idade < menorIdade.Idade)
                {
                    menorIdade = pessoa;
                }

                bool estadoEncontrado = false;

                for(int i = 0; i < 27; i++)
                {
                    if (estados[i,0] == pessoa.Estado)
                    {
                        estados[i, 1] = Convert.ToString(Convert.ToInt32(estados[i, 1]) + 1);
                        estadoEncontrado = true;
                        break;
                    }
                }

                if(estadoEncontrado == false)
                {
                    for(int i = 0; i < 27; i++)
                    {
                        if(estados[i,0] == "")
                        {
                            estados[i, 0] = pessoa.Estado;
                            estados[i, 1] = Convert.ToString(Convert.ToInt32(estados[i, 1]) + 1);
                            break;
                        }
                    }
                }

            }

            double porcentagemHomens = homens / (homens + mulheres);
            double porcentagemMulheres = mulheres / (homens + mulheres);

            lblNumHomens.Text = homens.ToString();
            lblNumMulheres.Text = mulheres.ToString();
            lblNumUsuarios.Text = (homens + mulheres).ToString();

            lblPorcentagemHomens.Text += $"{porcentagemHomens:P2}";
            lblPorcentagemMulheres.Text += $"{porcentagemMulheres:P2}";

            txbVelha.Text = $"{maiorIdade.Nome} - {maiorIdade.Idade} anos, gênero: {maiorIdade.Genero}, estado: {maiorIdade.Estado}";
            txbNova.Text = $"{menorIdade.Nome} - {menorIdade.Idade} anos, gênero: {menorIdade.Genero}, estado: {menorIdade.Estado}";

            for (int i = 0; i < 27; i++)
            {
                if (estados[i, 0] != "")
                {
                    lbxEstados.Items.Add($"{estados[i, 0]} - {estados[i, 1]}");
                }
            }

        }
    }
}
