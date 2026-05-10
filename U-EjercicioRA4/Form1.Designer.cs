namespace U_EjercicioRA4
{
    partial class FormInteraz
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
            this.lNombre = new System.Windows.Forms.Label();
            this.lEdad = new System.Windows.Forms.Label();
            this.lCorreo = new System.Windows.Forms.Label();
            this.ltelefono = new System.Windows.Forms.Label();
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Ltitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(41, 29);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(91, 13);
            this.lNombre.TabIndex = 0;
            this.lNombre.Text = "Nombre Completo";
            this.lNombre.Click += new System.EventHandler(this.lNombre_Click);
            // 
            // lEdad
            // 
            this.lEdad.AutoSize = true;
            this.lEdad.Location = new System.Drawing.Point(168, 29);
            this.lEdad.Name = "lEdad";
            this.lEdad.Size = new System.Drawing.Size(32, 13);
            this.lEdad.TabIndex = 1;
            this.lEdad.Text = "Edad";
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Location = new System.Drawing.Point(270, 29);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(33, 13);
            this.lCorreo.TabIndex = 2;
            this.lCorreo.Text = "Gmail";
            // 
            // ltelefono
            // 
            this.ltelefono.AutoSize = true;
            this.ltelefono.Location = new System.Drawing.Point(392, 29);
            this.ltelefono.Name = "ltelefono";
            this.ltelefono.Size = new System.Drawing.Size(49, 13);
            this.ltelefono.TabIndex = 3;
            this.ltelefono.Text = "Telefono";
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.txtTele);
            this.gbdatos.Controls.Add(this.txtCorreo);
            this.gbdatos.Controls.Add(this.txtEdad);
            this.gbdatos.Controls.Add(this.txtNombre);
            this.gbdatos.Controls.Add(this.lNombre);
            this.gbdatos.Controls.Add(this.ltelefono);
            this.gbdatos.Controls.Add(this.lEdad);
            this.gbdatos.Controls.Add(this.lCorreo);
            this.gbdatos.Location = new System.Drawing.Point(147, 143);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(495, 114);
            this.gbdatos.TabIndex = 4;
            this.gbdatos.TabStop = false;
            this.gbdatos.Text = "Datos:";
            this.gbdatos.Enter += new System.EventHandler(this.gbdatos_Enter);
            // 
            // txtTele
            // 
            this.txtTele.Location = new System.Drawing.Point(362, 54);
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(100, 20);
            this.txtTele.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(226, 54);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(119, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(163, 54);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(37, 20);
            this.txtEdad.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(204, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(343, 303);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(486, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Ltitulo
            // 
            this.Ltitulo.AutoSize = true;
            this.Ltitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltitulo.Location = new System.Drawing.Point(295, 44);
            this.Ltitulo.Name = "Ltitulo";
            this.Ltitulo.Size = new System.Drawing.Size(197, 31);
            this.Ltitulo.TabIndex = 9;
            this.Ltitulo.Text = "Actividad RA-4";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // FormInteraz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ltitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbdatos);
            this.Name = "FormInteraz";
            this.Text = "Form1";
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lEdad;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.Label ltelefono;
        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Ltitulo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

