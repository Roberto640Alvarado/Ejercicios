using APiPagos.Data;
using APiPagos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APiPagos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        private readonly PagosDbContext _context;

        public PagosController(PagosDbContext context)
        {
            _context = context;
        }

        //Todos los pagos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pago>>> GetPago()
        {
            return await _context.Pagos.ToListAsync();
        }

        //Determinado pago por ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Pago>> PostPago(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);
            if (pago == null) return NotFound(new
            {
                message = "No se encontró el pago con ese ID"
            });
            return pago;
        }

        //Crear muevo pago
        [HttpPost]
        public async Task<ActionResult<Pago>> PostPago(Pago pago)
        {
            _context.Pagos.Add(pago);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPago), new { id = pago.Id }, new
            {
                message = "Pago creado exitosamente.",
                data = pago
            });
        }

        // Actualizar pago determinado
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPago(int id, Pago pago)
        {
            if (id != pago.Id) return BadRequest();

            _context.Entry(pago).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(new
            {
                message = "Pago actualizado correctamente.",
                pago
            });
        }

        // Eliminar un pago determinado
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePago(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);
            if (pago == null) return NotFound("No se encontró el pago.");

            _context.Pagos.Remove(pago);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
