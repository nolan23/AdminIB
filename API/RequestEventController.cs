using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminIB.Models;

namespace AdminIB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestEventController : ControllerBase
    {
        private readonly RequestContext _context;

        public RequestEventController(RequestContext context)
        {
            _context = context;

        }

        // Get api/request
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvent()
        {
            return await _context.Event.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var request = await _context.Event.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }
            return request;
        }

        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event request)
        {
            _context.Event.Add(request);
            await _context.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetEvent), new { id = request.Id }, request);
        }

    }
}