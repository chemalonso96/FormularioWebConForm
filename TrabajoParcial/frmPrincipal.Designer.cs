namespace TrabajoParcial
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dESARROLLADORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROYECTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROYECTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eQUIPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROEQUIPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVANCESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESARROLLADORESToolStripMenuItem,
            this.pROYECTOSToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dESARROLLADORESToolStripMenuItem
            // 
            this.dESARROLLADORESToolStripMenuItem.Name = "dESARROLLADORESToolStripMenuItem";
            this.dESARROLLADORESToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.dESARROLLADORESToolStripMenuItem.Text = "DESARROLLADORES";
            this.dESARROLLADORESToolStripMenuItem.Click += new System.EventHandler(this.dESARROLLADORESToolStripMenuItem_Click);
            // 
            // pROYECTOSToolStripMenuItem
            // 
            this.pROYECTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROYECTOToolStripMenuItem,
            this.eQUIPOToolStripMenuItem,
            this.rEGISTROEQUIPOToolStripMenuItem,
            this.aVANCESToolStripMenuItem1});
            this.pROYECTOSToolStripMenuItem.Name = "pROYECTOSToolStripMenuItem";
            this.pROYECTOSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pROYECTOSToolStripMenuItem.Text = "PROYECTOS";
            // 
            // pROYECTOToolStripMenuItem
            // 
            this.pROYECTOToolStripMenuItem.Name = "pROYECTOToolStripMenuItem";
            this.pROYECTOToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pROYECTOToolStripMenuItem.Text = "PROYECTO";
            this.pROYECTOToolStripMenuItem.Click += new System.EventHandler(this.pROYECTOToolStripMenuItem_Click);
            // 
            // eQUIPOToolStripMenuItem
            // 
            this.eQUIPOToolStripMenuItem.Name = "eQUIPOToolStripMenuItem";
            this.eQUIPOToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.eQUIPOToolStripMenuItem.Text = "EQUIPO";
            this.eQUIPOToolStripMenuItem.Click += new System.EventHandler(this.eQUIPOToolStripMenuItem_Click);
            // 
            // rEGISTROEQUIPOToolStripMenuItem
            // 
            this.rEGISTROEQUIPOToolStripMenuItem.Name = "rEGISTROEQUIPOToolStripMenuItem";
            this.rEGISTROEQUIPOToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.rEGISTROEQUIPOToolStripMenuItem.Text = "REGISTRO EQUIPO";
            this.rEGISTROEQUIPOToolStripMenuItem.Click += new System.EventHandler(this.rEGISTROEQUIPOToolStripMenuItem_Click);
            // 
            // aVANCESToolStripMenuItem1
            // 
            this.aVANCESToolStripMenuItem1.Name = "aVANCESToolStripMenuItem1";
            this.aVANCESToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.aVANCESToolStripMenuItem1.Text = "AVANCES";
            this.aVANCESToolStripMenuItem1.Click += new System.EventHandler(this.aVANCESToolStripMenuItem1_Click);
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            this.rEPORTESToolStripMenuItem.Click += new System.EventHandler(this.rEPORTESToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRABAJO PARCIAL";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TrabajoParcial.Properties.Resources.CRYmiBFUwAApssb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "TRABAJO PARCIAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dESARROLLADORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROYECTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem pROYECTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROEQUIPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVANCESToolStripMenuItem1;
    }
}

