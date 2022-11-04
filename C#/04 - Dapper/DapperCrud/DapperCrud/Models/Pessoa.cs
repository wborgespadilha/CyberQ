namespace DapperCrud.Models
{
    public class Pessoa
    {
        private int codigo;
        private string nome;
        private int idade;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
