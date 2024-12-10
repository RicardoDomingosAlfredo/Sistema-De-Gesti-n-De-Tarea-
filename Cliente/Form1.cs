using System;
using System.Linq;
using System.Windows.Forms;
using Cliente.Data;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cliente
{
    public partial class Form1 : Form
    {
        private TaskDbContext context;

        public Form1()
        {
            InitializeComponent();
            context = new TaskDbContext();
        }

        private async void btnCrearTarea_Click(object sender, EventArgs e)
        {
            var tarea = new Tarea()
            {
                Title = textBox1.Text,
                Description = "Descripción predeterminada",
                IsCompleted = false
            };

            context.Tareas.Add(tarea);
            await context.SaveChangesAsync();

            MessageBox.Show("Tarea creada exitosamente");
            textBox1.Clear();
        }

        private async void btnListarTarea_Click(object sender, EventArgs e)
        {
            var tareas = await context.Tareas.ToListAsync();
            dataGridView1.DataSource = tareas;
        }

        private async void btnModificarTarea_Click(object sender, EventArgs e)
        {
            int tareaId = 1;
            var tarea = await context.Tareas.FindAsync(tareaId);

            if (tarea != null)
            {
                tarea.Title = textBox1.Text;
                await context.SaveChangesAsync();

                MessageBox.Show("Tarea modificada exitosamente");
            }
            else
            {
                MessageBox.Show("Tarea no encontrada");
            }
        }

        private async void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            int tareaId = 1;
            var tarea = await context.Tareas.FindAsync(tareaId);

            if (tarea != null)
            {
                context.Tareas.Remove(tarea);
                await context.SaveChangesAsync();

                MessageBox.Show("Tarea eliminada exitosamente");
            }
            else
            {
                MessageBox.Show("Tarea no encontrada");
            }
        }
    }
}
