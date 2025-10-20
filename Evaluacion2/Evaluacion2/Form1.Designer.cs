namespace Evaluacion2
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Contenido = new System.Windows.Forms.ListBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.btnVerTope = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(102, 11);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(218, 22);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.Datos_TextChanged);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(24, 17);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(56, 16);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Nombre";
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(367, 11);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 54);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(530, 10);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 54);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Contenido
            // 
            this.Contenido.FormattingEnabled = true;
            this.Contenido.ItemHeight = 16;
            this.Contenido.Location = new System.Drawing.Point(66, 185);
            this.Contenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(591, 164);
            this.Contenido.TabIndex = 4;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Location = new System.Drawing.Point(161, 151);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(82, 16);
            this.lblAdvertencia.TabIndex = 5;
            this.lblAdvertencia.Text = "Advertencia:";
            this.lblAdvertencia.Click += new System.EventHandler(this.lblAdvertencia_Click);
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(102, 42);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(218, 22);
            this.tbApellido.TabIndex = 6;
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(102, 75);
            this.tbCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(218, 22);
            this.tbCargo.TabIndex = 7;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(102, 113);
            this.tbSalario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(218, 22);
            this.tbSalario.TabIndex = 8;
            // 
            // btnVerTope
            // 
            this.btnVerTope.Location = new System.Drawing.Point(444, 81);
            this.btnVerTope.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerTope.Name = "btnVerTope";
            this.btnVerTope.Size = new System.Drawing.Size(127, 54);
            this.btnVerTope.TabIndex = 9;
            this.btnVerTope.Text = "Ver Tope";
            this.btnVerTope.UseVisualStyleBackColor = true;
            this.btnVerTope.Click += new System.EventHandler(this.btnVerTope_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cargo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerTope);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.tbNombre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox Contenido;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Button btnVerTope;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

