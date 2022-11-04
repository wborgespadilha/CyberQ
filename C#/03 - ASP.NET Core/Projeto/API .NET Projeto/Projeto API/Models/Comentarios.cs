namespace Projeto_API.Models
{
    public class Comentarios
    {

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PostagemId { get; set; }
        public string comentario { get; set; }

    }
}
