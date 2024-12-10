using System;
using System.Linq;
using System.Windows.Forms;
using Cliente.Data;
using System.Threading.Tasks;

namespace Cliente
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            MostrarTareasEnConsola();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void MostrarTareasEnConsola()
        {
            try
            {
                using (var db = new TaskDbContext())
                {
                    var tareas = db.Tareas.ToList();

                    Console.WriteLine("Lista de Tareas:");
                    foreach (var tarea in tareas)
                    {
                        Console.WriteLine($"ID: {tarea.Id}, Título: {tarea.Title}, Descripción: {tarea.Description}, Completada: {tarea.IsCompleted}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al consultar las tareas: {ex.Message}");
            }
        }
    }
}
