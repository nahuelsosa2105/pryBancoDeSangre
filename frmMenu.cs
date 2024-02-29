using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBancoDeSangre
{
    public partial class frmMenu : MaterialSkin.Controls.MaterialForm
    {
        clsBaseDeDatosPaciente objBaseDeDatosPaciente;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cmbGrupoSanguineo.ForeColor = Color.White;
            objBaseDeDatosPaciente = new clsBaseDeDatosPaciente();
            objBaseDeDatosPaciente.ConectarBD();

        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public static string grupoSanguineo;

        private void btnBuscarGrupo_Click(object sender, EventArgs e)
        {
            grupoSanguineo = cmbGrupoSanguineo.ToString();
            clsBaseDeDatosPaciente buscarGrupo = new clsBaseDeDatosPaciente();
            buscarGrupo.BuscarGrupo();


        }

        private void cmbGrupoSanguineo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
