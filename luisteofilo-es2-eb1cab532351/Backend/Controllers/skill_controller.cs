using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Context;
using BusinessLogic.Entities;
namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class skill_controller : ControllerBase
    {
        private readonly MyDbContext _context;

        public skill_controller(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Authors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<dynamic>>> Getskill()
        {
            if (_context.skills == null)
            {
                return NotFound();
            }

            return await _context
                .skills.Select(a => new
                {
                    a.id_skill,
                    a.nome,
                    a.area_profissional
                    
                    
                    
                    
                    
                    
                }).ToListAsync();
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<skill>> Getskill(int id)
        {
            if (_context.skills == null)
            {
                return NotFound();
            }

            var skill = await _context.skills.FindAsync(id);

            if (skill == null)
            {
                return NotFound();
            }

            return skill;
        }

        // PUT: api/Authors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putskill(int id, skill skill)
        {
            if (id != skill.id_skill)
            {
                return BadRequest();
            }

            _context.Entry(skill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!skillExists(id))
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
        public async Task<ActionResult<skill>> PostUtilizador(skill skill)
        {
            if (_context.skills == null)
            {
                return Problem("Entity set 'MyDbContext.skills'  is null.");
            }

            _context.skills.Add(skill);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getskill", new { id = skill.id_skill }, skill);
        }

        // DELETE: api/Authors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteskill(int id)
        {
            if (_context.skills == null)
            {
                return NotFound();
            }

            var skill = await _context.skills.FindAsync(id);
            if (skill == null)
            {
                return NotFound();
            }

            _context.skills.Remove(skill);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool skillExists(int id)
        {
            return (_context.detalhes?.Any(e => e.id_skill == id)).GetValueOrDefault();
        }
    }
}






























public class skill_controller
{
    
}