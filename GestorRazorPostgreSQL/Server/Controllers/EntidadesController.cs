
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestorPostgreSQL.Server.Data;
using GestorPostgreSQL.Shared.Modelos;

namespace GestorRazorPostgreSQL.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadesController : ControllerBase
    {
        private readonly GestorDbContext _context;

        public EntidadesController(GestorDbContext context)
        {
            _context = context;
        }

        // GET: api/Entidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entidad>>> GetEntidades()
        {
            return await _context.Entidades.ToListAsync();

        }


        // GET: api/Entidades/5
        [HttpGet("{codigo}")]
        public async Task<ActionResult<Entidad>> GetEntidad(string codigo)
        {
            //var emp = await _context.Entidades.FindAsync(codigo);
            var ent = await _context.Entidades.Include(p => p.empleados).FirstOrDefaultAsync(p => p.codigo == codigo);

            if (ent == null)
            {
                return NotFound();
            }

            //cargar manualmente las entidades
            //ent.empleados = await _context.Emple

            return ent;
        }


        // PUT: api/Entidades/5
        [HttpPut("{codigo}")]
        public async Task<IActionResult> PutEntidad(string codigo, Entidad ent)
        {
            if (codigo != ent.codigo)
            {
                return BadRequest();
            }

            _context.Entry(ent).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntidadExists(codigo))
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


        // POST: api/Entidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entidad>> PostEntidad(Entidad ent)
        {

            _context.Entidades.Add(ent);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetEntidad", new { codigo = ent.codigo }, ent);
        }

        // POST: api/Entidad/Empleado/5/4
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Empleado/{codigoentidad}/{codigoempleado}")]
        public async Task<IActionResult> PostEmpleado(string codigoentidad, string codigoempleado)
        {

            var ent = await _context.Entidades.Include(p => p.empleados).FirstOrDefaultAsync(p => p.codigo == codigoentidad);
            if (ent == null)
            {
                return NotFound();
            }

            var emp = await _context.Empleados.FirstOrDefaultAsync(p => p.codigo == codigoempleado);
            if (emp == null)
            {
                return NotFound();
            }

            ent.empleados.Add(emp);

            await _context.SaveChangesAsync();

            return NoContent();

        }


        // DELETE: api/Empleados/5
        [HttpDelete("{codigo}")]
        public async Task<IActionResult> DeleteEntidad (string codigo)
        {
            var ent = await _context.Entidades.FindAsync(codigo);
            if (ent == null)
            {
                return NotFound();
            }
            _context.Entidades.Remove(ent);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Entidad/Empleado/5/4
        [HttpDelete("Empleado/{codigoentidad}/{codigoempleado}")]
        public async Task<IActionResult> DeleteEmpleado(string codigoentidad, string codigoempleado)
        {

            var ent = await _context.Entidades.Include(p => p.empleados).FirstOrDefaultAsync(p => p.codigo == codigoentidad);
            if (ent == null)
            {
                return NotFound();
            }

            var emp = ent.empleados.FirstOrDefault(p => p.codigo == codigoempleado);
            if (emp == null)
            {
                return NotFound();
            }

            ent.empleados.Remove(emp);

            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool EntidadExists(string codigo)
        {
            return _context.Entidades.Any(e => e.codigo == codigo);
        }


    }
}
