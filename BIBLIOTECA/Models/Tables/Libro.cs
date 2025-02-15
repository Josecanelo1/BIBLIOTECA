using System;
using System.ComponentModel.DataAnnotations;

namespace BIBLIOTECA.Models.Tables;

public class Libro
{
    [Key]
    public int id { get; set; }
    public string titulo { get; set; }
    public string AnioPublicacion  { get; set; }
    public int autorId { get; set; }
    public int categoriaId { get; set; }
    public string Resumen { get; set; }


}
