namespace Projeto_API.Models
{
    public class Usuarios
    {

        public int Id { get; set; }
        public string nomeUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public int CargoId {  get; set; }
        public int primeiraCategoriaUsuario { get; set; }
        public int segundaCategoriaUsuario { get; set; }
        public int terceiraCategoriaUsuario { get; set; }

    }
}
