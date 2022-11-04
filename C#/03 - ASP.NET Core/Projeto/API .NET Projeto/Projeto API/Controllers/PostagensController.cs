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
    public class PostagensController : ControllerBase
    {
        private readonly Contexto _context;

        public PostagensController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Postagens/titulo/termo
        [HttpGet("titulo/{termo}")]
        public async Task<ActionResult<IEnumerable<Postagens>>> GetPostPeloTitulo(string termo)
        {
            return await _context.Postagens.Where(p => p.tituloPostagem.ToLower().Contains(termo.ToLower())).ToListAsync();
        }

        // GET: api/Postagens/categoria/id
        [HttpGet("categoria/{id}")]
        public async Task<ActionResult<IEnumerable<Postagens>>> GetPostPelaCategoria(int id)
        {
            return await _context.Postagens.Where(p => p.CategoriaId.Equals(id)).ToListAsync();
        }

        // GET: api/Postagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Postagens>>> GetPostagens()
        {
          if (_context.Postagens == null)
          {
              return NotFound();
          }
            return await _context.Postagens.ToListAsync();
        }

        // GET: api/Postagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Postagens>> GetPostagens(int id)
        {
          if (_context.Postagens == null)
          {
              return NotFound();
          }
            var postagens = await _context.Postagens.FindAsync(id);

            if (postagens == null)
            {
                return NotFound();
            }

            return postagens;
        }

        // PUT: api/Postagens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostagens(int id, Postagens postagens)
        {
            if (id != postagens.Id)
            {
                return BadRequest();
            }

            _context.Entry(postagens).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostagensExists(id))
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

        // POST: api/Postagens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Postagens>> PostPostagens(Postagens postagens)
        {
          if (_context.Postagens == null)
          {
              return Problem("Entity set 'Contexto.Postagens'  is null.");
          }
            _context.Postagens.Add(postagens);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostagens", new { id = postagens.Id }, postagens);
        }

        // DELETE: api/Postagens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostagens(int id)
        {
            if (_context.Postagens == null)
            {
                return NotFound();
            }
            var postagens = await _context.Postagens.FindAsync(id);
            if (postagens == null)
            {
                return NotFound();
            }

            _context.Postagens.Remove(postagens);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PostagensExists(int id)
        {
            return (_context.Postagens?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
