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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void dESARROLLADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDesarrollador = new frmDesarroladores();
            frmDesarrollador.ShowDialog();
        }
        private void pROYECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProyectos = new frmProyectos();
            frmProyectos.ShowDialog();
        }

        private void eQUIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEquipo = new frmEquipo();
            frmEquipo.ShowDialog();
        }

        private void rEGISTROEQUIPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmRegistraEquipo = new frmRegistrarEquipo();
            frmRegistraEquipo.ShowDialog();
        }

        private void aVANCESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frmListaAvances = new frmAvance();
            frmListaAvances.ShowDialog();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmreporte = new frmReporte();
            frmreporte.ShowDialog();
        }
    }
}
