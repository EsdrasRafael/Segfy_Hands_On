using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguroAutoController : ControllerBase
    {
        private readonly Context _context;

        public SeguroAutoController(Context context)
        {
            _context = context;
        }

        // GET: api/SeguroAuto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SeguroAuto>>> GetSegurosAuto()
        {
            return await _context.SegurosAuto.ToListAsync();
        }

        // GET: api/SeguroAuto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SeguroAuto>> GetSeguroAuto(int id)
        {
            var seguroAuto = await _context.SegurosAuto.FindAsync(id);

            if (seguroAuto == null)
            {
                return NotFound();
            }

            return seguroAuto;
        }

        // PUT: api/SeguroAuto/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSeguroAuto(int id, SeguroAuto seguroAuto)
        {
            if (id != seguroAuto.PMId)
            {
                return BadRequest();
            }

            _context.Entry(seguroAuto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeguroAutoExists(id))
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

        // POST:  
        [HttpPost]
        public async Task<ActionResult<SeguroAuto>> PostSeguroAuto(SeguroAuto seguroAuto)
        {
            _context.SegurosAuto.Add(seguroAuto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSeguroAuto", new { id = seguroAuto.PMId }, seguroAuto);
        }

        // DELETE: api/SeguroAuto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SeguroAuto>> DeleteSeguroAuto(int id)
        {
            var seguroAuto = await _context.SegurosAuto.FindAsync(id);
            if (seguroAuto == null)
            {
                return NotFound();
            }

            _context.SegurosAuto.Remove(seguroAuto);
            await _context.SaveChangesAsync();

            return seguroAuto;
        }

        private bool SeguroAutoExists(int id)
        {
            return _context.SegurosAuto.Any(e => e.PMId == id);
        }
    }
}
