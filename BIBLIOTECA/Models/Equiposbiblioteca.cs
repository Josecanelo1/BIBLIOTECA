using BIBLIOTECA.Models.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WebApiPractica.Models
{
    public class Equiposbiblioteca : DbContext
    {
        public Equiposbiblioteca(DbContextOptions<Equiposbiblioteca> options) : base(options)
        {
        }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libro> Libro { get; set; }
    }
}