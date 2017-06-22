namespace TrabajoParcial
{
    partial class frmRegistrarEquipo
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
            this.DgvDESARROLLADORESDISPONIBLES = new System.Windows.Forms.DataGridView();
            this.SiglaDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvEQUIPO = new System.Windows.Forms.DataGridView();
            this.NombreProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CbSELECCIONAREQUIPO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvASIGNADOS = new System.Windows.Forms.DataGridView();
            this.NombreIntegrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdIntegrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoIntegrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butSELECT = new System.Windows.Forms.Button();
            this.butASIGNAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDESARROLLADORESDISPONIBLES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEQUIPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvASIGNADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDESARROLLADORESDISPONIBLES
            // 
            this.DgvDESARROLLADORESDISPONIBLES.AllowUserToAddRows = false;
            this.DgvDESARROLLADORESDISPONIBLES.AllowUserToDeleteRows = false;
            this.DgvDESARROLLADORESDISPONIBLES.BackgroundColor = System.Drawing.Color.White;
            this.DgvDESARROLLADORESDISPONIBLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDESARROLLADORESDISPONIBLES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiglaDocumento,
            this.NroDocumento,
            this.Nombre,
            this.Apellido,
            this.Id});
            this.DgvDESARROLLADORESDISPONIBLES.Location = new System.Drawing.Point(12, 17);
            this.DgvDESARROLLADORESDISPONIBLES.Name = "DgvDESARROLLADORESDISPONIBLES";
            this.DgvDESARROLLADORESDISPONIBLES.ReadOnly = true;
            this.DgvDESARROLLADORESDISPONIBLES.Size = new System.Drawing.Size(338, 370);
            this.DgvDESARROLLADORESDISPONIBLES.TabIndex = 0;
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
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DgvEQUIPO
            // 
            this.DgvEQUIPO.AllowUserToAddRows = false;
            this.DgvEQUIPO.AllowUserToDeleteRows = false;
            this.DgvEQUIPO.BackgroundColor = System.Drawing.Color.White;
            this.DgvEQUIPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEQUIPO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProyecto,
            this.Descripcion,
            this.Finalizado});
            this.DgvEQUIPO.Location = new System.Drawing.Point(505, 72);
            this.DgvEQUIPO.Name = "DgvEQUIPO";
            this.DgvEQUIPO.ReadOnly = true;
            this.DgvEQUIPO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DgvEQUIPO.Size = new System.Drawing.Size(334, 142);
            this.DgvEQUIPO.TabIndex = 1;
            // 
            // NombreProyecto
            // 
            this.NombreProyecto.DataPropertyName = "NombreProyecto";
            this.NombreProyecto.HeaderText = "Nombre Proyecto";
            this.NombreProyecto.Name = "NombreProyecto";
            this.NombreProyecto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Finalizado
            // 
            this.Finalizado.DataPropertyName = "Finalizado";
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.ReadOnly = true;
            // 
            // CbSELECCIONAREQUIPO
            // 
            this.CbSELECCIONAREQUIPO.FormattingEnabled = true;
            this.CbSELECCIONAREQUIPO.Location = new System.Drawing.Point(638, 17);
            this.CbSELECCIONAREQUIPO.Name = "CbSELECCIONAREQUIPO";
            this.CbSELECCIONAREQUIPO.Size = new System.Drawing.Size(201, 21);
            this.CbSELECCIONAREQUIPO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SELECCIONE EQUIPO :";
            // 
            // DgvASIGNADOS
            // 
            this.DgvASIGNADOS.AllowUserToAddRows = false;
            this.DgvASIGNADOS.AllowUserToDeleteRows = false;
            this.DgvASIGNADOS.BackgroundColor = System.Drawing.Color.White;
            this.DgvASIGNADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvASIGNADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreIntegrante,
            this.IdIntegrante,
            this.ApellidoIntegrante});
            this.DgvASIGNADOS.Location = new System.Drawing.Point(505, 220);
            this.DgvASIGNADOS.Name = "DgvASIGNADOS";
            this.DgvASIGNADOS.ReadOnly = true;
            this.DgvASIGNADOS.Size = new System.Drawing.Size(334, 167);
            this.DgvASIGNADOS.TabIndex = 6;
            // 
            // NombreIntegrante
            // 
            this.NombreIntegrante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreIntegrante.DataPropertyName = "NombreIntegrante";
            this.NombreIntegrante.HeaderText = "NombreIntegrante";
            this.NombreIntegrante.Name = "NombreIntegrante";
            this.NombreIntegrante.ReadOnly = true;
            // 
            // IdIntegrante
            // 
            this.IdIntegrante.DataPropertyName = "IdIntegrante";
            this.IdIntegrante.HeaderText = "IdIntegrante";
            this.IdIntegrante.Name = "IdIntegrante";
            this.IdIntegrante.ReadOnly = true;
            this.IdIntegrante.Visible = false;
            // 
            // ApellidoIntegrante
            // 
            this.ApellidoIntegrante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApellidoIntegrante.DataPropertyName = "ApellidoIntegrante";
            this.ApellidoIntegrante.HeaderText = "ApellidoIntegrante";
            this.ApellidoIntegrante.Name = "ApellidoIntegrante";
            this.ApellidoIntegrante.ReadOnly = true;
            // 
            // butSELECT
            // 
            this.butSELECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSELECT.ForeColor = System.Drawing.Color.Black;
            this.butSELECT.Image = global::TrabajoParcial.Properties.Resources.accept;
            this.butSELECT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSELECT.Location = new System.Drawing.Point(638, 45);
            this.butSELECT.Name = "butSELECT";
            this.butSELECT.Size = new System.Drawing.Size(131, 23);
            this.butSELECT.TabIndex = 5;
            this.butSELECT.Text = "SELECCIONAR";
            this.butSELECT.UseVisualStyleBackColor = true;
            this.butSELECT.Click += new System.EventHandler(this.butSELECT_Click);
            // 
            // butASIGNAR
            // 
            this.butASIGNAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butASIGNAR.ForeColor = System.Drawing.Color.Black;
            this.butASIGNAR.Image = global::TrabajoParcial.Properties.Resources.add1;
            this.butASIGNAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butASIGNAR.Location = new System.Drawing.Point(356, 199);
            this.butASIGNAR.Name = "butASIGNAR";
            this.butASIGNAR.Size = new System.Drawing.Size(143, 36);
            this.butASIGNAR.TabIndex = 4;
            this.butASIGNAR.Text = "ASIGNAR DESARROLLADOR";
            this.butASIGNAR.UseVisualStyleBackColor = true;
            this.butASIGNAR.Click += new System.EventHandler(this.butASIGNAR_Click);
            // 
            // frmRegistrarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 406);
            this.Controls.Add(this.DgvASIGNADOS);
            this.Controls.Add(this.butSELECT);
            this.Controls.Add(this.butASIGNAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbSELECCIONAREQUIPO);
            this.Controls.Add(this.DgvEQUIPO);
            this.Controls.Add(this.DgvDESARROLLADORESDISPONIBLES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(867, 445);
            this.MinimumSize = new System.Drawing.Size(867, 445);
            this.Name = "frmRegistrarEquipo";
            this.Text = "REGISTRAR EQUIPO";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDESARROLLADORESDISPONIBLES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEQUIPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvASIGNADOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDESARROLLADORESDISPONIBLES;
        private System.Windows.Forms.DataGridView DgvEQUIPO;
        private System.Windows.Forms.ComboBox CbSELECCIONAREQUIPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butASIGNAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finalizado;
        private System.Windows.Forms.Button butSELECT;
        private System.Windows.Forms.DataGridView DgvASIGNADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiglaDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreIntegrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIntegrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoIntegrante;
    }
}