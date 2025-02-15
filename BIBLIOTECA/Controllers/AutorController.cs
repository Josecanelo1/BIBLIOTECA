using BIBLIOTECA.Models.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPractica.Models;

namespace BIBLIOTECA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly EquiposBiblioteca _equipoContexto;

        public AutorController(EquiposBiblioteca equipoContexto)
        {
            _equipoContexto = equipoContexto;
        }
        /// <summary>
        /// Endpoint que retorna el lista de autores existentes
        /// </summary>
        /// <returns>Lista de autores</returns>
        [HttpGet]
        [Route("GetAllAutores")]
        public IActionResult Get()
        {
            var autores = (from a in _equipoContexto.Autor
                        select a).ToList();
            return Ok(autores);
        }

        /// <summary>
        /// Endpoint que retorna un autor por su id
        /// </summary>
        
        [HttpGet]
        [Route("GetAutorById")]
        public IActionResult GetAutorById(int id)
        {
            var autor = (from a in _equipoContexto.Autor
                        where a.id == id
                        select a).FirstOrDefault();
            return Ok(autor);
        }

        /// <summary>
        /// Endpoint que crea un autor
        /// </summary>
        /// 
        [HttpPost]
        [Route("CreateAutor")]
        public IActionResult CreateAutor([FromBody] Autor autor)
        {
            _equipoContexto.Autor.Add(autor);
            _equipoContexto.SaveChanges();
            return Ok("Autor creado");
        }

        /// <summary>
        /// Endpoint que actualiza un autor
        /// </summary>
        /// 
        [HttpPut]
        [Route("UpdateAutor")]
        public IActionResult UpdateAutor([FromBody] Autor autor)
        {
            _equipoContexto.Autor.Update(autor);
            _equipoContexto.SaveChanges();
            return Ok("Autor actualizado");
        }

        /// <summary>
        /// Endpoint que elimina un autor
        /// </summary>
        /// 
        [HttpDelete]
        [Route("DeleteAutor")]
        
        public IActionResult DeleteAutor(int id)
        {
            var autor = (from a in _equipoContexto.Autor
                        where a.id == id
                        select a).FirstOrDefault();
            _equipoContexto.Autor.Remove(autor);
            _equipoContexto.SaveChanges();
            return Ok("Autor eliminado");
        }
    }
}
