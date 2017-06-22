namespace TrabajoParcial
{
    partial class frmDesarroladores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesarroladores));
            this.textFILTRO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgVDESARROLLADOR = new System.Windows.Forms.DataGridView();
            this.Siglas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.butAGREGAR = new System.Windows.Forms.Button();
            this.butFILTRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVDESARROLLADOR)).BeginInit();
            this.SuspendLayout();
            // 
            // textFILTRO
            // 
            this.textFILTRO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFILTRO.ForeColor = System.Drawing.Color.DarkGray;
            this.textFILTRO.Location = new System.Drawing.Point(74, 33);
            this.textFILTRO.Name = "textFILTRO";
            this.textFILTRO.Size = new System.Drawing.Size(576, 20);
            this.textFILTRO.TabIndex = 0;
            this.textFILTRO.Text = "POR NOMBRE O APELLIDO";
            this.textFILTRO.Click += new System.EventHandler(this.textFILTRO_Click);
            this.textFILTRO.TextChanged += new System.EventHandler(this.textFILTRO_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR :";
            // 
            // dgVDESARROLLADOR
            // 
            this.dgVDESARROLLADOR.AllowUserToAddRows = false;
            this.dgVDESARROLLADOR.AllowUserToDeleteRows = false;
            this.dgVDESARROLLADOR.AllowUserToResizeColumns = false;
            this.dgVDESARROLLADOR.AllowUserToResizeRows = false;
            this.dgVDESARROLLADOR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVDESARROLLADOR.BackgroundColor = System.Drawing.Color.White;
            this.dgVDESARROLLADOR.CausesValidation = false;
            this.dgVDESARROLLADOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVDESARROLLADOR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Siglas,
            this.NroDocumento,
            this.Nombre,
            this.Apellido});
            this.dgVDESARROLLADOR.Location = new System.Drawing.Point(18, 74);
            this.dgVDESARROLLADOR.Name = "dgVDESARROLLADOR";
            this.dgVDESARROLLADOR.ReadOnly = true;
            this.dgVDESARROLLADOR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVDESARROLLADOR.Size = new System.Drawing.Size(744, 370);
            this.dgVDESARROLLADOR.TabIndex = 3;
            // 
            // Siglas
            // 
            this.Siglas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Siglas.DataPropertyName = "Sigla_De_Documento";
            this.Siglas.HeaderText = "Siglas Documento";
            this.Siglas.Name = "Siglas";
            this.Siglas.ReadOnly = true;
            // 
            // NroDocumento
            // 
            this.NroDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NroDocumento.DataPropertyName = "Nro_Documento";
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TrabajoParcial.Properties.Resources.arrow_refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(521, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butAGREGAR
            // 
            this.butAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("butAGREGAR.Image")));
            this.butAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAGREGAR.Location = new System.Drawing.Point(656, 453);
            this.butAGREGAR.Name = "butAGREGAR";
            this.butAGREGAR.Size = new System.Drawing.Size(102, 36);
            this.butAGREGAR.TabIndex = 4;
            this.butAGREGAR.Text = "AGREGAR";
            this.butAGREGAR.UseVisualStyleBackColor = true;
            this.butAGREGAR.Click += new System.EventHandler(this.butAGREGAR_Click);
            // 
            // butFILTRAR
            // 
            this.butFILTRAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFILTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butFILTRAR.Image = ((System.Drawing.Image)(resources.GetObject("butFILTRAR.Image")));
            this.butFILTRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butFILTRAR.Location = new System.Drawing.Point(656, 30);
            this.butFILTRAR.Name = "butFILTRAR";
            this.butFILTRAR.Size = new System.Drawing.Size(102, 23);
            this.butFILTRAR.TabIndex = 1;
            this.butFILTRAR.Text = "FILTRAR";
            this.butFILTRAR.UseVisualStyleBackColor = true;
            this.butFILTRAR.Click += new System.EventHandler(this.butFILTRAR_Click);
            // 
            // frmDesarroladores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butAGREGAR);
            this.Controls.Add(this.dgVDESARROLLADOR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butFILTRAR);
            this.Controls.Add(this.textFILTRO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(787, 540);
            this.MinimumSize = new System.Drawing.Size(787, 540);
            this.Name = "frmDesarroladores";
            this.Text = "DESARROLLADORES";
            this.Load += new System.EventHandler(this.frmDesarroladores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVDESARROLLADOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFILTRO;
        private System.Windows.Forms.Button butFILTRAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVDESARROLLADOR;
        private System.Windows.Forms.Button butAGREGAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siglas;
        private System.Windows.Forms.Button button1;
    }
}