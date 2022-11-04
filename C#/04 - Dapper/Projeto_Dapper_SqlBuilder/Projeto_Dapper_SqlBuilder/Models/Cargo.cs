namespace Projeto_Dapper_SqlBuilder.Models
{
    public class Cargo
    {

        private int codigo_cargo;
        private string nome_cargo;

        public int Codigo_cargo { get => codigo_cargo; set => codigo_cargo = value; }
        public string Nome_cargo { get => nome_cargo; set => nome_cargo = value; }
    }
}
