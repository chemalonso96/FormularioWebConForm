namespace TrabajoParcial
{
    partial class frmReporte
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
            this.butReportesDeProyecto = new System.Windows.Forms.Button();
            this.DgvReporteResponsable = new System.Windows.Forms.DataGridView();
            this.SiglaDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantProyectosFinalizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantProyectosPendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeDeAvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvReporteProyecto = new System.Windows.Forms.DataGridView();
            this.Finalizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeAvanceAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTotalesAvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDesarrolladoresAsignados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaUltimaActualizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoDesarrolladorEnActualizar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butCerrar = new System.Windows.Forms.Button();
            this.butReportesPorResponsable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReporteResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReporteProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // butReportesDeProyecto
            // 
            this.butReportesDeProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReportesDeProyecto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butReportesDeProyecto.Image = global::TrabajoParcial.Properties.Resources.application_view_list;
            this.butReportesDeProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butReportesDeProyecto.Location = new System.Drawing.Point(12, 252);
            this.butReportesDeProyecto.Name = "butReportesDeProyecto";
            this.butReportesDeProyecto.Size = new System.Drawing.Size(139, 39);
            this.butReportesDeProyecto.TabIndex = 1;
            this.butReportesDeProyecto.Text = "REPORTE DE PROYECTOS";
            this.butReportesDeProyecto.UseVisualStyleBackColor = true;
            this.butReportesDeProyecto.Click += new System.EventHandler(this.butReportesDeProyecto_Click);
            // 
            // DgvReporteResponsable
            // 
            this.DgvReporteResponsable.AllowUserToAddRows = false;
            this.DgvReporteResponsable.AllowUserToDeleteRows = false;
            this.DgvReporteResponsable.BackgroundColor = System.Drawing.Color.White;
            this.DgvReporteResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReporteResponsable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiglaDocumento,
            this.NroDocumento,
            this.Nombre,
            this.Apellido,
            this.CantProyectosFinalizados,
            this.CantProyectosPendientes,
            this.PorcentajeDeAvance});
            this.DgvReporteResponsable.Location = new System.Drawing.Point(12, 73);
            this.DgvReporteResponsable.Name = "DgvReporteResponsable";
            this.DgvReporteResponsable.ReadOnly = true;
            this.DgvReporteResponsable.Size = new System.Drawing.Size(791, 173);
            this.DgvReporteResponsable.TabIndex = 3;
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
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // CantProyectosFinalizados
            // 
            this.CantProyectosFinalizados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantProyectosFinalizados.DataPropertyName = "CantProyectosFinalizados";
            this.CantProyectosFinalizados.HeaderText = "Cantidad de proyectos finalizados";
            this.CantProyectosFinalizados.Name = "CantProyectosFinalizados";
            this.CantProyectosFinalizados.ReadOnly = true;
            // 
            // CantProyectosPendientes
            // 
            this.CantProyectosPendientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantProyectosPendientes.DataPropertyName = "CantProyectosPendientes";
            this.CantProyectosPendientes.HeaderText = "Cantidad de proyectos Pendientes por finalizar";
            this.CantProyectosPendientes.Name = "CantProyectosPendientes";
            this.CantProyectosPendientes.ReadOnly = true;
            // 
            // PorcentajeDeAvance
            // 
            this.PorcentajeDeAvance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PorcentajeDeAvance.DataPropertyName = "PorcentajeDeAvance";
            this.PorcentajeDeAvance.HeaderText = "Porcentaje De Avance";
            this.PorcentajeDeAvance.Name = "PorcentajeDeAvance";
            this.PorcentajeDeAvance.ReadOnly = true;
            // 
            // DgvReporteProyecto
            // 
            this.DgvReporteProyecto.AllowUserToAddRows = false;
            this.DgvReporteProyecto.AllowUserToDeleteRows = false;
            this.DgvReporteProyecto.BackgroundColor = System.Drawing.Color.White;
            this.DgvReporteProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReporteProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Finalizado,
            this.FechaInicio,
            this.Name,
            this.PorcentajeAvanceAcumulado,
            this.HorasTotalesAvance,
            this.CantDesarrolladoresAsignados,
            this.FechaUltimaActualizacion,
            this.UltimoDesarrolladorEnActualizar});
            this.DgvReporteProyecto.Location = new System.Drawing.Point(13, 297);
            this.DgvReporteProyecto.Name = "DgvReporteProyecto";
            this.DgvReporteProyecto.ReadOnly = true;
            this.DgvReporteProyecto.Size = new System.Drawing.Size(790, 173);
            this.DgvReporteProyecto.TabIndex = 4;
            // 
            // Finalizado
            // 
            this.Finalizado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Finalizado.DataPropertyName = "Finalizado";
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.ReadOnly = true;
            this.Finalizado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Finalizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // PorcentajeAvanceAcumulado
            // 
            this.PorcentajeAvanceAcumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PorcentajeAvanceAcumulado.DataPropertyName = "PorcentajeAvanceAcumulado";
            this.PorcentajeAvanceAcumulado.HeaderText = "Porcentaje Avance Acumulado";
            this.PorcentajeAvanceAcumulado.Name = "PorcentajeAvanceAcumulado";
            this.PorcentajeAvanceAcumulado.ReadOnly = true;
            // 
            // HorasTotalesAvance
            // 
            this.HorasTotalesAvance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HorasTotalesAvance.DataPropertyName = "HorasTotalesAvance";
            this.HorasTotalesAvance.HeaderText = "Horas Totales";
            this.HorasTotalesAvance.Name = "HorasTotalesAvance";
            this.HorasTotalesAvance.ReadOnly = true;
            // 
            // CantDesarrolladoresAsignados
            // 
            this.CantDesarrolladoresAsignados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantDesarrolladoresAsignados.DataPropertyName = "CantDesarrolladoresAsignados";
            this.CantDesarrolladoresAsignados.HeaderText = "Cantidad De Desarroladores Asignados";
            this.CantDesarrolladoresAsignados.Name = "CantDesarrolladoresAsignados";
            this.CantDesarrolladoresAsignados.ReadOnly = true;
            // 
            // FechaUltimaActualizacion
            // 
            this.FechaUltimaActualizacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaUltimaActualizacion.DataPropertyName = "FechaUltimaActualizacion";
            this.FechaUltimaActualizacion.HeaderText = "Fecha Ultima Actualizacion";
            this.FechaUltimaActualizacion.Name = "FechaUltimaActualizacion";
            this.FechaUltimaActualizacion.ReadOnly = true;
            // 
            // UltimoDesarrolladorEnActualizar
            // 
            this.UltimoDesarrolladorEnActualizar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UltimoDesarrolladorEnActualizar.DataPropertyName = "UltimoDesarrolladorEnActualizar";
            this.UltimoDesarrolladorEnActualizar.HeaderText = "Ultimo Desarrollador En Actualizar";
            this.UltimoDesarrolladorEnActualizar.Name = "UltimoDesarrolladorEnActualizar";
            this.UltimoDesarrolladorEnActualizar.ReadOnly = true;
            // 
            // butCerrar
            // 
            this.butCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCerrar.Image = global::TrabajoParcial.Properties.Resources.cancel;
            this.butCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCerrar.Location = new System.Drawing.Point(625, 476);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(178, 23);
            this.butCerrar.TabIndex = 2;
            this.butCerrar.Text = "CERRAR";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // butReportesPorResponsable
            // 
            this.butReportesPorResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReportesPorResponsable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butReportesPorResponsable.Image = global::TrabajoParcial.Properties.Resources.user;
            this.butReportesPorResponsable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butReportesPorResponsable.Location = new System.Drawing.Point(12, 17);
            this.butReportesPorResponsable.Name = "butReportesPorResponsable";
            this.butReportesPorResponsable.Size = new System.Drawing.Size(139, 50);
            this.butReportesPorResponsable.TabIndex = 0;
            this.butReportesPorResponsable.Text = "REPORTE POR RESPONSABLE";
            this.butReportesPorResponsable.UseVisualStyleBackColor = true;
            this.butReportesPorResponsable.Click += new System.EventHandler(this.butReportesPorResponsable_Click);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 513);
            this.Controls.Add(this.DgvReporteProyecto);
            this.Controls.Add(this.DgvReporteResponsable);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.butReportesDeProyecto);
            this.Controls.Add(this.butReportesPorResponsable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
           
            this.Text = "RESPONSABLE";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReporteResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReporteProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butReportesPorResponsable;
        private System.Windows.Forms.Button butReportesDeProyecto;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.DataGridView DgvReporteResponsable;
        private System.Windows.Forms.DataGridView DgvReporteProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoDesarrolladorEnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaUltimaActualizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDesarrolladoresAsignados;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTotalesAvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeAvanceAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finalizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeDeAvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantProyectosPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantProyectosFinalizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiglaDocumento;
    }
}