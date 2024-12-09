using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Week_12_Survivor.API.Data;
using Week_12_Survivor.API.Models;

namespace Week_12_Survivor.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        private readonly Context _context;

        public CompetitorsController(Context context)
        {
            _context = context;
        }

        // GET: api/Competitors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competitor>>> GetCompetitors()
        {
            var competitors = await _context.Competitors
                .Where(x=>x.IsDeleted == false)
                .Include(x => x.Category)
                    .Select(c => new { c.Id, c.FirstName, c.LastName, CategoryName = c.Category.Name })
                    .OrderBy(x => x.FirstName)
                    .ToListAsync();
            return Ok(competitors);
        }

        // GET: api/Competitors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Competitor>> GetCompetitor(Guid id)
        {
            var competitor = await _context.Competitors.FindAsync(id);

            if (competitor is null)
            {
                return NotFound();
            }

            return competitor;
        }

        // PUT: api/Competitors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompetitor(Guid id, Competitor competitor)
        {
            if (id != competitor.Id)
            {
                return BadRequest();
            }

            _context.Entry(competitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetitorExists(id))
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

        // POST: api/Competitors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Competitor>> PostCompetitor(Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompetitor", new { id = competitor.Id }, competitor);
        }

        // DELETE: api/Competitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitor(Guid id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null)
            {
                return NotFound();
            }

            _context.Competitors.Remove(competitor);
            competitor.IsDeleted = true;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompetitorExists(Guid id)
        {
            return _context.Competitors.Any(e => e.Id == id);
        }
    }
}
