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
    public partial class frmRegistrarEquipo : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        public frmRegistrarEquipo()
        {
            InitializeComponent();
            CargarDGVDESARROLLADOR();
            CargarDGVEQUIPO();
            CargarCBEQUIPO();
        }



        private void CargarDGVDESARROLLADOR()
        {
            DB = new PC1_Web_20171Entities();
            var query = DB.Desarrollador.Select(x => new
            {
                SiglaDocumento = x.TipoDocumento.Siglas,
                NroDocumento = x.NroDocumento,
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                id = x.DesarrolladorId
            }).AsQueryable();
            DgvDESARROLLADORESDISPONIBLES.DataSource = query.ToList();
        }
        


        private void CargarDGVEQUIPO()
        {
            DB = new PC1_Web_20171Entities();
            var query = DB.Proyecto.Select(x => new
            {
                NombreProyecto = x.Nombre,
                Descripcion=x.Descripcion,
                Finalizado=x.EstaFinalizado,
            }).AsQueryable();
            DgvEQUIPO.DataSource = query.ToList();
        }

        private void CargarCBEQUIPO()
        {
            DB = new PC1_Web_20171Entities();
            var query = DB.Proyecto.Select(x => new
            {
                proyecto = x.Nombre,
                id = x.ProyectoId
            }).AsQueryable();

            CbSELECCIONAREQUIPO.DataSource = query.ToList();
            CbSELECCIONAREQUIPO.DisplayMember = "proyecto";
            CbSELECCIONAREQUIPO.ValueMember = "id";
        }

        private void NoAsignadoYProyecto()
        {
            DB = new PC1_Web_20171Entities();
            var cb = Convert.ToInt32(CbSELECCIONAREQUIPO.SelectedValue);
            var query = DB.Proyecto.Where(x => x.ProyectoId == cb)
                .Select(x => new
                {
                    NombreProyecto=x.Nombre,
                    Descripcion=x.Descripcion,
                    Finalizado=x.EstaFinalizado
                }).AsQueryable();
            DgvEQUIPO.DataSource = query.ToList();
        }

        private void butSELECT_Click(object sender, EventArgs e)
        {
            DB = new PC1_Web_20171Entities();
            var cb = Convert.ToInt32(CbSELECCIONAREQUIPO.SelectedValue);
            var query = DB.Proyecto.Where(x => x.ProyectoId == cb)
                .Select(x => new
                {
                    NombreProyecto = x.Nombre,
                    Descripcion = x.Descripcion,
                    Finalizado = x.EstaFinalizado
                }).AsQueryable();
            DgvEQUIPO.DataSource = query.ToList();

            //MOSTRAR EN EL OTRO DGV LOS DESARROLLADORES NO ASGINADOS

            /*SELECT DISTINCT DesarrolladorId FROM DesarrolladorProyecto WHERE DesarrolladorId NOT IN
               (SELECT DesarrolladorId FROM DesarrolladorProyecto WHERE ProyectoId = 4)*/

            var Q = (from c in DB.Desarrollador
                    where !(from o in DB.DesarrolladorProyecto
                            where o.ProyectoId == cb
                            select o.DesarrolladorId).Contains(c.DesarrolladorId)
                           
                    select new
                    { SiglaDocumento = c.TipoDocumento.Siglas,
                      NroDocumento=c.NroDocumento,
                      Nombre=c.Nombre,
                      Apellido=c.Apellido,
                      Id=c.DesarrolladorId
                    }).Distinct();
            DgvDESARROLLADORESDISPONIBLES.DataSource = Q.ToList();

            /*************************************************/

            var I = DB.DesarrolladorProyecto.Where(y=>y.ProyectoId == cb).Select(x => new
            {
                NombreIntegrante = x.Desarrollador.Nombre,
                ApellidoIntegrante = x.Desarrollador.Apellido,
                IdIntegrante = x.DesarrolladorId,
            }).AsQueryable();

            DgvASIGNADOS.DataSource = I.ToList();
        }

        private void butASIGNAR_Click(object sender, EventArgs e)
        {
            if (DgvDESARROLLADORESDISPONIBLES.SelectedRows.Count == 0)
            {
                MessageBox.Show("SELECCIONE ALGUN DESARROLLADOR PARA ASIGNAR");
                return;
            }

            var cb = Convert.ToInt32(CbSELECCIONAREQUIPO.SelectedValue);
            var selectedDesarrolladorID = Convert.ToInt32(DgvDESARROLLADORESDISPONIBLES.SelectedRows[0].Cells["Id"].Value);
            var NombreDelNewAsignado = DgvDESARROLLADORESDISPONIBLES.SelectedRows[0].Cells["Nombre"].Value;
            

            
                DesarrolladorProyecto CdesarrolladorProyecto = new DesarrolladorProyecto();
                MessageBox.Show(NombreDelNewAsignado + " FUE DESIGNADO AL EQUIPO Nº " + CbSELECCIONAREQUIPO.SelectedValue);
                CdesarrolladorProyecto.DesarrolladorId = selectedDesarrolladorID;
                CdesarrolladorProyecto.ProyectoId = cb;
                CdesarrolladorProyecto.Fecha = DateTime.Now;
                DB.DesarrolladorProyecto.Add(CdesarrolladorProyecto);
                DB.SaveChanges();
            
        }
    }
}
