using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Cliente.Data;

namespace Cliente.Data
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Tarea> Tareas { get; set; }

        public TaskDbContext() : base("name=TaskDbContext")
        {
        }
    }
}
