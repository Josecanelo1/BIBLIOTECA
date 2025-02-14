using BIBLIOTECA.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApiPractica.Models
{
    public class EquiposBiblioteca : DbContext
    {
        public EquiposBiblioteca(DbContextOptions<EquiposBiblioteca> options) : base(options)
        {
        }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libro> Libro { get; set; }
    }
}