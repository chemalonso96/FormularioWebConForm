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
    public partial class frmAvance : Form
    {
        public PC1_Web_20171Entities DB { set; get; }
        public frmAvance()
        {
            InitializeComponent();
            CargarListaAvance();
        }

        private void CargarListaAvance()
        {
            DB = new PC1_Web_20171Entities();

            var QueryAvance = DB.Avance.OrderByDescending(y=>y.Fecha).Select(x => new
            {
                Id=x.AvanceId,
                FechaAvance = x.Fecha,
                SiglaDelDocumentoDelDesarrollador = x.Desarrollador.TipoDocumento.Siglas,
                NombreCompleto = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                Porcentaje = x.Porcentaje,
                Horas = x.Horas
            }).AsQueryable();

            DgvAvance.DataSource = QueryAvance.ToList();
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butRegistrarAvance_Click(object sender, EventArgs e)
        {
            var frmRegistrar = new frmRegistrarAvance();
            frmRegistrar.Show();
        }

        private void butEliminarAvance_Click(object sender, EventArgs e)
        {
            if (DgvAvance.SelectedRows.Count == 0)
            {
                MessageBox.Show("SELECCIONE ALGUN DATO PARA ELIMINAR");
                return;
            }
            var EliminarAvance = Convert.ToInt32(DgvAvance.SelectedRows[0].Cells["Id"].Value);
            Avance avance = new Avance();
            var remove = DB.Avance.Where(x => x.AvanceId == EliminarAvance).FirstOrDefault();
            DB.Avance.Remove(remove);
            DB.SaveChanges();
            CargarListaAvance();
        }
    }
}
