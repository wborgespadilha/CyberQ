using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_API.Models;
using projeto_AP.Config;

namespace Projeto_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComentariosController : ControllerBase
    {
        private readonly Contexto _context;

        public ComentariosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Comentarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comentarios>>> GetComentarios()
        {
          if (_context.Comentarios == null)
          {
              return NotFound();
          }
            return await _context.Comentarios.ToListAsync();
        }

        // GET: api/Comentarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comentarios>> GetComentarios(int id)
        {
          if (_context.Comentarios == null)
          {
              return NotFound();
          }
            var comentarios = await _context.Comentarios.FindAsync(id);

            if (comentarios == null)
            {
                return NotFound();
            }

            return comentarios;
        }

        ////GET: api/Comentarios/postagem/5
        [HttpGet("postagem/{id}")]
        public async Task<ActionResult<IEnumerable<Comentarios>>> GetComentarioPeloPost(int id)
        {
            return await _context.Comentarios.Where(c => c.PostagemId == id).ToListAsync();
        }

        // PUT: api/Comentarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComentarios(int id, Comentarios comentarios)
        {
            if (id != comentarios.Id)
            {
                return BadRequest();
            }

            _context.Entry(comentarios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComentariosExists(id))
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

        // POST: api/Comentarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comentarios>> PostComentarios(Comentarios comentarios)
        {
          if (_context.Comentarios == null)
          {
              return Problem("Entity set 'Contexto.Comentarios'  is null.");
          }
            _context.Comentarios.Add(comentarios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComentarios", new { id = comentarios.Id }, comentarios);
        }

        // DELETE: api/Comentarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComentarios(int id)
        {
            if (_context.Comentarios == null)
            {
                return NotFound();
            }
            var comentarios = await _context.Comentarios.FindAsync(id);
            if (comentarios == null)
            {
                return NotFound();
            }

            _context.Comentarios.Remove(comentarios);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ComentariosExists(int id)
        {
            return (_context.Comentarios?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
