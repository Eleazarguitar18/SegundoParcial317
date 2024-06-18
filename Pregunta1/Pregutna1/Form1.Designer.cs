namespace Pregutna1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
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

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mostrarDatos = new System.Windows.Forms.Button();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProbarConexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mostrarDatos
            // 
            this.mostrarDatos.Location = new System.Drawing.Point(58, 99);
            this.mostrarDatos.Name = "mostrarDatos";
            this.mostrarDatos.Size = new System.Drawing.Size(124, 51);
            this.mostrarDatos.TabIndex = 0;
            this.mostrarDatos.Text = "Mostrar Todo";
            this.mostrarDatos.UseVisualStyleBackColor = true;
            this.mostrarDatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(58, 196);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.RowHeadersWidth = 62;
            this.dataGridViewEstudiantes.RowTemplate.Height = 28;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(900, 339);
            this.dataGridViewEstudiantes.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Location = new System.Drawing.Point(216, 57);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(167, 26);
            this.txtNombreEstudiante.TabIndex = 3;
            this.txtNombreEstudiante.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matricula del Estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProbarConexion
            // 
            this.ProbarConexion.Location = new System.Drawing.Point(627, 57);
            this.ProbarConexion.Name = "ProbarConexion";
            this.ProbarConexion.Size = new System.Drawing.Size(148, 40);
            this.ProbarConexion.TabIndex = 5;
            this.ProbarConexion.Text = "Probar Conexion";
            this.ProbarConexion.UseVisualStyleBackColor = true;
            this.ProbarConexion.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 646);
            this.Controls.Add(this.ProbarConexion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewEstudiantes);
            this.Controls.Add(this.mostrarDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mostrarDatos;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProbarConexion;
    }
}

