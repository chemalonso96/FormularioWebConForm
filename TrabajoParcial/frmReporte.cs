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
    public partial class frmReporte : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        public frmReporte()
        {
            InitializeComponent();
        }

        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butReportesPorResponsable_Click(object sender, EventArgs e)
        {
            DB = new PC1_Web_20171Entities();

            var query = DB.Proyecto.Select(x => new
             {
                 SiglaDocumento = x.Desarrollador.TipoDocumento.Siglas,

                 NroDocumento = x.Desarrollador.NroDocumento,

                 Nombre = x.Desarrollador.Nombre,

                 Apellido = x.Desarrollador.Apellido,

                 CantProyectosFinalizados = DB.Proyecto
                 .Where(z => z.DesarrolladorReponsableId == x.DesarrolladorReponsableId)
                 .Where(a => a.EstaFinalizado == true)
                 .Select(y => y.EstaFinalizado).Count(),

                 CantProyectosPendientes = DB.Proyecto
                 .Where(z => z.DesarrolladorReponsableId == x.DesarrolladorReponsableId)
                 .Where(a => a.EstaFinalizado == false)
                 .Select(y => y.EstaFinalizado).Count(),

                 PorcentajeDeAvance = (DB.Avance
                                              .Where(w => (w.Proyecto.DesarrolladorReponsableId == x.DesarrolladorReponsableId) &&
                                                         (w.Proyecto.EstaFinalizado == false))
                                              .Sum(s => (Decimal?)s.Porcentaje)) /
                                        (DB.Proyecto
                                                .Where(w => (w.DesarrolladorReponsableId == x.DesarrolladorReponsableId) &&
                                                           (w.EstaFinalizado == false))
                                                .Select(s => s.ProyectoId).Count())
            }).Distinct().ToList();

            DgvReporteResponsable.DataSource = query.ToList();
        }

        private void butReportesDeProyecto_Click(object sender, EventArgs e)
        {
            DB = new PC1_Web_20171Entities();
            var query = DB.Proyecto.Select(x => new
            {
                Finalizado = x.EstaFinalizado,//LISTO
                FechaInicio = x.Fecha,//FECHA DE INICIO DE LA CREACION
                Name = x.Nombre,//LISTO
                PorcentajeAvanceAcumulado = x.Avance.Sum(n => (Decimal?)n.Porcentaje),//LISTO
                HorasTotalesAvance = x.Avance.Sum(ñ => (Decimal?)ñ.Horas),//LISTO
                CantDesarrolladoresAsignados = x.DesarrolladorProyecto.Select(o => o.DesarrolladorId).Count(),//LISTO
                FechaUltimaActualizacion = x.Avance.OrderByDescending(m => m.Fecha).Select(l => l.Fecha).FirstOrDefault(),//LISTO
                UltimoDesarrolladorEnActualizar = x.Avance.OrderByDescending(m=>m.Fecha)
                .Select(o=>o.Desarrollador.Nombre).FirstOrDefault()
            }).AsQueryable();
            DgvReporteProyecto.DataSource = query.ToList();
        }
    }
}

