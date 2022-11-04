using Primeira_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Primeira_API.Config
{
    public class Contexto: DbContext
    {

        // Construtor
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        // Especificar quais modelos serão utilizados para gerar as tabelas
        public DbSet<Treinamento> Treinamento { get; set; }

    }
}
