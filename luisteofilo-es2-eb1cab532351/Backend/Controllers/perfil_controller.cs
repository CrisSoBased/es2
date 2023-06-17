
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Context;
using BusinessLogic.Entities;
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class perfil_controller : ControllerBase
    {
        private readonly MyDbContext _context;

        public perfil_controller(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> Getperfil()
        {
            if (_context.perfils == null)
            {
                return NotFound();
            }

            return await _context
                .perfils.Select(a => new
                {
                    a.id_perfil,
                    a.nome,
                    a.pais,
                    a.mail,
                    a.preco_hora,
                    a.visibilidade,
                    a.id_user
                    
                    
                    
                    
                    
                    
                }).ToListAsync();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<perfil>> Getperfil(int id)
        {
            if (_context.perfils == null)
            {
                return NotFound();
            }

            var perfil = await _context.perfils.FindAsync(id);

            if (perfil == null)
            {
                return NotFound();
            }

            return perfil;
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putperfil(int id, perfil perfil)
        {
            if (id != perfil.id_perfil)
            {
                return BadRequest();
            }

            _context.Entry(perfil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!perfilExists(id))
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

        // POST: api/Authors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<perfil>> PostUtilizador(perfil perfil)
        {
            if (_context.perfils == null)
            {
                return Problem("Entity set 'MyDbContext.Authors'  is null.");
            }

            _context.perfils.Add(perfil);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getperfil", new { id = perfil.id_perfil }, perfil);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteperfil(int id)
        {
            if (_context.perfils == null)
            {
                return NotFound();
            }

            var perfil = await _context.perfils.FindAsync(id);
            if (perfil == null)
            {
                return NotFound();
            }

            _context.perfils.Remove(perfil);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool perfilExists(int id)
        {
            return (_context.perfils?.Any(e => e.id_perfil == id)).GetValueOrDefault();
        }
    }
}
