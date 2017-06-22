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
    public partial class frmEquipo : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        public int dato { get; set; }
        public frmEquipo()
        {
            InitializeComponent();
            CargarDgv();
            CargarBox();
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDgv()
        {
            DB = new PC1_Web_20171Entities();
            var query = DB.DesarrolladorProyecto.Select(x => new
            {
                FechaAsociacion = x.Fecha,
                SiglaDocumento = x.Desarrollador.TipoDocumento.Siglas,
                NroDocumento = x.Desarrollador.NroDocumento,
                NombreCompleto = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                Nombre = x.Desarrollador.Nombre,
                Apellido = x.Desarrollador.Apellido,
                Id = x.Proyecto.ProyectoId
            }).AsQueryable();
            DgvEquipo.Columns["PorcentajeAcumulado"].Visible = false;
            DgvEquipo.Columns["HorasTotales"].Visible = false;
            DgvEquipo.DataSource = query.ToList();
        }

        private void CargarBox()
        {
            DB = new PC1_Web_20171Entities();
            var cb = DB.Proyecto.Select(x => new {
                Nombre = x.Nombre,
                Id =x.ProyectoId }).AsQueryable();
            CbElegirEquipo.DataSource = cb.ToList();
            CbElegirEquipo.DisplayMember = "Nombre";
            CbElegirEquipo.ValueMember = "Id";
        }

        private void butListarProyecto_Click(object sender, EventArgs e)
        {
            dato = Convert.ToInt32(CbElegirEquipo.SelectedValue);


           var query = DB.DesarrolladorProyecto
                .Where(y => y.ProyectoId == dato)
                .Select(x => new
            {
                FechaAsociacion = x.Fecha,
                SiglaDocumento = x.Desarrollador.TipoDocumento.Siglas,
                NroDocumento = x.Desarrollador.NroDocumento,
                NombreCompleto = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                Nombre = x.Desarrollador.Nombre,
                Apellido = x.Desarrollador.Apellido,
                PorcentajeAcumulado = x.Proyecto.Avance
                                        .Where(m=>m.DesarrolladorReponsableId == x.Desarrollador.DesarrolladorId)
                                        .Sum(z => (Decimal?)z.Porcentaje),
                HorasTotales = x.Proyecto.Avance
                                        .Where(m => m.DesarrolladorReponsableId == x.Desarrollador.DesarrolladorId)
                                        .Sum(z => (Decimal?)z.Horas),
                Id = x.Proyecto.ProyectoId
            }).AsQueryable();
            DgvEquipo.Columns["PorcentajeAcumulado"].Visible = true;
            DgvEquipo.Columns["HorasTotales"].Visible = true;
            DgvEquipo.DataSource = query.ToList();
        }

        private void DgvEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butApellido_Click(object sender, EventArgs e)
        {
            dato = Convert.ToInt32(CbElegirEquipo.SelectedValue);
            var query = DB.DesarrolladorProyecto.Select(x => new
            {
                FechaAsociacion = x.Fecha,
                SiglaDocumento = x.Desarrollador.TipoDocumento.Siglas,
                NroDocumento = x.Desarrollador.NroDocumento,
                NombreCompleto = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                Nombre = x.Desarrollador.Nombre,
                Apellido = x.Desarrollador.Apellido,
                PorcentajeAcumulado = x.Proyecto.Avance
                                        .Where(m => m.DesarrolladorReponsableId == x.Desarrollador.DesarrolladorId)
                                        .Sum(z => (Decimal?)z.Porcentaje),
                HorasTotales = x.Proyecto.Avance
                                        .Where(m => m.DesarrolladorReponsableId == x.Desarrollador.DesarrolladorId)
                                        .Sum(z => (Decimal?)z.Horas),
                Id = x.Proyecto.ProyectoId
            }).OrderBy(z => z.Apellido).Where(z => z.Id == dato).AsQueryable();
            DgvEquipo.DataSource = query.ToList();
        }

        private void butNombre_Click(object sender, EventArgs e)
        {
            dato = Convert.ToInt32(CbElegirEquipo.SelectedValue);
            var query = DB.DesarrolladorProyecto.Select(x => new
            {
                FechaAsociacion = x.Fecha,
                SiglaDocumento = x.Desarrollador.TipoDocumento.Siglas,
                NroDocumento = x.Desarrollador.NroDocumento,
                NombreCompleto = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                Nombre = x.Desarrollador.Nombre,
                Apellido = x.Desarrollador.Apellido,
                PorcentajeAcumulado = x.Proyecto.Avance
                                        .Where(m => m.DesarrolladorReponsableId == x.Desarrollador.DesarrolladorId)
                                        .Sum(z => (Decimal?)z.Porcentaje),
                HorasTotales = x.Proyecto.Avance
                                        .Where(m => m.DesarrolladorReponsableId == x.Desarrollador.DesarrolladorId)
                                        .Sum(z => (Decimal?)z.Horas),
                Id = x.Proyecto.ProyectoId
            }).OrderBy(z => z.Nombre).Where(z => z.Id == dato).AsQueryable();
            DgvEquipo.DataSource = query.ToList();
        }
    }
}
