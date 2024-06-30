using Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entidades;

namespace API.Controllers
{
   
    public class ArticuloController : BaseApiController
    {
        private readonly ApplicationDbContext _db;

        public ArticuloController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]  //api/articulos
        public async Task<ActionResult<IEnumerable<Articulos>>> GetArticulos()
        {
            var articulos = await _db.Articuloss.ToListAsync();
            return Ok(articulos);
        }
        [HttpGet("{id}")] //api/usuario/1
        public async Task<ActionResult<Articulos>> GetArticulos(int id)
        {
            var articulos = await _db.Articuloss.FindAsync(id);
            return Ok(articulos);
        }

        [HttpPost]  // POST api/articulos
        public async Task<ActionResult<Articulos>> PostArticulo(Articulos articulo)
        {
            if (ModelState.IsValid)
            {
                _db.Articuloss.Add(articulo);
                await _db.SaveChangesAsync();
                return CreatedAtAction(nameof(GetArticulos), new { id = articulo.Id }, articulo);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPut("{id}")] // PUT api/articulos/1
        public async Task<IActionResult> PutArticulo(int id, Articulos updateArticulo)
        {
            if (id != updateArticulo.Id)
            {
                return BadRequest("ID mismatch");
            }

            var articulo = await _db.Articuloss.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            // Actualizar los campos del artículo con los valores recibidos
            articulo.Codigo = updateArticulo.Codigo;
            articulo.Nombre = updateArticulo.Nombre;
            articulo.Descripcion = updateArticulo.Descripcion;
            articulo.Precio = updateArticulo.Precio;
            articulo.Estado = updateArticulo.Estado;
            articulo.FechaAdicion = DateTime.UtcNow; // Actualizar la fecha de modificación

            _db.Entry(articulo).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticuloExiste(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpDelete("{id}")] // DELETE api/articulos/1
        public async Task<IActionResult> DeleteArticulo(int id)
        {
            var articulo = await _db.Articuloss.FindAsync(id);

            if (articulo == null)
            {
                return NotFound();
            }

            _db.Articuloss.Remove(articulo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticuloExiste(int id)
        {
            return _db.Articuloss.Any(e => e.Id == id);
        }

    }
}
