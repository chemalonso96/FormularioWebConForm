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
    public partial class frmEditProyecto : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        Int32? ProyectoID;
        public frmEditProyecto(Int32? ProyectoId)
        {
            ProyectoID = ProyectoId;
            InitializeComponent();
            ListarCbDesarrollador();
            Cargar();
        }

        public void ListarCbDesarrollador()
        {
            DB = new PC1_Web_20171Entities();
            var Lista = DB.Desarrollador.Select(x => new {
                Id = x.DesarrolladorId,
                NombreCompleto = x.Nombre + " " + x.Apellido
            }).AsQueryable();
            CbDESARROLLADOR.DataSource = Lista.ToList();
            CbDESARROLLADOR.DisplayMember="NombreCompleto";
            CbDESARROLLADOR.ValueMember = "Id";
        }

        public void Cargar()
        {
            DB = new PC1_Web_20171Entities();
            if (ProyectoID.HasValue)
            {
                var proyecto = DB.Proyecto.Find(ProyectoID);
                textNOMBRE.Text = proyecto.Nombre;
                textDESCRIPCION.Text = proyecto.Descripcion;
                CbDESARROLLADOR.SelectedValue = proyecto.DesarrolladorReponsableId;
                DtpFECHAFINALIZADO.Value = proyecto.Fecha;
                checkFINALIZADO.Checked = Convert.ToBoolean(proyecto.EstaFinalizado);
            }
        }

        private void butGUARDAR_Click(object sender, EventArgs e)
        {
            var proyecto = new Proyecto();
            if (ProyectoID.HasValue)
            {
                proyecto = DB.Proyecto.Find(ProyectoID);
            }
            else
            {
                DB.Proyecto.Add(proyecto);
            }
            //VALIDAR
          
            proyecto.Nombre = textNOMBRE.Text;
            proyecto.Descripcion = textDESCRIPCION.Text;
            proyecto.DesarrolladorReponsableId = Convert.ToInt32(CbDESARROLLADOR.SelectedValue);
            proyecto.Fecha = DtpFECHAFINALIZADO.Value;
            proyecto.EstaFinalizado = checkFINALIZADO.Checked ? true : false;

           
            DB.SaveChanges();
            this.Close();

        }
    
        private void butCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
