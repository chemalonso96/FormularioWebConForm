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
    public partial class frmDesarroladores : Form
    {
        public PC1_Web_20171Entities DB { get; set; }
        public frmDesarroladores()
        {
            InitializeComponent();
            dgVDESARROLLADOR.AutoGenerateColumns = false;
            CargarResultados();
           
        }

        private void CargarResultados()
        {
            DB = new PC1_Web_20171Entities();
            var QueryTipoDoc = DB.Desarrollador.Select(x => new
            {
                Sigla_De_Documento = x.TipoDocumento.Siglas,
                Nro_Documento = x.NroDocumento,
                Nombre = x.Nombre,
                Apellido = x.Apellido
            }).AsQueryable();
            dgVDESARROLLADOR.DataSource = QueryTipoDoc.ToList();
        }


        private void butFILTRAR_Click(object sender, EventArgs e)
        {

            DB = new PC1_Web_20171Entities();
            var filtro = textFILTRO.Text;
            if (filtro == "")
            {
                MessageBox.Show("NO HA ESCRITO NADA EN LA CASILLA DEL TEXTO ESCRIBA UN NOMBRE O APELLIDO");
                CargarResultados();
            }
            else if (filtro == "POR NOMBRE O APELLIDO")
            {
                MessageBox.Show("NO HA ESCRITO NADA EN LA CASILLA DEL TEXTO ESCRIBA UN NOMBRE O APELLIDO");
                CargarResultados();
            }
            else if (filtro != "" && filtro != "POR NOMBRE O APELLIDO")
            {

                var QueryTipoDoc = DB.Desarrollador.Select(x => new
                {
                    Sigla_De_Documento = x.TipoDocumento.Siglas,
                    Nro_Documento = x.NroDocumento,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido
                }).Where(x => x.Nombre.Contains(filtro) || x.Apellido.Contains(filtro)).AsQueryable();
                dgVDESARROLLADOR.DataSource = QueryTipoDoc.ToList();
            }
            
            textFILTRO.Clear();
            textFILTRO.ForeColor = System.Drawing.Color.DarkGray;
            textFILTRO.Text = "POR NOMBRE Y APELLIDO";
        }

        private void butAGREGAR_Click(object sender, EventArgs e)
        {
            var frmAgregar = new frmRegistrarDesarrollador();
            frmAgregar.ShowDialog();
            CargarResultados();
        }

        private void dgVDESARROLLADOR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDesarroladores_Load(object sender, EventArgs e)
        {
            
        }

        private void butACTUALIZAR_Click(object sender, EventArgs e)
        {
        }

        private void textFILTRO_TextChanged(object sender, EventArgs e)
        {
        }

        private void textFILTRO_Click(object sender, EventArgs e)
        {

            textFILTRO.Clear();
            textFILTRO.ForeColor = System.Drawing.Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarResultados();
        }
    }
}
