namespace TrabajoParcial
{
    partial class frmAvance
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
            this.DgvAvance = new System.Windows.Forms.DataGridView();
            this.FechaAvance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiglaDelDocumentoDelDesarrollador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butRegistrarAvance = new System.Windows.Forms.Button();
            this.butEliminarAvance = new System.Windows.Forms.Button();
            this.butCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvance)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAvance
            // 
            this.DgvAvance.AllowUserToAddRows = false;
            this.DgvAvance.AllowUserToDeleteRows = false;
            this.DgvAvance.BackgroundColor = System.Drawing.Color.White;
            this.DgvAvance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAvance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaAvance,
            this.SiglaDelDocumentoDelDesarrollador,
            this.NombreCompleto,
            this.Porcentaje,
            this.Horas,
            this.Id});
            this.DgvAvance.Location = new System.Drawing.Point(12, 26);
            this.DgvAvance.Name = "DgvAvance";
            this.DgvAvance.ReadOnly = true;
            this.DgvAvance.Size = new System.Drawing.Size(602, 335);
            this.DgvAvance.TabIndex = 0;
            // 
            // FechaAvance
            // 
            this.FechaAvance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaAvance.DataPropertyName = "FechaAvance";
            this.FechaAvance.HeaderText = "Fecha Avance";
            this.FechaAvance.Name = "FechaAvance";
            this.FechaAvance.ReadOnly = true;
            // 
            // SiglaDelDocumentoDelDesarrollador
            // 
            this.SiglaDelDocumentoDelDesarrollador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SiglaDelDocumentoDelDesarrollador.DataPropertyName = "SiglaDelDocumentoDelDesarrollador";
            this.SiglaDelDocumentoDelDesarrollador.HeaderText = "Sigla Del Documento Del Desarrollador";
            this.SiglaDelDocumentoDelDesarrollador.Name = "SiglaDelDocumentoDelDesarrollador";
            this.SiglaDelDocumentoDelDesarrollador.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Porcentaje.DataPropertyName = "Porcentaje";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // Horas
            // 
            this.Horas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Horas.DataPropertyName = "Horas";
            this.Horas.HeaderText = "Horas";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // butRegistrarAvance
            // 
            this.butRegistrarAvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegistrarAvance.Image = global::TrabajoParcial.Properties.Resources.add;
            this.butRegistrarAvance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butRegistrarAvance.Location = new System.Drawing.Point(184, 377);
            this.butRegistrarAvance.Name = "butRegistrarAvance";
            this.butRegistrarAvance.Size = new System.Drawing.Size(159, 40);
            this.butRegistrarAvance.TabIndex = 3;
            this.butRegistrarAvance.Text = "REGISTRAR AVANCE";
            this.butRegistrarAvance.UseVisualStyleBackColor = true;
            this.butRegistrarAvance.Click += new System.EventHandler(this.butRegistrarAvance_Click);
            // 
            // butEliminarAvance
            // 
            this.butEliminarAvance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEliminarAvance.Image = global::TrabajoParcial.Properties.Resources.delete;
            this.butEliminarAvance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butEliminarAvance.Location = new System.Drawing.Point(349, 377);
            this.butEliminarAvance.Name = "butEliminarAvance";
            this.butEliminarAvance.Size = new System.Drawing.Size(159, 40);
            this.butEliminarAvance.TabIndex = 2;
            this.butEliminarAvance.Text = "ELIMINAR AVANCE";
            this.butEliminarAvance.UseVisualStyleBackColor = true;
            this.butEliminarAvance.Click += new System.EventHandler(this.butEliminarAvance_Click);
            // 
            // butCerrar
            // 
            this.butCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCerrar.Image = global::TrabajoParcial.Properties.Resources.door_out;
            this.butCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCerrar.Location = new System.Drawing.Point(514, 377);
            this.butCerrar.Name = "butCerrar";
            this.butCerrar.Size = new System.Drawing.Size(100, 40);
            this.butCerrar.TabIndex = 1;
            this.butCerrar.Text = "CERRAR";
            this.butCerrar.UseVisualStyleBackColor = true;
            this.butCerrar.Click += new System.EventHandler(this.butCerrar_Click);
            // 
            // frmAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 436);
            this.Controls.Add(this.butRegistrarAvance);
            this.Controls.Add(this.butEliminarAvance);
            this.Controls.Add(this.butCerrar);
            this.Controls.Add(this.DgvAvance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(643, 475);
            this.MinimumSize = new System.Drawing.Size(643, 475);
            this.Name = "frmAvance";
            this.Text = "AVANCE";
            ((System.ComponentModel.ISupportInitialize)(this.DgvAvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAvance;
        private System.Windows.Forms.Button butCerrar;
        private System.Windows.Forms.Button butEliminarAvance;
        private System.Windows.Forms.Button butRegistrarAvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiglaDelDocumentoDelDesarrollador;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAvance;
    }
}