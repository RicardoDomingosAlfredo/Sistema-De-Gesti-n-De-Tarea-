using System;
using System.Linq;
using System.Windows.Forms;
using Cliente.Data;
using System.Threading.Tasks;

namespace Cliente
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.btnCrearTarea = new System.Windows.Forms.Button();
            this.btnListarTarea = new System.Windows.Forms.Button();
            this.btnModificarTarea = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearTarea
            // 
            this.btnCrearTarea.Location = new System.Drawing.Point(27, 121);
            this.btnCrearTarea.Name = "btnCrearTarea";
            this.btnCrearTarea.Size = new System.Drawing.Size(159, 34);
            this.btnCrearTarea.TabIndex = 0;
            this.btnCrearTarea.Text = "CrearTarea";
            this.btnCrearTarea.UseVisualStyleBackColor = true;
            this.btnCrearTarea.Click += new System.EventHandler(this.btnCrearTarea_Click);
            // 
            // btnListarTarea
            // 
            this.btnListarTarea.Location = new System.Drawing.Point(522, 121);
            this.btnListarTarea.Name = "btnListarTarea";
            this.btnListarTarea.Size = new System.Drawing.Size(159, 34);
            this.btnListarTarea.TabIndex = 1;
            this.btnListarTarea.Text = "ListarTarea";
            this.btnListarTarea.UseVisualStyleBackColor = true;
            this.btnListarTarea.Click += new System.EventHandler(this.btnListarTarea_Click);
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.Location = new System.Drawing.Point(192, 121);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(159, 34);
            this.btnModificarTarea.TabIndex = 2;
            this.btnModificarTarea.Text = "ModificarTarea";
            this.btnModificarTarea.UseVisualStyleBackColor = true;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 190);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(357, 121);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(159, 34);
            this.btnEliminarTarea.TabIndex = 5;
            this.btnEliminarTarea.Text = "EliminarTarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(317, 72);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(364, 20);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxId.Location = new System.Drawing.Point(27, 72);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(69, 20);
            this.textBoxId.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnModificarTarea);
            this.Controls.Add(this.btnListarTarea);
            this.Controls.Add(this.btnCrearTarea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTarea;
        private System.Windows.Forms.Button btnListarTarea;
        private System.Windows.Forms.Button btnModificarTarea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxId;

    }
}
