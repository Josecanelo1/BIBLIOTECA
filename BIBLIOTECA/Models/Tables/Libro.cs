using System;
using System.ComponentModel.DataAnnotations;

namespace BIBLIOTECA.Models.Tables;

public class Libro
{
    [Key]
    public int id { get; set; }
    public string titulo { get; set; }
    public string AnioPublicación  { get; set; }
    public string autorId { get; set; }
    public string categoriaId { get; set; }
    public string Resumen { get; set; }


}
