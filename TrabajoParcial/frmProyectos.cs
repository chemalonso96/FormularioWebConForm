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
    public partial class frmProyectos : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        public frmProyectos()
        { 
            InitializeComponent();
            dgvPROYECTOS.AutoGenerateColumns = false;
            Cargar();
        }

        private void Cargar()
        {
            DB = new PC1_Web_20171Entities();
            var Query = DB.Proyecto.Select(x => new
            {
                ProyectoId = x.ProyectoId,
                Finalizado = x.EstaFinalizado,
                Fecha = x.Fecha,
                Nombre = x.Nombre,
                Desarrollador_Responsable = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                Porcentaje_Acumulado = x.Avance.Sum(y => (Decimal?)y.Porcentaje),
                Horas_Totales = x.Avance.Sum(z => (Decimal?)z.Horas),
                Descripcion = x.Descripcion
            }).AsQueryable();
            dgvPROYECTOS.DataSource = Query.ToList();
        }

        private void butFILTRAR_Click(object sender, EventArgs e)
        {
            DB = new PC1_Web_20171Entities();
            var Filtro = textFILTRO.Text;
            if (Filtro == "")
            {
                MessageBox.Show("NO HA ESCRITO NADA EN LA CASILLA DEL TEXTO ESCRIBA UN NOMBRE O DESCRIPCION");
                Cargar();
            }
            else if (Filtro == "POR NOMBRE O POR DESCRIPCION")
            {
                MessageBox.Show("NO HA ESCRITO NADA EN LA CASILLA DEL TEXTO ESCRIBA UN NOMBRE O DESCRIPCION");
                Cargar();
            }
            else if (Filtro != "" && Filtro != "POR NOMBRE O POR DESCRIPCION")
            {
                var Query = DB.Proyecto.Select(x => new
                {
                    ProyectoId = x.ProyectoId,
                    Finalizado = x.EstaFinalizado,
                    Fecha = x.Fecha,
                    Nombre = x.Nombre,
                    Desarrollador_Responsable = x.Desarrollador.Nombre + " " + x.Desarrollador.Apellido,
                    Porcentaje_Acumulado = x.Avance.Sum(y => (Decimal?)y.Porcentaje),
                    Horas_Totales = x.Avance.Sum(z => (Decimal?)z.Horas),
                    Descripcion = x.Descripcion
                }).Where(x => x.Nombre.Contains(Filtro) || x.Descripcion.Contains(Filtro)).AsQueryable();

                dgvPROYECTOS.DataSource = Query.ToList();
            }
            
            textFILTRO.Clear();

        }

        private void butAGREGAR_Click(object sender, EventArgs e)
        {
            var frmeditar = new frmEditProyecto(null);
            frmeditar.ShowDialog();
        }

        private void butEDITAR_Click(object sender, EventArgs e)
        {
            if (dgvPROYECTOS.SelectedRows.Count == 0)
            {
                MessageBox.Show("SELECCIONE ALGUN DATO PARA EDITAR");
                return;
            }
            var ProyectoId = Convert.ToInt32(dgvPROYECTOS.SelectedRows[0].Cells["ProyectoId"].Value);
            var frmeditar = new frmEditProyecto(ProyectoId);
            frmeditar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void frmProyectos_Load(object sender, EventArgs e)
        {
            
        }

        private void textFILTRO_Click(object sender, EventArgs e)
        {
            textFILTRO.Clear();
            textFILTRO.ForeColor = System.Drawing.Color.Black;
        }
    }
}
