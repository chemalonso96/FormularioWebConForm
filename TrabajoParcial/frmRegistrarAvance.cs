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
    public partial class frmRegistrarAvance : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        public frmRegistrarAvance()
        {
            InitializeComponent();
            CargarCbProyecto();
        }

        private Boolean ValidarDatos()
        {
            var error = "";

            if (String.IsNullOrEmpty(textDescripcion.Text))
                error += "Debe ingresar una descripcion" +
                    Environment.NewLine;

            if (String.IsNullOrEmpty(textPorcentaje.Text))
                error += "Debe ingresar un porcentaje" +
                    Environment.NewLine;


            if (String.IsNullOrEmpty(textHora.Text))
                error += "Debe ingresar una cantidad de horas" +
                    Environment.NewLine;

            if (!String.IsNullOrEmpty(error))
                MessageBox.Show("Ha ocurrido un error, revisar:" +
                    Environment.NewLine +
                    error);

            return String.IsNullOrEmpty(error);
        }

        private void CargarCbProyecto()
        {
            DB = new PC1_Web_20171Entities();
            var query = DB.Proyecto.Select(x => new {
                Name = x.Nombre,
                Id = x.ProyectoId
            }).AsQueryable();
            CbProyecto.DataSource = query.ToList();
            CbProyecto.DisplayMember = "Name";
            CbProyecto.ValueMember = "Id";
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
                return;
            DB = new PC1_Web_20171Entities();
            Avance avance = new Avance();

            avance.Descripcion = textDescripcion.Text;
            avance.Fecha = DateTime.Parse(DtpFecha.Text);
            avance.DesarrolladorReponsableId = Convert.ToInt32(CbDesarrollador.SelectedValue);
            avance.Porcentaje = Convert.ToInt32(textPorcentaje.Text);
            avance.Horas = Convert.ToInt32(textHora.Text);
            avance.ProyectoId = Convert.ToInt32(CbProyecto.SelectedValue);

            DB.Avance.Add(avance);
            DB.SaveChanges();
            this.Close();
        }

        private void butListar_Click(object sender, EventArgs e)
        {
            DB = new PC1_Web_20171Entities();
            var cb = Convert.ToInt32(CbProyecto.SelectedValue);
            var query = DB.DesarrolladorProyecto.Where(y => y.ProyectoId == cb).Select(x => new
            {
                Id = x.Desarrollador.DesarrolladorId,
                Name = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido
            }).AsQueryable();

            CbDesarrollador.DataSource = query.ToList();
            CbDesarrollador.DisplayMember = "Name";
            CbDesarrollador.ValueMember = "Id";
        }
    }
}
