using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        // Simulação de uma lista de tarefas
        private List<Tarefa> tarefas = new List<Tarefa>();

        public Form1()
        {
            InitializeComponent();
        }

        // Evento para criar uma nova tarefa
        private void button1_Click(object sender, EventArgs e)
        {
            string nomeTarefa = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(nomeTarefa))
            {
                var novaTarefa = new Tarefa
                {
                    Id = tarefas.Count + 1,
                    Nome = nomeTarefa,
                    DataCriacao = DateTime.Now
                };
                tarefas.Add(novaTarefa);

                MessageBox.Show("Tarefa criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarLista();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("O nome da tarefa não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para listar tarefas
        private void btnListarTarea_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        // Evento para modificar uma tarefa
        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            if (tarefas.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa para modificar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeAtualizado = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(nomeAtualizado))
            {
                var tarefa = tarefas[0]; // Para este exemplo, modifica a primeira tarefa
                tarefa.Nome = nomeAtualizado;

                MessageBox.Show("Tarefa modificada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarLista();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("O nome atualizado não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para excluir uma tarefa
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (tarefas.Count > 0)
            {
                tarefas.RemoveAt(0); // Para este exemplo, remove a primeira tarefa
                MessageBox.Show("Tarefa removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Nenhuma tarefa para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Atualiza a lista de tarefas no ListBox
        private void AtualizarLista()
        {
            listBox1.Items.Clear();
            foreach (var tarefa in tarefas)
            {
                listBox1.Items.Add($"ID: {tarefa.Id}, Nome: {tarefa.Nome}, Criada em: {tarefa.DataCriacao}");
            }
        }
    }

    // Classe Tarefa para simulação
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
