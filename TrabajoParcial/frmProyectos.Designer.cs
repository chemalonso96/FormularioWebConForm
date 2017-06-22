namespace TrabajoParcial
{
    partial class frmProyectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textFILTRO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPROYECTOS = new System.Windows.Forms.DataGridView();
            this.ProyectoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desarrollador_Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butEDITAR = new System.Windows.Forms.Button();
            this.butAGREGAR = new System.Windows.Forms.Button();
            this.butFILTRAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROYECTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // textFILTRO
            // 
            this.textFILTRO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFILTRO.ForeColor = System.Drawing.Color.DarkGray;
            this.textFILTRO.Location = new System.Drawing.Point(76, 36);
            this.textFILTRO.Name = "textFILTRO";
            this.textFILTRO.Size = new System.Drawing.Size(470, 20);
            this.textFILTRO.TabIndex = 0;
            this.textFILTRO.Text = "POR NOMBRE O POR DESCRIPCION";
            this.textFILTRO.Click += new System.EventHandler(this.textFILTRO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FILTRO :";
            // 
            // dgvPROYECTOS
            // 
            this.dgvPROYECTOS.AllowUserToAddRows = false;
            this.dgvPROYECTOS.AllowUserToDeleteRows = false;
            this.dgvPROYECTOS.AllowUserToResizeRows = false;
            this.dgvPROYECTOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPROYECTOS.BackgroundColor = System.Drawing.Color.White;
            this.dgvPROYECTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPROYECTOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProyectoId,
            this.Finalizado,
            this.Fecha,
            this.Nombre,
            this.Desarrollador_Responsable,
            this.Porcentaje,
            this.Horas,
            this.Descripcion});
            this.dgvPROYECTOS.Location = new System.Drawing.Point(22, 71);
            this.dgvPROYECTOS.Name = "dgvPROYECTOS";
            this.dgvPROYECTOS.ReadOnly = true;
            this.dgvPROYECTOS.Size = new System.Drawing.Size(616, 321);
            this.dgvPROYECTOS.TabIndex = 3;
            // 
            // ProyectoId
            // 
            this.ProyectoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProyectoId.DataPropertyName = "ProyectoId";
            this.ProyectoId.HeaderText = "ProyectoId";
            this.ProyectoId.Name = "ProyectoId";
            this.ProyectoId.ReadOnly = true;
            this.ProyectoId.Visible = false;
            // 
            // Finalizado
            // 
            this.Finalizado.DataPropertyName = "Finalizado";
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.ReadOnly = true;
            this.Finalizado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Finalizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Desarrollador_Responsable
            // 
            this.Desarrollador_Responsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desarrollador_Responsable.DataPropertyName = "Desarrollador_Responsable";
            this.Desarrollador_Responsable.HeaderText = "Desarrollador Responsable";
            this.Desarrollador_Responsable.Name = "Desarrollador_Responsable";
            this.Desarrollador_Responsable.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Porcentaje.DataPropertyName = "Porcentaje_Acumulado";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // Horas
            // 
            this.Horas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Horas.DataPropertyName = "Horas_Totales";
            dataGridViewCellStyle4.NullValue = "NULL";
            this.Horas.DefaultCellStyle = dataGridViewCellStyle4;
            this.Horas.HeaderText = "Horas Totales";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // butEDITAR
            // 
            this.butEDITAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEDITAR.ForeColor = System.Drawing.Color.Black;
            this.butEDITAR.Image = global::TrabajoParcial.Properties.Resources.pencil;
            this.butEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butEDITAR.Location = new System.Drawing.Point(430, 403);
            this.butEDITAR.Name = "butEDITAR";
            this.butEDITAR.Size = new System.Drawing.Size(99, 32);
            this.butEDITAR.TabIndex = 5;
            this.butEDITAR.Text = "EDITAR";
            this.butEDITAR.UseVisualStyleBackColor = true;
            this.butEDITAR.Click += new System.EventHandler(this.butEDITAR_Click);
            // 
            // butAGREGAR
            // 
            this.butAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAGREGAR.ForeColor = System.Drawing.Color.Black;
            this.butAGREGAR.Image = global::TrabajoParcial.Properties.Resources.add;
            this.butAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAGREGAR.Location = new System.Drawing.Point(535, 403);
            this.butAGREGAR.Name = "butAGREGAR";
            this.butAGREGAR.Size = new System.Drawing.Size(103, 32);
            this.butAGREGAR.TabIndex = 4;
            this.butAGREGAR.Text = "AGREGAR";
            this.butAGREGAR.UseVisualStyleBackColor = true;
            this.butAGREGAR.Click += new System.EventHandler(this.butAGREGAR_Click);
            // 
            // butFILTRAR
            // 
            this.butFILTRAR.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.butFILTRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFILTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFILTRAR.ForeColor = System.Drawing.Color.Black;
            this.butFILTRAR.Image = global::TrabajoParcial.Properties.Resources.find;
            this.butFILTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butFILTRAR.Location = new System.Drawing.Point(552, 36);
            this.butFILTRAR.Name = "butFILTRAR";
            this.butFILTRAR.Size = new System.Drawing.Size(86, 23);
            this.butFILTRAR.TabIndex = 2;
            this.butFILTRAR.Text = "FILTRAR";
            this.butFILTRAR.UseVisualStyleBackColor = true;
            this.butFILTRAR.Click += new System.EventHandler(this.butFILTRAR_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TrabajoParcial.Properties.Resources.arrow_refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(295, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butEDITAR);
            this.Controls.Add(this.butAGREGAR);
            this.Controls.Add(this.dgvPROYECTOS);
            this.Controls.Add(this.butFILTRAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textFILTRO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(681, 496);
            this.MinimumSize = new System.Drawing.Size(681, 496);
            this.Name = "frmProyectos";
            this.Text = "PROYECTOS";
            this.Load += new System.EventHandler(this.frmProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROYECTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFILTRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butFILTRAR;
        private System.Windows.Forms.DataGridView dgvPROYECTOS;
        private System.Windows.Forms.Button butAGREGAR;
        private System.Windows.Forms.Button butEDITAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desarrollador_Responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finalizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProyectoId;
        private System.Windows.Forms.Button button1;
    }
}