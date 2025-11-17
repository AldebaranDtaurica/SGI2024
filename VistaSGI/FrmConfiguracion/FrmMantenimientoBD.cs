using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaSGI.FrmConfiguracion
{
    public partial class FrmMantenimientoBD : Form
    {
        CapaSistema.CSI_MantenimientoBD cSI_MantenimientoBD = new CapaSistema.CSI_MantenimientoBD();

        public FrmMantenimientoBD()
        {
            InitializeComponent();
        }

        private void BtnBackUP_Click(object sender, EventArgs e)
        {
            string accion = "BackUp de Base de Datos";
            if (ConfirmarAccion(accion) == true)
            {
                cSI_MantenimientoBD.RealizarBackUp();
            }
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            string accion = "Restaurar Base de Datos";
            if (ConfirmarAccion(accion) == true)
            {
                cSI_MantenimientoBD.RealizarRestauracion();
            }
        }

        private void BtnMantIndices_Click(object sender, EventArgs e)
        {
            string accion = "Mantenimiento de Índices y estadísticas";
            if (ConfirmarAccion(accion) == true)
            {
                cSI_MantenimientoBD.RealizarMantenimientoIndices();
            }
        }

        private void btnReducirLog_Click(object sender, EventArgs e)
        {
            string accion = "Reducción de Logs";
            if (ConfirmarAccion(accion) == true)
            {
                cSI_MantenimientoBD.RealizarReduccionLogs();
            }
        }

        private bool ConfirmarAccion(string accion)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de realizar esta acción? "+accion," Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Acción realizada con éxito", "Acción Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Acción cancelada", "Acción Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
