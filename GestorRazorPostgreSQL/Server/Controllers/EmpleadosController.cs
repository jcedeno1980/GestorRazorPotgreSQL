
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
    public class EmpleadosController : ControllerBase
    {

        private readonly GestorDbContext _context;

        public EmpleadosController(GestorDbContext context)
        {
            _context = context;
        }

        // GET: api/Empleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleados()
        {
            return await _context.Empleados.ToListAsync();

        }


        // GET: api/Empleados/5
        [HttpGet("{codigo}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(string codigo)
        {
            //var emp = await _context.Empleados.FindAsync(codigo);
            var emp = await _context.Empleados.Include(p => p.entidades).FirstOrDefaultAsync(p => p.codigo == codigo);

            if (emp == null)
            {
                return NotFound();
            }
            return emp;
        }


        // PUT: api/Empleados/5
        [HttpPut("{codigo}")]
        public async Task<IActionResult> PutEmpleado(string codigo, Empleado emp)
        {
            if (codigo != emp.codigo)
            {
                return BadRequest();
            }

            _context.Entry(emp).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoExists(codigo))
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


        // POST: api/Empleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empleado>> PostEmpleado(Empleado emp)
        {
            
            _context.Empleados.Add(emp);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetEmpleado", new { codigo = emp.codigo }, emp);
        }

        // POST: api/Empleados/Empresa/5/4
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Empresa/{codigoempleado}/{codigoentidad}")]
        public async Task<IActionResult> PostEmpresa(string codigoempleado, string codigoentidad)
        {

            var emp = await _context.Empleados.Include(p => p.entidades).FirstOrDefaultAsync(p => p.codigo == codigoempleado);

            if (emp == null)
            {
                return NotFound();
            }

            var ent = await _context.Entidades.FirstOrDefaultAsync(p => p.codigo == codigoentidad);

            if (ent == null)
            {
                return NotFound();
            }

            emp.entidades.Add(ent);

            //_context.Entry(emp).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();

        }


        // DELETE: api/Empleados/5
        [HttpDelete("{codigo}")]
        public async Task<IActionResult> DeleteEmpleado(string codigo)
        {
            var emp = await _context.Empleados.FindAsync(codigo);
            if (emp == null)
            {
                return NotFound();
            }
            _context.Empleados.Remove(emp);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Empleados/Empresa/5/4
        [HttpDelete("Empresa/{codigoempleado}/{codigoentidad}")]
        public async Task<IActionResult> DeleteEmpresa(string codigoempleado,string codigoentidad)
        {

            var emp = await _context.Empleados.Include(p => p.entidades).FirstOrDefaultAsync(p => p.codigo == codigoempleado);

            if (emp == null)
            {
                return NotFound();
            }

            var ent = emp.entidades.FirstOrDefault(p => p.codigo == codigoentidad);

            if (ent == null)
            {
                return NotFound();
            }

            emp.entidades.Remove(ent);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpleadoExists(string codigo)
        {
            return _context.Empleados.Any(e => e.codigo == codigo);
        }


    }


}
