using CapaLogica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaSesion;

namespace VistaSGI.FrmLogin
{
    public partial class FrmPerfiles : Form
    {
        CL_AbmPerfiles logica = new CL_AbmPerfiles();
        private DataTable dtListaBd;
        private DataTable dtListaMem = new DataTable("Permisos");

        public FrmPerfiles()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Configuración del DataGridView
            dtgPerfiles.MultiSelect = false;
            dtgPerfiles.RowHeadersVisible = false;
            dtgPerfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPerfiles.AllowUserToAddRows = false;
            dtgPerfiles.AllowUserToResizeRows = false;
            dtgPerfiles.ReadOnly = true;
            refreshDtg();

            // Inicializamos las columnas del DataTable para los permisos asignados
            DataColumn idColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.Int32"),
                ColumnName = "id_permiso"
            };
            dtListaMem.Columns.Add(idColumn);

            DataColumn fNameColumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "funcionalidad"
            };
            dtListaMem.Columns.Add(fNameColumn);

            // Cargar permisos en los ListBox
            lstPermisos.DataSource = null;
            dtListaBd = logica.ConsultarPermisosLst();
            lstPermisos.DataSource = dtListaBd;
            lstPermisos.ValueMember = "id_permiso";
            lstPermisos.DisplayMember = "funcionalidad";

            lstPermisosAsignados.DataSource = null;
            lstPermisosAsignados.DataSource = dtListaMem;
            lstPermisosAsignados.ValueMember = "id_permiso";
            lstPermisosAsignados.DisplayMember = "funcionalidad";
        }

        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            MoverPermisos(lstPermisos, lstPermisosAsignados);
        }

        private void btnDesasignarPermisos_Click(object sender, EventArgs e)
        {
            MoverPermisos(lstPermisosAsignados, lstPermisos);
        }

        private void MoverPermisos(ListBox origen, ListBox destino)
        {
            if (origen.SelectedItem != null)
            {
                DataRow row = ((DataRowView)origen.SelectedItem).Row;
                dtListaMem.ImportRow(row);
                origen.Items.RemoveAt(origen.SelectedIndex);
            }
        }

        private void btnAsignarPermisosTodos_Click(object sender, EventArgs e)
        {
            MoverTodosPermisos(lstPermisos, lstPermisosAsignados);
        }

        private void btnDesasignarPermisosTodos_Click(object sender, EventArgs e)
        {
            MoverTodosPermisos(lstPermisosAsignados, lstPermisos);
        }

        private void MoverTodosPermisos(ListBox origen, ListBox destino)
        {
            foreach (var item in origen.Items)
            {
                DataRow row = ((DataRowView)item).Row;
                dtListaMem.ImportRow(row);
            }
            origen.Items.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarPerfil();
        }

        private void AgregarPerfil()
        {
            if (!string.IsNullOrEmpty(txtNombrePermiso.Text) && lstPermisosAsignados.Items.Count > 0)
            {
                List<int> permisos = new List<int>();
                foreach (DataRow row in dtListaMem.Rows)
                {
                    permisos.Add((int)row["id_permiso"]);
                }
                logica.AltaPerfil(txtNombrePermiso.Text, txtDescripcion.Text, permisos.ToArray(), CSE_PermisoCache.IdUser);
                refreshDtg();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos y asignar permisos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            BajaPerfil();
        }

        private void BajaPerfil()
        {
            int perfilId = (int)dtgPerfiles.CurrentRow.Cells[0].Value;
            int idUser = CSE_UserCache.IdUser;
            logica.BajaPerfil(perfilId, idUser);
            refreshDtg();
        }

        private void refreshDtg()
        {
            dtgPerfiles.DataSource = logica.ConsultarPerfiles(false);
            dtgPerfiles.Columns[0].Visible = false;
        }
    }
}
