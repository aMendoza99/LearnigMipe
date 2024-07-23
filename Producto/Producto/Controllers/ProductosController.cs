using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TuProyecto.Models;

namespace Proyecto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyApiController : ControllerBase
    {
        // Lista temporal de productos para simular una base de datos
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Producto1", Descripcion = "Descripción del Producto1", Precio = 10.00m, CantidadEnStock = 100 },
            new Producto { Id = 2, Nombre = "Producto2", Descripcion = "Descripción del Producto2", Precio = 20.00m, CantidadEnStock = 200 }
        };

        // GET: api/MyApi
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return productos;
        }

        // GET: api/MyApi/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            var producto = productos.Find(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }
            return producto;
        }

        // POST: api/MyApi
        [HttpPost]
        public ActionResult<Producto> Post([FromBody] Producto producto)
        {
            producto.Id = productos.Count + 1;
            productos.Add(producto);
            return CreatedAtAction(nameof(Get), new { id = producto.Id }, producto);
        }

        // PUT: api/MyApi/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
            var existingProducto = productos.Find(p => p.Id == id);
            if (existingProducto == null)
            {
                return NotFound();
            }

            existingProducto.Nombre = producto.Nombre;
            existingProducto.Descripcion = producto.Descripcion;
            existingProducto.Precio = producto.Precio;
            existingProducto.CantidadEnStock = producto.CantidadEnStock;

            return NoContent();
        }

        // DELETE: api/MyApi/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = productos.Find(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            productos.Remove(producto);
            return NoContent();
        }
    }
}
