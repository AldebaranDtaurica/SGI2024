using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaLogica.CL_Model.Pers;

namespace VistaSGI
{
    public partial class FrmActFisica : Form
    {
        public FrmActFisica()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            //bool chcActivo = true;
            CL_PersSaludEjercicio PersSaludEjercicio = new CL_PersSaludEjercicio
            {
                //IdPersSaludEjercicio = int.Parse(txtId.Text),
                //IdPersona = int.Parse(txtIdPersona.Text),

                //Activo = chcActivo,
                Desmayo = chcDesmayos.Checked,
                MayorCansancioQ = chcCansancioReg.Checked,
                DolorPecho = chcDolorPecho.Checked,
                Palpitaciones = chcPalpitaciones.Checked,
                Mareos = chcMareos.Checked,
                DifRespirarActFisic = chcDifRespiratoria.Checked,
                //Fecha = DateTime.Parse(txtFecha.Text),
                //Usuario = txtUsuario.Text
            };

            PersSaludEjercicio.GuardarDatos(PersSaludEjercicio);
        }

        // Llama al método para guardar los datos en la capa de datos
    }
}