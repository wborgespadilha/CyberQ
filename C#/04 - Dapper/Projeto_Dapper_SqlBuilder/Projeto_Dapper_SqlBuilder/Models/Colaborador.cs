namespace Projeto_Dapper_SqlBuilder.Models
{
    public class Colaborador
    {

        private int codigo_colaborador;
        private string nome_colaborador;
        private int codigo_cargo;

        public int Codigo_colaborador { get => codigo_colaborador; set => codigo_colaborador = value; }
        public string Nome_colaborador { get => nome_colaborador; set => nome_colaborador = value; }
        public int Codigo_cargo { get => codigo_cargo; set => codigo_cargo = value; }
    }
}
