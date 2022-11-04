namespace Projeto_API.Models
{
    public class Postagens
    {

        public int Id { get; set; }
        public string tituloPostagem { get; set; }
        public string textoPostagem { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }

    }
}
