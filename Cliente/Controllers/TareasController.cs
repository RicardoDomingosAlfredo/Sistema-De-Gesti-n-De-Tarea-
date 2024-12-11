using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Cliente.Data; // Asegúrate de que tienes la referencia correcta a tu contexto

namespace Cliente.Controllers
{
    public class TareasController : ApiController
    {
        private readonly TaskDbContext _context;

        public TareasController()
        {
            _context = new TaskDbContext();
        }

        // GET: api/tareas
        public IEnumerable<Tarea> Get()
        {
            return _context.Tareas.ToList();
        }

        // GET: api/tareas/5
        public IHttpActionResult Get(int id)
        {
            var tarea = _context.Tareas.Find(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return Ok(tarea);
        }

        // POST: api/tareas
        public IHttpActionResult Post([FromBody] Tarea tarea)
        {
            if (tarea == null)
            {
                return BadRequest("Datos inválidos.");
            }

            _context.Tareas.Add(tarea);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tarea.Id }, tarea);
        }

        // PUT: api/tareas/5
        public IHttpActionResult Put(int id, [FromBody] Tarea tarea)
        {
            if (tarea == null || tarea.Id != id)
            {
                return BadRequest();
            }

            var existingTarea = _context.Tareas.Find(id);
            if (existingTarea == null)
            {
                return NotFound();
            }

            existingTarea.Title = tarea.Title;
            existingTarea.Description = tarea.Description;
            existingTarea.IsCompleted = tarea.IsCompleted;

            _context.SaveChanges();

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        // DELETE: api/tareas/5
        public IHttpActionResult Delete(int id)
        {
            var tarea = _context.Tareas.Find(id);
            if (tarea == null)
            {
                return NotFound();
            }

            _context.Tareas.Remove(tarea);
            _context.SaveChanges();

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
    }
}
