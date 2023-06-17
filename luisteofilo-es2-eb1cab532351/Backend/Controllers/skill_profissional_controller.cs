using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Context;
using BusinessLogic.Entities;
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class skill_profissional_controller : ControllerBase
    {
        private readonly MyDbContext _context;

        public skill_profissional_controller(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> Getskill_profissional()
        {
            if (_context.skill_profissionals == null)
            {
                return NotFound();
            }

            return await _context
                .skill_profissionals.Select(a => new
                {
                    a.id_perfil,
                    a.id_skill
                   
                    
                    
                    
                    
                    
                    
                }).ToListAsync();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<skill_profissional>> Getskill_profissional(int id)
        {
            if (_context.skill_profissionals == null)
            {
                return NotFound();
            }

            var skill_profissional = await _context.skill_profissionals.FindAsync(id);

            if (skill_profissional == null)
            {
                return NotFound();
            }

            return skill_profissional;
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putskill_profissional(int id, skill_profissional skill_profissional)
        {
            if (id != skill_profissional.id_skill)
            {
                return BadRequest();
            }

            _context.Entry(skill_profissional).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!skill_profissionalExists(id))
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
        public async Task<ActionResult<skill_profissional>> Postskill_profissional(skill_profissional skill_profissional)
        {
            if (_context.skill_profissionals == null)
            {
                return Problem("Entity set 'MyDbContext.skill_profissional'  is null.");
            }

            _context.skill_profissionals.Add(skill_profissional);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getskill_profissional", new { id = skill_profissional.id_skill }, skill_profissional);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteskill_profissional(int id)
        {
            if (_context.skill_profissionals == null)
            {
                return NotFound();
            }

            var skill_profissional = await _context.skill_profissionals.FindAsync(id);
            if (skill_profissional == null)
            {
                return NotFound();
            }

            _context.skill_profissionals.Remove(skill_profissional);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool skill_profissionalExists(int id)
        {
            return (_context.skill_profissionals?.Any(e => e.id_skill == id)).GetValueOrDefault();
        }
    }
}











