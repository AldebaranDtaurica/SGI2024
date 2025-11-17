using CapaLogica.CL_Model.Pers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaSGI
{
    public partial class FrmAlergias : Form
    {
        public FrmAlergias()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //bool chcActivo = true;
            CL_PersSaludAlergias PersSaludAlergias = new CL_PersSaludAlergias
            {
                Medicamentos = chcAmedic.Checked,
                InternacMedicamentos = chcIntmedic.Checked,
                PicInsect = chcApicinsecto.Checked,
                InternacPicInsect = chcPicinsecto.Checked,
                Vacunas = chcAvac.Checked,
                InternacVacunas = chcIntVac.Checked,
                Estacionales = chcEst.Checked,
                InternacEstacionales = chcIntEst.Checked,
                Alimentos = chcAlim.Checked,
                InternacAlimentos = chcIntAlim.Checked,
                Otras = chcOtras.Checked,
                InternacOtras = chcIntOtras.Checked,
                DescripOtras = txtDescAdic.Text,
            };

            PersSaludAlergias.GuardarDatos(PersSaludAlergias);
        }
    }
}
