#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketsAPI.Data;
using TicketsAPI.Models;

namespace TicketsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketModelsController : ControllerBase
    {
        private readonly TicketsAPIContext _context;

        public TicketModelsController(TicketsAPIContext context)
        {
            _context = context;
        }

        // GET: api/TicketModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketModel>>> GetTicketModel()
        {
            return await _context.TicketModel.ToListAsync();
        }

        // GET: api/TicketModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketModel>> GetTicketModel(int id)
        {
            var ticketModel = await _context.TicketModel.FindAsync(id);

            if (ticketModel == null)
            {
                return NotFound();
            }

            return ticketModel;
        }

        // PUT: api/TicketModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicketModel(int id, TicketModel ticketModel)
        {
            if (id != ticketModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(ticketModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketModelExists(id))
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

        // POST: api/TicketModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TicketModel>> PostTicketModel(TicketModel ticketModel)
        {
            _context.TicketModel.Add(ticketModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicketModel", new { id = ticketModel.Id }, ticketModel);
        }

        // DELETE: api/TicketModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicketModel(int id)
        {
            var ticketModel = await _context.TicketModel.FindAsync(id);
            if (ticketModel == null)
            {
                return NotFound();
            }

            _context.TicketModel.Remove(ticketModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketModelExists(int id)
        {
            return _context.TicketModel.Any(e => e.Id == id);
        }
    }
}
