using System;
using System.Linq;
using System.Windows.Forms;
using Cliente.Data;
using System.Threading.Tasks;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // Verificar que el título no esté vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese un título y una descripción para la tarea.");
                return;
            }

            // Crear una nueva tarea usando los valores de los TextBox
            var tarea = new Tarea()
            {
                Title = textBox1.Text,  // Usando el título ingresado
                Description = textBoxDescripcion.Text,  // Usando la descripción ingresada
                IsCompleted = false
            };

            // Crear una instancia del DbContext (si no se ha creado previamente)
            using (var context = new TaskDbContext())
            {
                // Agregar la nueva tarea al DbSet
                context.Tareas.Add(tarea);

                // Guardar los cambios de manera asíncrona
                await context.SaveChangesAsync();
            }

            // Mostrar mensaje de éxito y limpiar los TextBox
            MessageBox.Show("Tarea creada exitosamente");
            textBox1.Clear();
            textBoxDescripcion.Clear();
        }


        private async void btnListarTarea_Click(object sender, EventArgs e)
        {
            var tareas = await context.Tareas.ToListAsync();
            dataGridView1.DataSource = tareas;

            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["Title"].HeaderText = "Título";
            dataGridView1.Columns["Description"].HeaderText = "Descripción";
            dataGridView1.Columns["IsCompleted"].HeaderText = "Completada";
        }

        private async void btnModificarTarea_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxId.Text, out int tareaId))
            {
                MessageBox.Show("Por favor, seleccione una tarea válida.");
                return;
            }

            var tarea = await context.Tareas.FindAsync(tareaId);

            if (tarea != null)
            {
                tarea.Title = textBox1.Text;
                tarea.Description = textBoxDescripcion.Text;
                await context.SaveChangesAsync();

                MessageBox.Show("Tarea modificada exitosamente");
                await ListarTareas(); // Refresca la lista de tareas
            }
            else
            {
                MessageBox.Show("Tarea no encontrada.");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Title"].Value.ToString();
                textBoxDescripcion.Text = row.Cells["Description"].Value.ToString();
                textBoxId.Text = row.Cells["Id"].Value.ToString(); // Si tienes un TextBox para el ID
            }
        }



        private async void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxId.Text, out int tareaId))
            {
                MessageBox.Show("Por favor, seleccione una tarea válida.");
                return;
            }

            var tarea = await context.Tareas.FindAsync(tareaId);

            if (tarea != null)
            {
                context.Tareas.Remove(tarea);
                await context.SaveChangesAsync();

                MessageBox.Show("Tarea eliminada exitosamente");
                await ListarTareas(); // Refresca la lista de tareas
            }
            else
            {
                MessageBox.Show("Tarea no encontrada.");
            }
        }
        private async Task ListarTareas()
        {
            var tareas = await context.Tareas.ToListAsync();
            dataGridView1.DataSource = tareas;
        }

    }
}
