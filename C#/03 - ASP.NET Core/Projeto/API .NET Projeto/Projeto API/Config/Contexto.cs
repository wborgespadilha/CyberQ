using Projeto_API.Models;
using Microsoft.EntityFrameworkCore;

namespace projeto_AP.Config
{
    public class Contexto : DbContext
    {

        // Construtor
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        // Especificar quais modelos serão utilizados para gerar as tabelas
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Postagens> Postagens { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }

    }
}