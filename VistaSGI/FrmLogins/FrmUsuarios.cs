using System;
using System.Data;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmUsuarios : Form
    {
        private static FrmUsuarios instancia = null;
        public static FrmUsuarios ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new FrmUsuarios();
                return instancia;
            }
            return instancia;
        }

        public FrmUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIrMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAltaUsr_Click(object sender, EventArgs e)
        {
            FrmUsuarioAlta frmUsuarioAlta = new FrmUsuarioAlta();
            frmUsuarioAlta.ShowDialog(this);
        }

        private void btnBuscarUsr_Click(object sender, EventArgs e)
        {

        }

        private void btnLustaUsr_Click(object sender, EventArgs e)
        {
            CapaLogica.CL_Usuario clUsuario = new CapaLogica.CL_Usuario();
            // Consulta los usuarios
            DataTable dtUsuarios = clUsuario.ConsultarUsuarios();
            dtgUsuarios.DataSource = dtUsuarios;
        }
    }
}
