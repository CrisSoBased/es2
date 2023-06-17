
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Context;
using BusinessLogic.Entities;
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class detalhe_controller : ControllerBase
    {
        private readonly MyDbContext _context;

        public detalhe_controller(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> Getdetalhe()
        {
            if (_context.detalhes == null)
            {
                return NotFound();
            }

            return await _context
                .detalhes.Select(a => new
                {
                    a.id_detalhe,
                    a.titulo,
                    a.empresa,
                    a.ano_inicio,
                    a.ano_fim,
                    a.id_skill,
                    a.id_perfil
                    
                    
                    
                    
                    
                    
                }).ToListAsync();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<detalhe>> Getdetalhe(int id)
        {
            if (_context.detalhes == null)
            {
                return NotFound();
            }

            var detalhe = await _context.detalhes.FindAsync(id);

            if (detalhe == null)
            {
                return NotFound();
            }

            return detalhe;
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putdetalhe(int id, detalhe detalhe)
        {
            if (id != detalhe.id_detalhe)
            {
                return BadRequest();
            }

            _context.Entry(detalhe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!detalheExists(id))
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
        public async Task<ActionResult<detalhe>> PostUtilizador(detalhe detalhe)
        {
            if (_context.detalhes == null)
            {
                return Problem("Entity set 'MyDbContext.detalhe'  is null.");
            }

            _context.detalhes.Add(detalhe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getdetalhe", new { id = detalhe.id_detalhe }, detalhe);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletedetalhe(int id)
        {
            if (_context.detalhes == null)
            {
                return NotFound();
            }

            var detalhe = await _context.detalhes.FindAsync(id);
            if (detalhe == null)
            {
                return NotFound();
            }

            _context.detalhes.Remove(detalhe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool detalheExists(int id)
        {
            return (_context.detalhes?.Any(e => e.id_detalhe == id)).GetValueOrDefault();
        }
    }
}

















