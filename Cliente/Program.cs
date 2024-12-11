using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Threading.Tasks;
using Cliente.Data;
using System.Data.Entity;

namespace Cliente
{
    internal static class Program
    {
        [STAThread]
        static async Task Main()
        {
            await MostrarTareasEnConsolaAsync();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// Consulta la lista de tareas desde la base de datos y las muestra en la consola de forma asíncrona.
        /// </summary>
        static async Task MostrarTareasEnConsolaAsync()
        {
            try
            {
                using (var db = new TaskDbContext())
                {
                    var tareas = await db.Tareas.ToListAsync();
                    ImprimirTareasEnConsola(tareas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar las tareas: {ex.Message}");
            }
        }

        /// <summary>
        /// Imprime una lista de tareas en la consola.
        /// </summary>
        static void ImprimirTareasEnConsola(List<Tarea> tareas)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas registradas.");
                return;
            }

            Console.WriteLine("Lista de Tareas:");
            foreach (var tarea in tareas)
            {
                Console.WriteLine($"ID: {tarea.Id}, Título: {tarea.Title}, Descripción: {tarea.Description}, Completada: {tarea.IsCompleted}");
            }
        }
    }

}
