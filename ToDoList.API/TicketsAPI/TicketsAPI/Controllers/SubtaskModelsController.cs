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
    public class SubtaskModelsController : ControllerBase
    {
        private readonly TicketsAPIContext _context;

        public SubtaskModelsController(TicketsAPIContext context)
        {
            _context = context;
        }

        // GET: api/SubtaskModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubtaskModel>>> GetSubtaskModel()
        {
            return await _context.SubtaskModel.ToListAsync();
        }

        // GET: api/SubtaskModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubtaskModel>> GetSubtaskModel(int id)
        {
            var subtaskModel = await _context.SubtaskModel.FindAsync(id);

            if (subtaskModel == null)
            {
                return NotFound();
            }

            return subtaskModel;
        }

        // PUT: api/SubtaskModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubtaskModel(int id, SubtaskModel subtaskModel)
        {
            if (id != subtaskModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(subtaskModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubtaskModelExists(id))
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

        // POST: api/SubtaskModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubtaskModel>> PostSubtaskModel(SubtaskModel subtaskModel)
        {
            _context.SubtaskModel.Add(subtaskModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubtaskModel", new { id = subtaskModel.Id }, subtaskModel);
        }

        // DELETE: api/SubtaskModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubtaskModel(int id)
        {
            var subtaskModel = await _context.SubtaskModel.FindAsync(id);
            if (subtaskModel == null)
            {
                return NotFound();
            }

            _context.SubtaskModel.Remove(subtaskModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubtaskModelExists(int id)
        {
            return _context.SubtaskModel.Any(e => e.Id == id);
        }
    }
}
