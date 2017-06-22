namespace TrabajoParcial
{
    partial class frmEditProyecto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNOMBRE = new System.Windows.Forms.TextBox();
            this.CbDESARROLLADOR = new System.Windows.Forms.ComboBox();
            this.checkFINALIZADO = new System.Windows.Forms.CheckBox();
            this.DtpFECHAFINALIZADO = new System.Windows.Forms.DateTimePicker();
            this.textDESCRIPCION = new System.Windows.Forms.TextBox();
            this.butGUARDAR = new System.Windows.Forms.Button();
            this.butCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPCION :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESARROLLADOR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA INICIO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FINALIZADO :";
            // 
            // textNOMBRE
            // 
            this.textNOMBRE.Location = new System.Drawing.Point(134, 26);
            this.textNOMBRE.Name = "textNOMBRE";
            this.textNOMBRE.Size = new System.Drawing.Size(200, 20);
            this.textNOMBRE.TabIndex = 5;
            // 
            // CbDESARROLLADOR
            // 
            this.CbDESARROLLADOR.FormattingEnabled = true;
            this.CbDESARROLLADOR.Location = new System.Drawing.Point(134, 97);
            this.CbDESARROLLADOR.Name = "CbDESARROLLADOR";
            this.CbDESARROLLADOR.Size = new System.Drawing.Size(200, 21);
            this.CbDESARROLLADOR.TabIndex = 6;
            // 
            // checkFINALIZADO
            // 
            this.checkFINALIZADO.AutoSize = true;
            this.checkFINALIZADO.Checked = true;
            this.checkFINALIZADO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFINALIZADO.Location = new System.Drawing.Point(134, 168);
            this.checkFINALIZADO.Name = "checkFINALIZADO";
            this.checkFINALIZADO.Size = new System.Drawing.Size(89, 17);
            this.checkFINALIZADO.TabIndex = 7;
            this.checkFINALIZADO.Text = "FINALIZADO";
            this.checkFINALIZADO.UseVisualStyleBackColor = true;
            // 
            // DtpFECHAFINALIZADO
            // 
            this.DtpFECHAFINALIZADO.Location = new System.Drawing.Point(134, 135);
            this.DtpFECHAFINALIZADO.Name = "DtpFECHAFINALIZADO";
            this.DtpFECHAFINALIZADO.Size = new System.Drawing.Size(200, 20);
            this.DtpFECHAFINALIZADO.TabIndex = 8;
            // 
            // textDESCRIPCION
            // 
            this.textDESCRIPCION.Location = new System.Drawing.Point(134, 61);
            this.textDESCRIPCION.Multiline = true;
            this.textDESCRIPCION.Name = "textDESCRIPCION";
            this.textDESCRIPCION.Size = new System.Drawing.Size(200, 20);
            this.textDESCRIPCION.TabIndex = 9;
            // 
            // butGUARDAR
            // 
            this.butGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGUARDAR.Image = global::TrabajoParcial.Properties.Resources.add;
            this.butGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butGUARDAR.Location = new System.Drawing.Point(220, 210);
            this.butGUARDAR.Name = "butGUARDAR";
            this.butGUARDAR.Size = new System.Drawing.Size(114, 23);
            this.butGUARDAR.TabIndex = 10;
            this.butGUARDAR.Text = "GUARDAR";
            this.butGUARDAR.UseVisualStyleBackColor = true;
            this.butGUARDAR.Click += new System.EventHandler(this.butGUARDAR_Click);
            // 
            // butCANCELAR
            // 
            this.butCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCANCELAR.Image = global::TrabajoParcial.Properties.Resources.cancel;
            this.butCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCANCELAR.Location = new System.Drawing.Point(100, 210);
            this.butCANCELAR.Name = "butCANCELAR";
            this.butCANCELAR.Size = new System.Drawing.Size(114, 23);
            this.butCANCELAR.TabIndex = 11;
            this.butCANCELAR.Text = "CANCELAR";
            this.butCANCELAR.UseVisualStyleBackColor = true;
            this.butCANCELAR.Click += new System.EventHandler(this.butCANCELAR_Click);
            // 
            // frmEditProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 257);
            this.Controls.Add(this.butCANCELAR);
            this.Controls.Add(this.butGUARDAR);
            this.Controls.Add(this.textDESCRIPCION);
            this.Controls.Add(this.DtpFECHAFINALIZADO);
            this.Controls.Add(this.checkFINALIZADO);
            this.Controls.Add(this.CbDESARROLLADOR);
            this.Controls.Add(this.textNOMBRE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(368, 296);
            this.MinimumSize = new System.Drawing.Size(368, 296);
            this.Name = "frmEditProyecto";
            this.Text = "EDITAR PROYECTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNOMBRE;
        private System.Windows.Forms.ComboBox CbDESARROLLADOR;
        private System.Windows.Forms.CheckBox checkFINALIZADO;
        private System.Windows.Forms.DateTimePicker DtpFECHAFINALIZADO;
        private System.Windows.Forms.TextBox textDESCRIPCION;
        private System.Windows.Forms.Button butGUARDAR;
        private System.Windows.Forms.Button butCANCELAR;
    }
}