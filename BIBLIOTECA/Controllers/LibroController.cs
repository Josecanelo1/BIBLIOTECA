using BIBLIOTECA.Models.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPractica.Models;

namespace BIBLIOTECA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly EquiposBiblioteca _equipoContexto;

        public LibroController(EquiposBiblioteca equipoContexto)
        {
            _equipoContexto = equipoContexto;
        }
        /// <summary>
        /// Endpoint que retorna el lista de libros existentes
        /// </summary>
        /// <returns>Lista de equipos</returns>
        [HttpGet]
        [Route("GetAllLibros")]
        public IActionResult Get()
        {
            var libros = (from l in _equipoContexto.Libro
                        select l).ToList();
            return Ok(libros);
        }

        /// <summary>
        /// Endpoint que retorna un libro por su id
        /// </summary>
        
        [HttpGet]
        [Route("GetLibroById")]
        public IActionResult GetLibroById(int id)
        {
            var libro = (from l in _equipoContexto.Libro
                        where l.id == id
                        select l).FirstOrDefault();
            return Ok(libro);
        }

        /// <summary>
        /// Endpoint que crea un libro
        /// </summary>
        [HttpPost]
        [Route("CreateLibro")]
        public IActionResult CreateLibro([FromBody] Libro libro)
        {
            _equipoContexto.Libro.Add(libro);
            _equipoContexto.SaveChanges();
            return Ok("Libro creado");
        }

        /// <summary>
        /// Endpoint que actualiza un libro
        /// </summary>
        
        [HttpPut]
        [Route("UpdateLibro")]
        public IActionResult UpdateLibro([FromBody] Libro libro)
        {
            _equipoContexto.Libro.Update(libro);
            _equipoContexto.SaveChanges();
            return Ok("Libro actualizado");
        }

        /// <summary>
        /// Endpoint que elimina un libro
        /// </summary>
        
        [HttpDelete]
        [Route("DeleteLibro")]
        public IActionResult DeleteLibro(int id)
        {
            var libro = (from l in _equipoContexto.Libro
                        where l.id == id
                        select l).FirstOrDefault();
            _equipoContexto.Libro.Remove(libro);
            _equipoContexto.SaveChanges();
            return Ok("Libro eliminado");
        }
    }
}
