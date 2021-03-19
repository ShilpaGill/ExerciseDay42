using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiExercise1.Models;

namespace WebApiExercise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentTablesController : ControllerBase
    {
        private readonly StudentdbContext _context;

        public StudentTablesController(StudentdbContext context)
        {
            _context = context;
        }

        // GET: api/StudentTables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentTable>>> GetStudentTables()
        {
            return await _context.StudentTables.ToListAsync();
        }

        // GET: api/StudentTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentTable>> GetStudentTable(int id)
        {
            var studentTable = await _context.StudentTables.FindAsync(id);

            if (studentTable == null)
            {
                return NotFound();
            }

            return studentTable;
        }

        // PUT: api/StudentTables/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentTable(int id, StudentTable studentTable)
        {
            if (id != studentTable.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentTableExists(id))
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

        // POST: api/StudentTables
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StudentTable>> PostStudentTable(StudentTable studentTable)
        {
            _context.StudentTables.Add(studentTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StudentTableExists(studentTable.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStudentTable", new { id = studentTable.Id }, studentTable);
        }

        // DELETE: api/StudentTables/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentTable>> DeleteStudentTable(int id)
        {
            var studentTable = await _context.StudentTables.FindAsync(id);
            if (studentTable == null)
            {
                return NotFound();
            }

            _context.StudentTables.Remove(studentTable);
            await _context.SaveChangesAsync();

            return studentTable;
        }

        private bool StudentTableExists(int id)
        {
            return _context.StudentTables.Any(e => e.Id == id);
        }
    }
}
