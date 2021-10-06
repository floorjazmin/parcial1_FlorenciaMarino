
namespace parcial1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtAñoInscripcion = new System.Windows.Forms.TextBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblAñoInscripcion = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.botGuardar = new System.Windows.Forms.Button();
            this.botSalir = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAñoNacimiento = new System.Windows.Forms.Label();
            this.lblMailContacto = new System.Windows.Forms.Label();
            this.txtAñoNacimiento = new System.Windows.Forms.TextBox();
            this.txtMailContacto = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoDeInscripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(59, 37);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 22);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(194, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(59, 84);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 22);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(194, 137);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(220, 26);
            this.txtDNI.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDni.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.Black;
            this.lblDni.Location = new System.Drawing.Point(73, 141);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(45, 22);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(194, 83);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(220, 26);
            this.txtApellido.TabIndex = 4;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.BackColor = System.Drawing.Color.Transparent;
            this.lblLegajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLegajo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.Black;
            this.lblLegajo.Location = new System.Drawing.Point(59, 191);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(67, 22);
            this.lblLegajo.TabIndex = 8;
            this.lblLegajo.Text = "Legajo";
            this.lblLegajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAñoInscripcion
            // 
            this.txtAñoInscripcion.Location = new System.Drawing.Point(194, 299);
            this.txtAñoInscripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAñoInscripcion.Name = "txtAñoInscripcion";
            this.txtAñoInscripcion.Size = new System.Drawing.Size(220, 26);
            this.txtAñoInscripcion.TabIndex = 11;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarrera.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.ForeColor = System.Drawing.Color.Black;
            this.lblCarrera.Location = new System.Drawing.Point(58, 246);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(77, 22);
            this.lblCarrera.TabIndex = 7;
            this.lblCarrera.Text = "Carrera";
            this.lblCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(194, 246);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(220, 26);
            this.txtCarrera.TabIndex = 10;
            // 
            // lblAñoInscripcion
            // 
            this.lblAñoInscripcion.AutoSize = true;
            this.lblAñoInscripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblAñoInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAñoInscripcion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoInscripcion.ForeColor = System.Drawing.Color.Black;
            this.lblAñoInscripcion.Location = new System.Drawing.Point(25, 300);
            this.lblAñoInscripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoInscripcion.Name = "lblAñoInscripcion";
            this.lblAñoInscripcion.Size = new System.Drawing.Size(161, 22);
            this.lblAñoInscripcion.TabIndex = 6;
            this.lblAñoInscripcion.Text = "Año de inscripción";
            this.lblAñoInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(194, 190);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(220, 26);
            this.txtLegajo.TabIndex = 9;
            // 
            // botGuardar
            // 
            this.botGuardar.BackColor = System.Drawing.Color.White;
            this.botGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botGuardar.ForeColor = System.Drawing.Color.Black;
            this.botGuardar.Location = new System.Drawing.Point(13, 469);
            this.botGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.botGuardar.Name = "botGuardar";
            this.botGuardar.Size = new System.Drawing.Size(136, 44);
            this.botGuardar.TabIndex = 12;
            this.botGuardar.Text = "Guardar";
            this.botGuardar.UseVisualStyleBackColor = false;
            this.botGuardar.Click += new System.EventHandler(this.botGuardar_Click);
            // 
            // botSalir
            // 
            this.botSalir.BackColor = System.Drawing.Color.White;
            this.botSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botSalir.ForeColor = System.Drawing.Color.Black;
            this.botSalir.Location = new System.Drawing.Point(375, 469);
            this.botSalir.Margin = new System.Windows.Forms.Padding(4);
            this.botSalir.Name = "botSalir";
            this.botSalir.Size = new System.Drawing.Size(148, 44);
            this.botSalir.TabIndex = 13;
            this.botSalir.Text = "Salir";
            this.botSalir.UseVisualStyleBackColor = false;
            this.botSalir.Click += new System.EventHandler(this.botSalir_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.SystemColors.Control;
            this.lblDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDatos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(118, 443);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(0, 22);
            this.lblDatos.TabIndex = 14;
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(194, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BotEliminar_Click);
            // 
            // lblAñoNacimiento
            // 
            this.lblAñoNacimiento.AutoSize = true;
            this.lblAñoNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblAñoNacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAñoNacimiento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoNacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblAñoNacimiento.Location = new System.Drawing.Point(25, 361);
            this.lblAñoNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoNacimiento.Name = "lblAñoNacimiento";
            this.lblAñoNacimiento.Size = new System.Drawing.Size(165, 22);
            this.lblAñoNacimiento.TabIndex = 16;
            this.lblAñoNacimiento.Text = "Año de Nacimiento";
            this.lblAñoNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMailContacto
            // 
            this.lblMailContacto.AutoSize = true;
            this.lblMailContacto.BackColor = System.Drawing.Color.Transparent;
            this.lblMailContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMailContacto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailContacto.ForeColor = System.Drawing.Color.Black;
            this.lblMailContacto.Location = new System.Drawing.Point(58, 421);
            this.lblMailContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailContacto.Name = "lblMailContacto";
            this.lblMailContacto.Size = new System.Drawing.Size(58, 22);
            this.lblMailContacto.TabIndex = 17;
            this.lblMailContacto.Text = "Email";
            this.lblMailContacto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAñoNacimiento
            // 
            this.txtAñoNacimiento.Location = new System.Drawing.Point(194, 360);
            this.txtAñoNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAñoNacimiento.Name = "txtAñoNacimiento";
            this.txtAñoNacimiento.Size = new System.Drawing.Size(220, 26);
            this.txtAñoNacimiento.TabIndex = 18;
            // 
            // txtMailContacto
            // 
            this.txtMailContacto.Location = new System.Drawing.Point(194, 417);
            this.txtMailContacto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMailContacto.Name = "txtMailContacto";
            this.txtMailContacto.Size = new System.Drawing.Size(220, 26);
            this.txtMailContacto.TabIndex = 19;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.AñoDeNacimiento,
            this.Email,
            this.Legajo,
            this.Carrera,
            this.AñoDeInscripción});
            this.dgvDatos.Location = new System.Drawing.Point(447, 26);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(611, 417);
            this.dgvDatos.TabIndex = 20;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // AñoDeNacimiento
            // 
            this.AñoDeNacimiento.HeaderText = "AñoDeNacimiento";
            this.AñoDeNacimiento.Name = "AñoDeNacimiento";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            // 
            // AñoDeInscripción
            // 
            this.AñoDeInscripción.HeaderText = "AñoDeInscripción";
            this.AñoDeInscripción.Name = "AñoDeInscripción";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 557);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtMailContacto);
            this.Controls.Add(this.txtAñoNacimiento);
            this.Controls.Add(this.lblMailContacto);
            this.Controls.Add(this.lblAñoNacimiento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.botSalir);
            this.Controls.Add(this.botGuardar);
            this.Controls.Add(this.txtAñoInscripcion);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblAñoInscripcion);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Registro de Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblAñoInscripcion;
        private System.Windows.Forms.TextBox txtAñoInscripcion;
        private System.Windows.Forms.Button botGuardar;
        private System.Windows.Forms.Button botSalir;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAñoNacimiento;
        private System.Windows.Forms.Label lblMailContacto;
        private System.Windows.Forms.TextBox txtAñoNacimiento;
        private System.Windows.Forms.TextBox txtMailContacto;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoDeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoDeInscripción;
    }
}

