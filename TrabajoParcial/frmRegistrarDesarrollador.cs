using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoParcial
{
    public partial class frmRegistrarDesarrollador : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        public frmRegistrarDesarrollador()
        {
            InitializeComponent();
            CargarTipoDocumento();
        }
        private Boolean ValidarDatos()
        {
            var error = "";

            if (String.IsNullOrEmpty(textNOMBRE.Text))
                error += "Debe ingresar un nombre" +
                    Environment.NewLine;

            if (String.IsNullOrEmpty(textAPELLIDO.Text))
                error += "Debe ingresar un apellido" +
                    Environment.NewLine;


            if (String.IsNullOrEmpty(textNRODOCUMENTO.Text))
                error += "Debe ingresar un nro Documento" +
                    Environment.NewLine;

            if (!String.IsNullOrEmpty(error))
                MessageBox.Show("Ha ocurrido un error, revisar:" +
                    Environment.NewLine +
                    error);

            return String.IsNullOrEmpty(error);
        }

        private void CargarTipoDocumento()
        {
            DB = new PC1_Web_20171Entities();
            var TD = DB.TipoDocumento.Select(x =>new {
                Id = x.TipoDocumentoId,
                sigla =x.Siglas}).AsQueryable();
            CbTIPODOCUMENTO.DataSource = TD.ToList();
            CbTIPODOCUMENTO.DisplayMember = "sigla";
            CbTIPODOCUMENTO.ValueMember = "Id";
        }

        private void butGUARDAR_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            var developer = new Desarrollador();
            developer.TipoDocumentoId = Convert.ToInt32(CbTIPODOCUMENTO.SelectedValue);
            developer.Nombre = textNOMBRE.Text;
            developer.Apellido = textAPELLIDO.Text;
            developer.NroDocumento  =textNRODOCUMENTO.Text;
            developer.Estado = checkACT.Checked ? "ACT" : "INA";

            DB.Desarrollador.Add(developer);

            DB.SaveChanges();
            this.Close();
        }

        private void butCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarDesarrollador_Load(object sender, EventArgs e)
        {

        }
    }
}
