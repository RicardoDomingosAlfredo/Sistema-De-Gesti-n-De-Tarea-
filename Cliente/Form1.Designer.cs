using System;

namespace Cliente
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // btnCrearTarea
            
            this.btnCrearTarea.Location = new System.Drawing.Point(27, 105);
            this.btnCrearTarea.Name = "btnCrearTarea";
            this.btnCrearTarea.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTarea.TabIndex = 0;
            this.btnCrearTarea.Text = "CrearTarea";
            this.btnCrearTarea.UseVisualStyleBackColor = true;
            this.btnCrearTarea.Click += new System.EventHandler(this.button1_Click);
            
            // btnListarTarea
            
            this.btnListarTarea.Location = new System.Drawing.Point(167, 105);
            this.btnListarTarea.Name = "btnListarTarea";
            this.btnListarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnListarTarea.TabIndex = 1;
            this.btnListarTarea.Text = "ListarTarea";
            this.btnListarTarea.UseVisualStyleBackColor = true;
            this.btnListarTarea.Click += new System.EventHandler(this.btnListarTarea_Click);
            
            // btnModificarTarea
          
            this.btnModificarTarea.Location = new System.Drawing.Point(27, 161);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(100, 23);
            this.btnModificarTarea.TabIndex = 2;
            this.btnModificarTarea.Text = "ModificarTarea";
            this.btnModificarTarea.UseVisualStyleBackColor = true;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            
            // textBox1
            
            this.textBox1.Location = new System.Drawing.Point(52, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            
            // dataGridView1
            
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            
            // btnEliminarTarea
             
            this.btnEliminarTarea.Location = new System.Drawing.Point(167, 161);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTarea.TabIndex = 5;
            this.btnEliminarTarea.Text = "EliminarTarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
             
            // Form1
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnCrearTarea;
        private System.Windows.Forms.Button btnListarTarea;
        private System.Windows.Forms.Button btnModificarTarea;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarTarea;
    }
}

