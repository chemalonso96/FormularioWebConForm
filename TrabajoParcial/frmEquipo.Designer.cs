namespace TrabajoParcial
{
    partial class frmEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvEquipo = new System.Windows.Forms.DataGridView();
            this.FechaAsociacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiglaDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbElegirEquipo = new System.Windows.Forms.ComboBox();
            this.butNombre = new System.Windows.Forms.Button();
            this.butApellido = new System.Windows.Forms.Button();
            this.butListarProyecto = new System.Windows.Forms.Button();
            this.butCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEquipo
            // 
            this.DgvEquipo.AllowUserToAddRows = false;
            this.DgvEquipo.AllowUserToDeleteRows = false;
            this.DgvEquipo.BackgroundColor = System.Drawing.Color.White;
            this.DgvEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEquipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaAsociacion,
            this.SiglaDocumento,
            this.NroDocumento,
            this.NombreCompleto,
            this.PorcentajeAcumulado,
            this.HorasTotales,
            this.Nombre,
            this.Apellido,
            this.Id});
            this.DgvEquipo.Location = new System.Drawing.Point(12, 94);
            this.DgvEquipo.Name = "DgvEquipo";
            this.DgvEquipo.ReadOnly = true;
            this.DgvEquipo.Size = new System.Drawing.Size(517, 281);
            this.DgvEquipo.TabIndex = 0;
            this.DgvEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEquipo_CellContentClick);
            // 
            // FechaAsociacion
            // 
            this.FechaAsociacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaAsociacion.DataPropertyName = "FechaAsociacion";
            this.FechaAsociacion.HeaderText = "Fecha Asociacion";
            this.FechaAsociacion.Name = "FechaAsociacion";
            this.FechaAsociacion.ReadOnly = true;
            // 
            // SiglaDocumento
            // 
            this.SiglaDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SiglaDocumento.DataPropertyName = "SiglaDocumento";
            this.SiglaDocumento.HeaderText = "Sigla Documento";
            this.SiglaDocumento.Name = "SiglaDocumento";
            this.SiglaDocumento.ReadOnly = true;
            // 
            // NroDocumento
            // 
            this.NroDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NroDocumento.DataPropertyName = "NroDocumento";
            this.NroDocumento.HeaderText = "Nro Documento";
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // PorcentajeAcumulado
            // 
            this.PorcentajeAcumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PorcentajeAcumulado.DataPropertyName = "PorcentajeAcumulado";
            this.PorcentajeAcumulado.HeaderText = "Porcentaje Acumulado";
            this.PorcentajeAcumulado.Name = "PorcentajeAcumulado";
            this.PorcentajeAcumulado.ReadOnly = true;
            // 
            // HorasTotales
            // 
            this.HorasTotales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HorasTotales.DataPropertyName = "HorasTotales";
            this.HorasTotales.HeaderText = "Horas Totales";
            this.HorasTotales.Name = "HorasTotales";
            this.HorasTotales.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Visible = false;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ORDENAR POR :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ELEGIR EQUIPO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "O";
            // 
            // CbElegirEquipo
            // 
            this.CbElegirEquipo.FormattingEnabled = true;
            this.CbElegirEquipo.Location = new System.Drawing.Point(222, 22);
            this.CbElegirEquipo.Name = "CbElegirEquipo";
            this.CbElegirEquipo.Size = new System.Drawing.Size(163, 21);
            this.CbElegirEquipo.TabIndex = 11;
            // 
            // butNombre
            // 
            this.butNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNombre.Image = global::TrabajoParcial.Properties.Resources.user;
            this.butNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butNombre.Location = new System.Drawing.Point(222, 58);
            this.butNombre.Name = "butNombre";
            this.butNombre.Size = new System.Drawing.Size(138, 30);
            this.butNombre.TabIndex = 10;
            this.butNombre.Text = "Nombre";
            this.butNombre.UseVisualStyleBackColor = true;
            this.butNombre.Click += new System.EventHandler(this.butNombre_Click);
            // 
            // butApellido
            // 
            this.butApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butApellido.Image = global::TrabajoParcial.Properties.Resources.user;
            this.butApellido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butApellido.Location = new System.Drawing.Point(391, 58);
            this.butApellido.Name = "butApellido";
            this.butApellido.Size = new System.Drawing.Size(138, 30);
            this.butApellido.TabIndex = 8;
            this.butApellido.Text = "Apellido";
            this.butApellido.UseVisualStyleBackColor = true;
            this.butApellido.Click += new System.EventHandler(this.butApellido_Click);
            // 
            // butListarProyecto
            // 
            this.butListarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butListarProyecto.Image = global::TrabajoParcial.Properties.Resources.application_view_list;
            this.butListarProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butListarProyecto.Location = new System.Drawing.Point(391, 22);
            this.butListarProyecto.Name = "butListarProyecto";
            this.butListarProyecto.Size = new System.Drawing.Size(138, 30);
            this.butListarProyecto.TabIndex = 6;
            this.butListarProyecto.Text = "Listar Proyecto";
            this.butListarProyecto.UseVisualStyleBackColor = true;
            this.butListarProyecto.Click += new System.EventHandler(this.butListarProyecto_Click);
            // 
            // butCerrar
            // 
            this.butCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCerrar.Image = global::TrabajoParcial.Properties.Resources.cancel;
            this.butCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCerrar.Location = new System.Drawing.Point(425, 391);
            this.butCerrar.MaximumSize = new System.Drawing.Size(104, 23);
            this.butCerrar.MinimumSize = new System.Drawing.Size(104, 23);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(104, 23);
            this.butCerrar.TabIndex = 1;
            this.butCerrar.Text = "Cerrar";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 429);
            this.Controls.Add(this.CbElegirEquipo);
            this.Controls.Add(this.butNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butListarProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.DgvEquipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(558, 468);
            this.MinimumSize = new System.Drawing.Size(558, 468);
            this.Name = "frmEquipo";
            this.Text = "EQUIPO";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEquipo;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butListarProyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butNombre;
        private System.Windows.Forms.ComboBox CbElegirEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiglaDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAsociacion;
    }
}